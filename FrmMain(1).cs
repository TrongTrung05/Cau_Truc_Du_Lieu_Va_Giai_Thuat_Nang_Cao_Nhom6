using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNSNew
{
    public partial class FrmMain : Form
    {
        bool sidebarExpand;
        bool QLTTCTCollapse;
        bool QLTTCollapse;
        bool KTKLCollape;
        bool HTCollape;
        private string quyen;
        public FrmMain()
        {
            InitializeComponent();
           // quyen = pq;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }
      
        private void btnMenu_Click(object sender, EventArgs e)

        {
            if (QLTTCollapse)
            {
                QLTTCollapse = true;
                QLTTTimer.Start();
            }
            if (KTKLCollape)
            {
                KTKLCollape = true;
                KTKLTimer.Start();
            }
            if (QLTTCTCollapse)
            {
                QLTTCTCollapse = true;
                QLTTCTTimer.Start();
            }
            if (HTCollape)
            {
                HTCollape = true;
                HeThongTimer.Start();
            }
            SidebarTimer.Start();
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                Sidebarcontainer1.Width -= 10;
                if (Sidebarcontainer1.Width == Sidebarcontainer1.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebarcontainer1.Width += 10;
                if (Sidebarcontainer1.Width == Sidebarcontainer1.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    SidebarTimer.Stop();
                }
            }
        }

        

        private void btnQuanLyCT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSearch());
        }

        private void QLTTTimer_Tick(object sender, EventArgs e)
        {
            if (QLTTCollapse)
            {
                panelQLTT.Height -= 10;
                if (panelQLTT.Height == panelQLTT.MinimumSize.Height)
                {
                    QLTTCollapse= false;
                    QLTTTimer.Stop();
                }
            }
            else
            {
                panelQLTT.Height += 10;
                if (panelQLTT.Height == panelQLTT.MaximumSize.Height)
                {
                    QLTTCollapse = true;
                    QLTTTimer.Stop();
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KTKLCollape)
            {
                KTKLCollape = true;
                KTKLTimer.Start();
            }
            if (QLTTCTCollapse)
            {
                QLTTCTCollapse = true;
                QLTTCTTimer.Start();
            }
            if (HTCollape)
            {
                HTCollape = true;
                HeThongTimer.Start();
            }
            QLTTTimer.Start();
        }

       

        private void btnKTKL_Click(object sender, EventArgs e)
        {
            if (QLTTCollapse)
            {
                QLTTCollapse = true;
                QLTTTimer.Start();
            }
            if (QLTTCTCollapse)
            {
                QLTTCTCollapse = true;
                QLTTCTTimer.Start();
            }
            if (HTCollape)
            {
                HTCollape = true;
                HeThongTimer.Start();
            }
            KTKLTimer.Start();
        }

        private void HeThongTimer_Tick(object sender, EventArgs e)
        {
            if (HTCollape)
            {
                panelHeThong.Height -= 10;
                if (panelHeThong.Height == panelHeThong.MinimumSize.Height)
                {
                    HTCollape = false;
                    HeThongTimer.Stop();
                }
            }
            else
            {
                panelHeThong.Height += 10;
                if (panelHeThong.Height == panelHeThong.MaximumSize.Height)
                {
                    HTCollape = true;
                    HeThongTimer.Stop();
                }
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            if (QLTTCollapse)
            {
                QLTTCollapse = true;
                QLTTTimer.Start();
            }
            if (KTKLCollape)
            {
                KTKLCollape = true;
                KTKLTimer.Start();
            }
            if (QLTTCTCollapse)
            {
                QLTTCTCollapse = true;
                QLTTCTTimer.Start();
            }
            HeThongTimer.Start();
        }

        private void timertime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void OpenChildForm(Form childForm)
        {
            paneChild.Controls.Clear();
    
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneChild.Controls.Add(childForm);
            paneChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnQuanLyAVL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuanLyAVL());
        }

        private void btnQuanLyRB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmQuanLyRB());
        }

        //private void btnNhanVien_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new FrmNhanVien());
        //}


    }
}
