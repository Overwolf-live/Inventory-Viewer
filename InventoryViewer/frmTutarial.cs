using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventoryViewer
{
    public partial class frmTutarial : Form
    {
        Point moveStart;

        int r = 244, g = 65, b = 65;
        string color, EmptyLine;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6) {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }

            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg) {
                case WM_NCPAINT:
                    if (m_aeroEnabled) {
                        var v = 2;

                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);

                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }

        public frmTutarial()
        {
            InitializeComponent();

            m_aeroEnabled = false;

            lbltitle.Text = "Стровення бази даних, сторінка 1 з 3";

            pctBoxAppImg.Image = Properties.Resources.inventory;

            pctBoxCreateDataBase.Image = Properties.Resources.create_database;
            pctBoxSaveDataTable.Image = Properties.Resources.save_datatable;
            pctBoxFilDataTable.Image = Properties.Resources.fill_datatable;

            pnlSecondPage.Visible = false;
            pnlThirdPage.Visible = false;

            btnNext2.Visible = false;

            btnBack1.Visible = false;
            btnBack2.Visible = false;

            if (File.Exists(frmMain.settingsFilePath)) {
                using (StreamReader sr = new StreamReader(frmMain.settingsFilePath)) {
                    EmptyLine = sr.ReadLine();
                    color = sr.ReadLine();
                }
            }

            if (color == "PrimaryColor=Default")
            {
                pnlFormBorder.BackColor = Color.FromArgb(0, 120, 215);

                btnClose.BackColor = Color.FromArgb(0, 120, 215);

                btnNext1.BackColor = Color.FromArgb(0, 120, 215);
                btnNext2.BackColor = Color.FromArgb(0, 120, 215);

                btnBack1.BackColor = Color.FromArgb(0, 120, 215);
                btnBack2.BackColor = Color.FromArgb(0, 120, 215);
            }
            else if (color == "PrimaryColor=Orange")
            {
                pnlFormBorder.BackColor = Color.FromArgb(255, 165, 0);

                btnClose.BackColor = Color.FromArgb(255, 165, 0);

                btnNext1.BackColor = Color.FromArgb(255, 165, 0);
                btnNext2.BackColor = Color.FromArgb(255, 165, 0);

                btnBack1.BackColor = Color.FromArgb(255, 165, 0);
                btnBack2.BackColor = Color.FromArgb(255, 165, 0);
            }
            else if (color == "PrimaryColor=Magenta")
            {
                pnlFormBorder.BackColor = Color.FromArgb(255, 0, 255);

                btnClose.BackColor = Color.FromArgb(255, 0, 255);

                btnNext1.BackColor = Color.FromArgb(255, 0, 255);
                btnNext2.BackColor = Color.FromArgb(255, 0, 255);

                btnBack1.BackColor = Color.FromArgb(255, 0, 255);
                btnBack2.BackColor = Color.FromArgb(255, 0, 255);
            }
            else if (color == "PrimaryColor=Green")
            {
                pnlFormBorder.BackColor = Color.FromArgb(65, 205, 82);

                btnClose.BackColor = Color.FromArgb(65, 205, 82);

                btnNext1.BackColor = Color.FromArgb(65, 205, 82);
                btnNext2.BackColor = Color.FromArgb(65, 205, 82);

                btnBack1.BackColor = Color.FromArgb(65, 205, 82);
                btnBack2.BackColor = Color.FromArgb(65, 205, 82);
            }
            else if (color == "PrimaryColor=Purple")
            {
                pnlFormBorder.BackColor = Color.FromArgb(75, 0, 130);

                btnClose.BackColor = Color.FromArgb(75, 0, 130);

                btnNext1.BackColor = Color.FromArgb(75, 0, 130);
                btnNext2.BackColor = Color.FromArgb(75, 0, 130);

                btnBack1.BackColor = Color.FromArgb(75, 0, 130);
                btnBack2.BackColor = Color.FromArgb(75, 0, 130);
            }
            else if (color == "PrimaryColor=Pink")
            {
                pnlFormBorder.BackColor = Color.FromArgb(238, 130, 238);

                btnClose.BackColor = Color.FromArgb(238, 130, 238);

                btnNext1.BackColor = Color.FromArgb(238, 130, 238);
                btnNext2.BackColor = Color.FromArgb(238, 130, 238);

                btnBack1.BackColor = Color.FromArgb(238, 130, 238);
                btnBack2.BackColor = Color.FromArgb(238, 130, 238);
            }
            else if (color == "PrimaryColor=DarkCyan")
            {
                pnlFormBorder.BackColor = Color.FromArgb(0, 139, 139);

                btnClose.BackColor = Color.FromArgb(0, 139, 139);

                btnNext1.BackColor = Color.FromArgb(0, 139, 139);
                btnNext2.BackColor = Color.FromArgb(0, 139, 139);

                btnBack1.BackColor = Color.FromArgb(0, 139, 139);
                btnBack2.BackColor = Color.FromArgb(0, 139, 139);
            }
            else if (color == "PrimaryColor=Red")
            {
                pnlFormBorder.BackColor = Color.FromArgb(165, 42, 42);

                btnClose.BackColor = Color.FromArgb(165, 42, 42);

                btnNext1.BackColor = Color.FromArgb(165, 42, 42);
                btnNext2.BackColor = Color.FromArgb(165, 42, 42);

                btnBack1.BackColor = Color.FromArgb(165, 42, 42);
                btnBack2.BackColor = Color.FromArgb(165, 42, 42);
            }
            else if (color == "PrimaryColor=Black")
            {
                pnlFormBorder.BackColor = Color.FromArgb(0, 0, 0);

                btnClose.BackColor = Color.FromArgb(0, 0, 0);

                btnNext1.BackColor = Color.FromArgb(0, 0, 0);
                btnNext2.BackColor = Color.FromArgb(0, 0, 0);

                btnBack1.BackColor = Color.FromArgb(0, 0, 0);
                btnBack2.BackColor = Color.FromArgb(0, 0, 0);
            }
            else if (color == "PrimaryColor=Fade") {
                timerR.Start();
                timerG.Start();
                timerB.Start();
            }
            else {
                pnlFormBorder.BackColor = Color.FromArgb(0, 120, 215);

                btnClose.BackColor = Color.FromArgb(0, 120, 215);

                btnNext1.BackColor = Color.FromArgb(0, 120, 215);
                btnNext2.BackColor = Color.FromArgb(0, 120, 215);

                btnBack1.BackColor = Color.FromArgb(0, 120, 215);
                btnBack2.BackColor = Color.FromArgb(0, 120, 215);
            }
        }

        private void pnlFormBorder_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void pnlFormBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0) {
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);

                this.Location = new Point(this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);
            }
        }

        private void lbltitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                moveStart = new Point(e.X, e.Y);
            }
        }

        private void lbltitle_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0) {
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);

                this.Location = new Point(this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            btnBack1.Visible = true;
            btnNext2.Visible = true;

            pnlSecondPage.Visible = true;

            lbltitle.Text = "Стровення бази даних, сторінка 2 з 3";
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            btnBack1.Visible = false;
            btnNext2.Visible = false;

            pnlSecondPage.Visible = false;

            btnNext1.Visible = true;

            lbltitle.Text = "Стровення бази даних, сторінка 1 з 3";
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            btnBack2.Visible = true;
            btnBack1.Visible = false;

            btnNext1.Visible = false;
            btnNext2.Visible = false;

            pnlThirdPage.Visible = true;

            lbltitle.Text = "Стровення бази даних, сторінка 3 з 3";
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            btnBack2.Visible = false;
            btnBack1.Visible = true;

            pnlThirdPage.Visible = false;

            btnNext2.Visible = true;

            lbltitle.Text = "Стровення бази даних, сторінка 2 з 3";
        }

        private void frmTutarial_ClientSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void timerR_Tick(object sender, EventArgs e)
        {
            if (b >= 244) {
                r -= 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnNext1.BackColor = Color.FromArgb(r, g, b);
                btnNext2.BackColor = Color.FromArgb(r, g, b);

                btnBack1.BackColor = Color.FromArgb(r, g, b);
                btnBack2.BackColor = Color.FromArgb(r, g, b);

                if (r <= 65) {
                    timerR.Stop();
                    timerG.Start();
                }
            }

            if (b <= 65) {
                r += 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnNext1.BackColor = Color.FromArgb(r, g, b);
                btnNext2.BackColor = Color.FromArgb(r, g, b);

                btnBack1.BackColor = Color.FromArgb(r, g, b);
                btnBack2.BackColor = Color.FromArgb(r, g, b);

                if (r >= 244) {
                    timerR.Stop();
                    timerG.Start();
                }
            }
        }

        private void timerG_Tick(object sender, EventArgs e)
        {
            if (r <= 65) {
                g += 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnNext1.BackColor = Color.FromArgb(r, g, b);
                btnNext2.BackColor = Color.FromArgb(r, g, b);

                btnBack1.BackColor = Color.FromArgb(r, g, b);
                btnBack2.BackColor = Color.FromArgb(r, g, b);

                if (g >= 244) {
                    timerG.Stop();
                    timerB.Start();
                }
            }

            if (r >= 244) {
                g -= 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnNext1.BackColor = Color.FromArgb(r, g, b);
                btnNext2.BackColor = Color.FromArgb(r, g, b);

                btnBack1.BackColor = Color.FromArgb(r, g, b);
                btnBack2.BackColor = Color.FromArgb(r, g, b);

                if (g <= 65) {
                    timerG.Stop();
                    timerB.Start();
                }
            }
        }

        private void timerB_Tick(object sender, EventArgs e)
        {
            if (g <= 65) {
                b += 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnNext1.BackColor = Color.FromArgb(r, g, b);
                btnNext2.BackColor = Color.FromArgb(r, g, b);

                btnBack1.BackColor = Color.FromArgb(r, g, b);
                btnBack2.BackColor = Color.FromArgb(r, g, b);

                if (b >= 244) {
                    timerB.Stop();
                    timerR.Start();
                }
            }

            if (g >= 244) {
                b -= 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnNext1.BackColor = Color.FromArgb(r, g, b);
                btnNext2.BackColor = Color.FromArgb(r, g, b);

                btnBack1.BackColor = Color.FromArgb(r, g, b);
                btnBack2.BackColor = Color.FromArgb(r, g, b);

                if (b <= 65) {
                    timerB.Stop();
                    timerR.Start();
                }
            }
        }
    }
}