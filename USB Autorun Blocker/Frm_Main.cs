using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USB_Autorun_Blocker
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        string safestatus = "True";

        int count;

        int TogMove;
        int MValX;
        int MValY;

        private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void autorun_listener_Tick(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    if (safestatus == "True")
                    {
                        lbl2.Text = "Safe Drive : " + drive.Name;
                        lbl2.ForeColor = Color.Lime;
                        try
                        {
                            string[] tt = Directory.GetFiles(drive.Name, "*.inf", SearchOption.AllDirectories);
                            foreach (string bb in tt)
                            {
                                try
                                {
                                    File.Delete(bb);
                                    count++;
                                    lbl3.Text = "Deleted Autorun(s) : " + count;
                                }
                                catch
                                {

                                }
                            }
                        }
                        catch
                        {

                        }
                    }
                    else if (safestatus == "False")
                    {
                        lbl2.Text = "Safe Drive : " + drive.Name;
                        lbl2.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void status_listener_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                lbl3.ForeColor = Color.Lime;
            }
            else
            {
                lbl3.ForeColor = Color.Red;
            }
            if (safestatus == "True")
            {
                driveSafeStopToolStripMenuItem.Text = "Drive Safe Stop";
                lbl1.ForeColor = Color.Lime;
                lbl1.Text = "Safe : True";
                pb1.Visible = true;
                pb2.Visible = false;
            }
            else
            {
                driveSafeStopToolStripMenuItem.Text = "Drive Safe Start";
                lbl1.ForeColor = Color.Red;
                lbl1.Text = "Safe : False";
                pb1.Visible = false;
                pb2.Visible = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void driveSafeStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (driveSafeStopToolStripMenuItem.Text == "Drive Safe Start")
            {
                safestatus = "True";
            }else
            {
                safestatus = "False";
            }
        }

        private void whatMuchAutorunFileDeletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hide_application.Stop();
            this.Show();
        }

        private void hide_application_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pb3_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void pb3_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void pb3_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void lbl_window_text_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void lbl_window_text_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void lbl_window_text_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }
    }
}