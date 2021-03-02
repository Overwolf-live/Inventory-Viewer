using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventoryViewer
{
    public partial class frmSettings : Form
    {
        Point moveStart;

        int borderSize = 2, r = 244, g = 65, b = 65;
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

                        MARGINS margins = new MARGINS() {
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

        public frmSettings()
        {
            InitializeComponent();

            m_aeroEnabled = false;

            lbltitle.Text = "Налаштування";

            lblUserName.Text = "Welcome, " + System.Environment.UserName;

            pctBoxAppImg.Image = Properties.Resources.inventory;
            pctBoxPreviewAppImg.Image = Properties.Resources.inventory;

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

                pnlPreviewFormBorder.BackColor = Color.FromArgb(0, 120, 215);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(0, 120, 215);

                btnPreviewHide.BackColor = Color.FromArgb(0, 120, 215);
                btnPreviewMaximize.BackColor = Color.FromArgb(0, 120, 215);
                btnPreviewClose.BackColor = Color.FromArgb(0, 120, 215);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(0, 120, 215);

                btnApply.BackColor = Color.FromArgb(0, 120, 215);
            }
            else if (color == "PrimaryColor=Orange")
            {
                pnlFormBorder.BackColor = Color.FromArgb(255, 165, 0);

                btnClose.BackColor = Color.FromArgb(255, 165, 0);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(255, 165, 0);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(255, 165, 0);

                btnPreviewHide.BackColor = Color.FromArgb(255, 165, 0);
                btnPreviewMaximize.BackColor = Color.FromArgb(255, 165, 0);
                btnPreviewClose.BackColor = Color.FromArgb(255, 165, 0);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(255, 165, 0);

                btnApply.BackColor = Color.FromArgb(255, 165, 0);
            }
            else if (color == "PrimaryColor=Magenta")
            {
                pnlFormBorder.BackColor = Color.FromArgb(255, 0, 255);

                btnClose.BackColor = Color.FromArgb(255, 0, 255);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(255, 0, 255);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(255, 0, 255);

                btnPreviewHide.BackColor = Color.FromArgb(255, 0, 255);
                btnPreviewMaximize.BackColor = Color.FromArgb(255, 0, 255);
                btnPreviewClose.BackColor = Color.FromArgb(255, 0, 255);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(255, 0, 255);

                btnApply.BackColor = Color.FromArgb(255, 0, 255);
            }
            else if (color == "PrimaryColor=Green")
            {
                pnlFormBorder.BackColor = Color.FromArgb(65, 205, 82);

                btnClose.BackColor = Color.FromArgb(65, 205, 82);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(65, 205, 82);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(65, 205, 82);

                btnPreviewHide.BackColor = Color.FromArgb(65, 205, 82);
                btnPreviewMaximize.BackColor = Color.FromArgb(65, 205, 82);
                btnPreviewClose.BackColor = Color.FromArgb(65, 205, 82);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(65, 205, 82);

                btnApply.BackColor = Color.FromArgb(65, 205, 82);
            }
            else if (color == "PrimaryColor=Purple")
            {
                pnlFormBorder.BackColor = Color.FromArgb(75, 0, 130);

                btnClose.BackColor = Color.FromArgb(75, 0, 130);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(75, 0, 130);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(75, 0, 130);

                btnPreviewHide.BackColor = Color.FromArgb(75, 0, 130);
                btnPreviewMaximize.BackColor = Color.FromArgb(75, 0, 130);
                btnPreviewClose.BackColor = Color.FromArgb(75, 0, 130);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(75, 0, 130);

                btnApply.BackColor = Color.FromArgb(75, 0, 130);
            }
            else if (color == "PrimaryColor=Pink")
            {
                pnlFormBorder.BackColor = Color.FromArgb(238, 130, 238);

                btnClose.BackColor = Color.FromArgb(238, 130, 238);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(238, 130, 238);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(238, 130, 238);

                btnPreviewHide.BackColor = Color.FromArgb(238, 130, 238);
                btnPreviewMaximize.BackColor = Color.FromArgb(238, 130, 238);
                btnPreviewClose.BackColor = Color.FromArgb(238, 130, 238);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(238, 130, 238);

                btnApply.BackColor = Color.FromArgb(238, 130, 238);
            }
            else if (color == "PrimaryColor=DarkCyan")
            {
                pnlFormBorder.BackColor = Color.FromArgb(0, 139, 139);

                btnClose.BackColor = Color.FromArgb(0, 139, 139);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(0, 139, 139);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(0, 139, 139);

                btnPreviewHide.BackColor = Color.FromArgb(0, 139, 139);
                btnPreviewMaximize.BackColor = Color.FromArgb(0, 139, 139);
                btnPreviewClose.BackColor = Color.FromArgb(0, 139, 139);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(0, 139, 139);

                btnApply.BackColor = Color.FromArgb(0, 139, 139);
            }
            else if (color == "PrimaryColor=Red")
            {
                pnlFormBorder.BackColor = Color.FromArgb(165, 42, 42);

                btnClose.BackColor = Color.FromArgb(165, 42, 42);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(165, 42, 42);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(165, 42, 42);

                btnPreviewHide.BackColor = Color.FromArgb(165, 42, 42);
                btnPreviewMaximize.BackColor = Color.FromArgb(165, 42, 42);
                btnPreviewClose.BackColor = Color.FromArgb(165, 42, 42);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(165, 42, 42);

                btnApply.BackColor = Color.FromArgb(165, 42, 42);
            }
            else if (color == "PrimaryColor=Black")
            {
                pnlFormBorder.BackColor = Color.FromArgb(0, 0, 0);

                btnClose.BackColor = Color.FromArgb(0, 0, 0);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(0, 0, 0);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(0, 0, 0);

                btnPreviewHide.BackColor = Color.FromArgb(0, 0, 0);
                btnPreviewMaximize.BackColor = Color.FromArgb(0, 0, 0);
                btnPreviewClose.BackColor = Color.FromArgb(0, 0, 0);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(0, 0, 0);

                btnApply.BackColor = Color.FromArgb(0, 0, 0);
            }
            else if (color == "PrimaryColor=Fade") {
                timerR.Start();
                timerG.Start();
                timerB.Start();
            }
            else
            {
                pnlFormBorder.BackColor = Color.FromArgb(0, 120, 215);

                btnClose.BackColor = Color.FromArgb(0, 120, 215);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(0, 120, 215);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(0, 120, 215);

                btnPreviewHide.BackColor = Color.FromArgb(0, 120, 215);
                btnPreviewMaximize.BackColor = Color.FromArgb(0, 120, 215);
                btnPreviewClose.BackColor = Color.FromArgb(0, 120, 215);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(0, 120, 215);

                btnApply.BackColor = Color.FromArgb(0, 120, 215);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnDefaultColor_Click(object sender, EventArgs e)
        {
            pnlPreviewFormBorder.BackColor = Color.FromArgb(51, 153, 255);
            pnlPreviewFormMenu.BackColor = Color.FromArgb(51, 153, 255);

            btnPreviewHide.BackColor = Color.FromArgb(51, 153, 255);
            btnPreviewMaximize.BackColor = Color.FromArgb(51, 153, 255);
            btnPreviewClose.BackColor = Color.FromArgb(51, 153, 255);
            btnPreviewChooseDataBase.BackColor = Color.FromArgb(51, 153, 255);

            color = "Default";

            timerR.Stop();
            timerG.Stop();
            timerB.Stop();
        }

        private void btnDefaultColor_MouseEnter(object sender, EventArgs e)
        {
            btnDefaultColor.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            btnDefaultColor.FlatAppearance.BorderSize = borderSize;
        }

        private void btnDefaultColor_MouseLeave(object sender, EventArgs e)
        {
            btnDefaultColor.FlatAppearance.BorderSize = 0;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            pnlPreviewFormBorder.BackColor = Color.FromArgb(255, 165, 0);
            pnlPreviewFormMenu.BackColor = Color.FromArgb(255, 165, 0);

            btnPreviewHide.BackColor = Color.FromArgb(255, 165, 0);
            btnPreviewMaximize.BackColor = Color.FromArgb(255, 165, 0);
            btnPreviewClose.BackColor = Color.FromArgb(255, 165, 0);
            btnPreviewChooseDataBase.BackColor = Color.FromArgb(255, 165, 0);

            color = "Orange";

            timerR.Stop();
            timerG.Stop();
            timerB.Stop();
        }

        private void btnOrange_MouseEnter(object sender, EventArgs e)
        {
            btnOrange.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            btnOrange.FlatAppearance.BorderSize = borderSize;
        }

        private void btnOrange_MouseLeave(object sender, EventArgs e)
        {
            btnOrange.FlatAppearance.BorderSize = 0;
        }

        private void btnMagenta_Click(object sender, EventArgs e)
        {
            pnlPreviewFormBorder.BackColor = Color.FromArgb(255, 0, 255);
            pnlPreviewFormMenu.BackColor = Color.FromArgb(255, 0, 255);

            btnPreviewHide.BackColor = Color.FromArgb(255, 0, 255);
            btnPreviewMaximize.BackColor = Color.FromArgb(255, 0, 255);
            btnPreviewClose.BackColor = Color.FromArgb(255, 0, 255);
            btnPreviewChooseDataBase.BackColor = Color.FromArgb(255, 0, 255);

            color = "Magenta";

            timerR.Stop();
            timerG.Stop();
            timerB.Stop();
        }

        private void btnMagenta_MouseEnter(object sender, EventArgs e)
        {
            btnMagenta.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            btnMagenta.FlatAppearance.BorderSize = borderSize;
        }

        private void btnMagenta_MouseLeave(object sender, EventArgs e)
        {
            btnMagenta.FlatAppearance.BorderSize = 0;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            pnlPreviewFormBorder.BackColor = Color.FromArgb(65, 205, 82);
            pnlPreviewFormMenu.BackColor = Color.FromArgb(65, 205, 82);

            btnPreviewHide.BackColor = Color.FromArgb(65, 205, 82);
            btnPreviewMaximize.BackColor = Color.FromArgb(65, 205, 82);
            btnPreviewClose.BackColor = Color.FromArgb(65, 205, 82);
            btnPreviewChooseDataBase.BackColor = Color.FromArgb(65, 205, 82);

            color = "Green";

            timerR.Stop();
            timerG.Stop();
            timerB.Stop();
        }

        private void btnGreen_MouseEnter(object sender, EventArgs e)
        {
            btnGreen.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            btnGreen.FlatAppearance.BorderSize = borderSize;
        }

        private void btnGreen_MouseLeave(object sender, EventArgs e)
        {
            btnGreen.FlatAppearance.BorderSize = 0;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            pnlPreviewFormBorder.BackColor = Color.FromArgb(75, 0, 130);
            pnlPreviewFormMenu.BackColor = Color.FromArgb(75, 0, 130);

            btnPreviewHide.BackColor = Color.FromArgb(75, 0, 130);
            btnPreviewMaximize.BackColor = Color.FromArgb(75, 0, 130);
            btnPreviewClose.BackColor = Color.FromArgb(75, 0, 130);
            btnPreviewChooseDataBase.BackColor = Color.FromArgb(75, 0, 130);

            color = "Purple";

            timerR.Stop();
            timerG.Stop();
            timerB.Stop();
        }

        private void btnPurple_MouseEnter(object sender, EventArgs e)
        {
            btnPurple.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            btnPurple.FlatAppearance.BorderSize = borderSize;
        }

        private void btnPurple_MouseLeave(object sender, EventArgs e)
        {
            btnPurple.FlatAppearance.BorderSize = 0;
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            pnlPreviewFormBorder.BackColor = Color.FromArgb(238, 130, 238);
            pnlPreviewFormMenu.BackColor = Color.FromArgb(238, 130, 238);

            btnPreviewHide.BackColor = Color.FromArgb(238, 130, 238);
            btnPreviewMaximize.BackColor = Color.FromArgb(238, 130, 238);
            btnPreviewClose.BackColor = Color.FromArgb(238, 130, 238);
            btnPreviewChooseDataBase.BackColor = Color.FromArgb(238, 130, 238);

            color = "Pink";

            timerR.Stop();
            timerG.Stop();
            timerB.Stop();
        }

        private void btnPink_MouseEnter(object sender, EventArgs e)
        {
            btnPink.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            btnPink.FlatAppearance.BorderSize = borderSize;
        }

        private void btnPink_MouseLeave(object sender, EventArgs e)
        {
            btnPink.FlatAppearance.BorderSize = 0;
        }

        private void btnDarkCyan_Click(object sender, EventArgs e)
        {
            pnlPreviewFormBorder.BackColor = Color.FromArgb(0, 139, 139);
            pnlPreviewFormMenu.BackColor = Color.FromArgb(0, 139, 139);

            btnPreviewHide.BackColor = Color.FromArgb(0, 139, 139);
            btnPreviewMaximize.BackColor = Color.FromArgb(0, 139, 139);
            btnPreviewClose.BackColor = Color.FromArgb(0, 139, 139);
            btnPreviewChooseDataBase.BackColor = Color.FromArgb(0, 139, 139);

            color = "DarkCyan";

            timerR.Stop();
            timerG.Stop();
            timerB.Stop();
        }

        private void btnDarkCyan_MouseEnter(object sender, EventArgs e)
        {
            btnDarkCyan.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            btnDarkCyan.FlatAppearance.BorderSize = borderSize;
        }

        private void btnDarkCyan_MouseLeave(object sender, EventArgs e)
        {
            btnDarkCyan.FlatAppearance.BorderSize = 0;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            pnlPreviewFormBorder.BackColor = Color.FromArgb(165, 42, 42);
            pnlPreviewFormMenu.BackColor = Color.FromArgb(165, 42, 42);

            btnPreviewHide.BackColor = Color.FromArgb(165, 42, 42);
            btnPreviewMaximize.BackColor = Color.FromArgb(165, 42, 42);
            btnPreviewClose.BackColor = Color.FromArgb(165, 42, 42);
            btnPreviewChooseDataBase.BackColor = Color.FromArgb(165, 42, 42);

            color = "Red";

            timerR.Stop();
            timerG.Stop();
            timerB.Stop();
        }

        private void btnRed_MouseEnter(object sender, EventArgs e)
        {
            btnRed.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            btnRed.FlatAppearance.BorderSize = borderSize;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            pnlPreviewFormBorder.BackColor = Color.FromArgb(0, 0, 0);
            pnlPreviewFormMenu.BackColor = Color.FromArgb(0, 0, 0);

            btnPreviewHide.BackColor = Color.FromArgb(0, 0, 0);
            btnPreviewMaximize.BackColor = Color.FromArgb(0, 0, 0);
            btnPreviewClose.BackColor = Color.FromArgb(0, 0, 0);
            btnPreviewChooseDataBase.BackColor = Color.FromArgb(0, 0, 0);

            color = "Black";

            timerR.Stop();
            timerG.Stop();
            timerB.Stop();
        }

        private void btnRed_MouseLeave(object sender, EventArgs e)
        {
            btnRed.FlatAppearance.BorderSize = 0;
        }

        private void btnBlack_MouseEnter(object sender, EventArgs e)
        {
            btnBlack.FlatAppearance.BorderColor = Color.FromArgb(240, 240, 240);
            btnBlack.FlatAppearance.BorderSize = borderSize;
        }

        private void btnBlack_MouseLeave(object sender, EventArgs e)
        {
            btnBlack.FlatAppearance.BorderSize = 0;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Зміни увійдуть в силу після перезагрузки.", "Налаштування", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (File.Exists(frmMain.settingsFilePath)) {

                File.Delete(frmMain.settingsFilePath);

                using (TextWriter tw = new StreamWriter(new FileStream(frmMain.settingsFilePath, FileMode.Create))) {
                    tw.WriteLine("[ColorScheme]");
                    tw.WriteLine("PrimaryColor=" + color);
                    tw.Close();
                }
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSettings_ClientSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void timerR_Tick(object sender, EventArgs e)
        {
            if (b >= 244) {
                r -= 10;

                btnClose.BackColor = Color.FromArgb(r, g, b);

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnApply.BackColor = Color.FromArgb(r, g, b);

                btnPreviewHide.BackColor = Color.FromArgb(r, g, b);
                btnPreviewMaximize.BackColor = Color.FromArgb(r, g, b);
                btnPreviewClose.BackColor = Color.FromArgb(r, g, b);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(r, g, b);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(r, g, b);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(r, g, b);

                if (r <= 65) {
                    timerR.Stop();
                    timerG.Start();
                }
            }

            if (b <= 65) {
                r += 10;

                btnClose.BackColor = Color.FromArgb(r, g, b);

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnApply.BackColor = Color.FromArgb(r, g, b);

                btnPreviewHide.BackColor = Color.FromArgb(r, g, b);
                btnPreviewMaximize.BackColor = Color.FromArgb(r, g, b);
                btnPreviewClose.BackColor = Color.FromArgb(r, g, b);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(r, g, b);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(r, g, b);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(r, g, b);

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

                btnClose.BackColor = Color.FromArgb(r, g, b);

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnApply.BackColor = Color.FromArgb(r, g, b);

                btnPreviewHide.BackColor = Color.FromArgb(r, g, b);
                btnPreviewMaximize.BackColor = Color.FromArgb(r, g, b);
                btnPreviewClose.BackColor = Color.FromArgb(r, g, b);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(r, g, b);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(r, g, b);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(r, g, b);

                if (g >= 244) {
                    timerG.Stop();
                    timerB.Start();
                }
            }

            if (r >= 244) {
                g -= 10;

                btnClose.BackColor = Color.FromArgb(r, g, b);

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnApply.BackColor = Color.FromArgb(r, g, b);

                btnPreviewHide.BackColor = Color.FromArgb(r, g, b);
                btnPreviewMaximize.BackColor = Color.FromArgb(r, g, b);
                btnPreviewClose.BackColor = Color.FromArgb(r, g, b);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(r, g, b);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(r, g, b);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(r, g, b);

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

                btnClose.BackColor = Color.FromArgb(r, g, b);

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnApply.BackColor = Color.FromArgb(r, g, b);

                btnPreviewHide.BackColor = Color.FromArgb(r, g, b);
                btnPreviewMaximize.BackColor = Color.FromArgb(r, g, b);
                btnPreviewClose.BackColor = Color.FromArgb(r, g, b);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(r, g, b);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(r, g, b);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(r, g, b);

                if (b >= 244) {
                    timerB.Stop();
                    timerR.Start();
                }
            }

            if (g >= 244) {
                b -= 10;

                btnClose.BackColor = Color.FromArgb(r, g, b);

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnApply.BackColor = Color.FromArgb(r, g, b);

                btnPreviewHide.BackColor = Color.FromArgb(r, g, b);
                btnPreviewMaximize.BackColor = Color.FromArgb(r, g, b);
                btnPreviewClose.BackColor = Color.FromArgb(r, g, b);

                btnPreviewChooseDataBase.BackColor = Color.FromArgb(r, g, b);

                pnlPreviewFormBorder.BackColor = Color.FromArgb(r, g, b);
                pnlPreviewFormMenu.BackColor = Color.FromArgb(r, g, b);

                if (b <= 65) {
                    timerB.Stop();
                    timerR.Start();
                }
            }
        }
    }
}