using System;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventoryViewer
{
    public partial class frmEdit : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + frmMain.DBPath);
        OleDbCommand cmd;
        Point moveStart;

        int i = Convert.ToInt32(frmMain.selectedCount), totalPrice, r = 244, g = 65, b = 65;
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

        public frmEdit()
        {
            InitializeComponent();

            m_aeroEnabled = false;

            this.Size = new Size(404, 274);

            lbltitle.Text = "Редагування: " + frmMain.selectedName + ", №" + frmMain.selectedSerialNum;

            pctBoxAppImg.Image = Properties.Resources.inventory;

            txtItemCount.Text = frmMain.selectedCount;

            pnlFormBorder.Select();

            if (frmMain.selectedType == "Пожежна безпека") {
                chkExtinguisher.Checked = true;

                txtEquipDate.Enabled = false;
                txtEquipDate.Text = frmMain.selectedEquipedDate;

                txtExpiresDate.Enabled = false;
                txtExpiresDate.Text = frmMain.selectedExpiresDate;
            } else {
                chkExtinguisher.Checked = false;

                lblstartdate_expiresdate.Visible = false;

                txtEquipDate.Visible = false;
                txtExpiresDate.Visible = false;
            }

            txtItemName.Text = frmMain.selectedName;
            txtItemSerialNum.Text = frmMain.selectedSerialNum;
            txtItemPrice.Text = frmMain.selectedPrice;
            txtItemCount.Text = frmMain.selectedCount;
            txtItemType.Text = frmMain.selectedType;
            txtItemExists.Text = frmMain.selectedExists;

            if (File.Exists(frmMain.settingsFilePath)) {
                using (StreamReader sr = new StreamReader(frmMain.settingsFilePath)) {
                    EmptyLine = sr.ReadLine();
                    color = sr.ReadLine();
                }
            }

            if (color == "PrimaryColor=Default") {
                pnlFormBorder.BackColor = Color.FromArgb(0, 120, 215);

                btnClose.BackColor = Color.FromArgb(0, 120, 215);

                btnPlusOne.BackColor = Color.FromArgb(0, 120, 215);
                btnMinusOne.BackColor = Color.FromArgb(0, 120, 215);

                btnUpdate.BackColor = Color.FromArgb(0, 120, 215);
            }
            else if (color == "PrimaryColor=Orange") {
                pnlFormBorder.BackColor = Color.FromArgb(255, 165, 0);

                btnClose.BackColor = Color.FromArgb(255, 165, 0);

                btnPlusOne.BackColor = Color.FromArgb(255, 165, 0);
                btnMinusOne.BackColor = Color.FromArgb(255, 165, 0);

                btnUpdate.BackColor = Color.FromArgb(255, 165, 0);
            }
            else if (color == "PrimaryColor=Magenta") {
                pnlFormBorder.BackColor = Color.FromArgb(255, 0, 255);

                btnClose.BackColor = Color.FromArgb(255, 0, 255);

                btnPlusOne.BackColor = Color.FromArgb(255, 0, 255);
                btnMinusOne.BackColor = Color.FromArgb(255, 0, 255);

                btnUpdate.BackColor = Color.FromArgb(255, 0, 255);
            }
            else if (color == "PrimaryColor=Green") {
                pnlFormBorder.BackColor = Color.FromArgb(65, 205, 82);

                btnClose.BackColor = Color.FromArgb(65, 205, 82);

                btnPlusOne.BackColor = Color.FromArgb(65, 205, 82);
                btnMinusOne.BackColor = Color.FromArgb(65, 205, 82);

                btnUpdate.BackColor = Color.FromArgb(65, 205, 82);
            }
            else if (color == "PrimaryColor=Purple") {
                pnlFormBorder.BackColor = Color.FromArgb(75, 0, 130);

                btnClose.BackColor = Color.FromArgb(75, 0, 130);

                btnPlusOne.BackColor = Color.FromArgb(75, 0, 130);
                btnMinusOne.BackColor = Color.FromArgb(75, 0, 130);

                btnUpdate.BackColor = Color.FromArgb(75, 0, 130);
            }
            else if (color == "PrimaryColor=Pink") {
                pnlFormBorder.BackColor = Color.FromArgb(238, 130, 238);

                btnClose.BackColor = Color.FromArgb(238, 130, 238);

                btnPlusOne.BackColor = Color.FromArgb(238, 130, 238);
                btnMinusOne.BackColor = Color.FromArgb(238, 130, 238);

                btnUpdate.BackColor = Color.FromArgb(238, 130, 238);
            }
            else if (color == "PrimaryColor=DarkCyan") {
                pnlFormBorder.BackColor = Color.FromArgb(0, 139, 139);

                btnClose.BackColor = Color.FromArgb(0, 139, 139);

                btnPlusOne.BackColor = Color.FromArgb(0, 139, 139);
                btnMinusOne.BackColor = Color.FromArgb(0, 139, 139);

                btnUpdate.BackColor = Color.FromArgb(0, 139, 139);
            }
            else if (color == "PrimaryColor=Red") {
                pnlFormBorder.BackColor = Color.FromArgb(165, 42, 42);

                btnClose.BackColor = Color.FromArgb(165, 42, 42);

                btnPlusOne.BackColor = Color.FromArgb(165, 42, 42);
                btnMinusOne.BackColor = Color.FromArgb(165, 42, 42);

                btnUpdate.BackColor = Color.FromArgb(165, 42, 42);
            }
            else if (color == "PrimaryColor=Black") {
                pnlFormBorder.BackColor = Color.FromArgb(0, 0, 0);

                btnClose.BackColor = Color.FromArgb(0, 0, 0);

                btnPlusOne.BackColor = Color.FromArgb(0, 0, 0);
                btnMinusOne.BackColor = Color.FromArgb(0, 0, 0);

                btnUpdate.BackColor = Color.FromArgb(0, 0, 0);
            }
            else if (color == "PrimaryColor=Fade") {
                timerR.Start();
                timerG.Start();
                timerB.Start();
            }
            else {
                pnlFormBorder.BackColor = Color.FromArgb(0, 120, 215);

                btnClose.BackColor = Color.FromArgb(0, 120, 215);

                btnPlusOne.BackColor = Color.FromArgb(0, 120, 215);
                btnMinusOne.BackColor = Color.FromArgb(0, 120, 215);

                btnUpdate.BackColor = Color.FromArgb(0, 120, 215);
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

        private void btnPlusOne_Click(object sender, EventArgs e)
        {
            i++;

            txtItemCount.Text = i.ToString();

            txtItemExists.Text = "Так";
        }

        private void btnMinusOne_Click(object sender, EventArgs e)
        {
            if (i == 0) {
                txtItemCount.Text = "0";

                i = 0;
            }
            else {
                i--;

                txtItemCount.Text = i.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtItemSerialNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtItemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtItemExists_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtItemPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemPrice.Text)) {
                lblItemTotalPrice.Text = "Поточна сума: " + Convert.ToInt32(txtItemCount.Text) * Convert.ToInt32(txtItemPrice.Text) + "$";

                totalPrice = Convert.ToInt32(txtItemCount.Text) * Convert.ToInt32(txtItemPrice.Text);
            } else {
                lblItemTotalPrice.Text = "Поточна сума: -";
            }
        }

        private void txtItemCount_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtItemPrice.Text) && i != 0) {
                lblItemTotalPrice.Text = "Поточна сума: " + Convert.ToDouble(txtItemCount.Text) * Convert.ToDouble(txtItemPrice.Text) + "$";

                txtItemExists.Text = "Так";

                totalPrice = Convert.ToInt32(txtItemCount.Text) * Convert.ToInt32(txtItemPrice.Text);
            } else if (i == 0) {
                txtItemExists.Text = "Ні";

                totalPrice = 0;

                lblItemTotalPrice.Text = "Поточна сума: -";
            }
        }

        private void chkExtinguisher_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtinguisher.Checked == true) {
                this.Size = new Size(404, 358);

                txtItemType.Text = "Пожежна безпека";
                txtItemType.Enabled = false;

                lblstartdate_expiresdate.Visible = true;

                chkExtinguisher.Enabled = false;

                txtEquipDate.Visible = true;
                txtExpiresDate.Visible = true;

                txtEquipDate.Enabled = false;
                txtEquipDate.Text = Convert.ToString(DateTime.Now);

                txtExpiresDate.Enabled = false;
                txtExpiresDate.Text = Convert.ToString(DateTime.Now.AddYears(10));
            } else if (chkExtinguisher.Checked == false) {
                this.Size = new Size(404, 274);

                txtItemType.Text = "";
                txtItemType.Enabled = true;

                lblstartdate_expiresdate.Visible = false;

                chkExtinguisher.Visible = false;

                txtEquipDate.Visible = false;
                txtExpiresDate.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {    
            if (!string.IsNullOrEmpty(txtItemName.Text)) {
                if (!string.IsNullOrEmpty(txtItemSerialNum.Text) && txtItemSerialNum.TextLength == 8) {
                    if (!string.IsNullOrEmpty(txtItemPrice.Text)) {
                        if (!string.IsNullOrEmpty(txtItemType.Text)) {
                            if (!string.IsNullOrEmpty(txtItemExists.Text)) {
                                if (chkExtinguisher.Checked == false) {
                                    try {
                                        conn.Open();

                                        cmd = new OleDbCommand("UPDATE Items SET Item_Name = '" + txtItemName.Text + 
                                            "', Item_SerialNum = '" + txtItemSerialNum.Text + 
                                            "', Item_Price = '" + txtItemPrice.Text + 
                                            "', Item_TotalPrice = '" + totalPrice + 
                                            "', Item_Exists = '" + txtItemExists.Text + 
                                            "', Item_Count = '" + txtItemCount.Text + 
                                            "', Item_Type = '" + txtItemType.Text + 
                                            "', Item_EquipDate = '" + null + 
                                            "', Item_ExpiresDate = '" + null + 
                                            "' WHERE Item_SerialNum = '" + frmMain.selectedSerialNum + "'", conn);

                                        cmd.ExecuteNonQuery();

                                        conn.Close();

                                        this.Close();
                                    } catch (Exception) {
                                        MessageBox.Show("Сталася помилка при обробці даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                } else {
                                    try {
                                        conn.Open();

                                        cmd = new OleDbCommand("UPDATE Items SET Item_Name = '" + txtItemName.Text + 
                                            "', Item_SerialNum = '" + txtItemSerialNum.Text + 
                                            "', Item_Price = '" + txtItemPrice.Text + 
                                            "', Item_TotalPrice = '" + totalPrice + 
                                            "', Item_Exists = '" + txtItemExists.Text + 
                                            "', Item_Count = '" + txtItemCount.Text + 
                                            "', Item_Type = '" + txtItemType.Text + 
                                            "', Item_EquipDate = '" + frmMain.selectedEquipedDate + 
                                            "', Item_ExpiresDate = '" + frmMain.selectedExpiresDate + 
                                            "' WHERE Item_SerialNum = '" + frmMain.selectedSerialNum + "'", conn);

                                        cmd.ExecuteNonQuery();

                                        conn.Close();

                                        this.Close();
                                    } catch (Exception) {
                                        MessageBox.Show("Сталася помилка при обробці даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            } else {
                                MessageBox.Show("Будь ласка вкажіть наявність предмету.", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                txtItemExists.Focus();
                            }
                        } else {
                            MessageBox.Show("Будь ласка вкажіть тип предмата.", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            txtItemType.Focus();
                        }
                    } else {
                        MessageBox.Show("Будь ласка вкажіть початкову ціну предмета.", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtItemPrice.Focus();
                    }
                } else {
                    MessageBox.Show("Будь ласка вкажіть код предмета. Чи перевірте правильність вводу.\n\n*Має будти не менш 8 цифр.", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtItemSerialNum.Focus();
                }
            } else {
                MessageBox.Show("Будь ласка вкажіть назву предмета.", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtItemName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEdit_ClientSizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void timerR_Tick(object sender, EventArgs e)
        {
            if (b >= 244) {
                r -= 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnPlusOne.BackColor = Color.FromArgb(r, g, b);
                btnMinusOne.BackColor = Color.FromArgb(r, g, b);

                btnUpdate.BackColor = Color.FromArgb(r, g, b);

                if (r <= 65) {
                    timerR.Stop();
                    timerG.Start();
                }
            }

            if (b <= 65) {
                r += 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnPlusOne.BackColor = Color.FromArgb(r, g, b);
                btnMinusOne.BackColor = Color.FromArgb(r, g, b);

                btnUpdate.BackColor = Color.FromArgb(r, g, b);

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

                btnPlusOne.BackColor = Color.FromArgb(r, g, b);
                btnMinusOne.BackColor = Color.FromArgb(r, g, b);

                btnUpdate.BackColor = Color.FromArgb(r, g, b);

                if (g >= 244) {
                    timerG.Stop();
                    timerB.Start();
                }
            }

            if (r >= 244) {
                g -= 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnPlusOne.BackColor = Color.FromArgb(r, g, b);
                btnMinusOne.BackColor = Color.FromArgb(r, g, b);

                btnUpdate.BackColor = Color.FromArgb(r, g, b);

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

                btnPlusOne.BackColor = Color.FromArgb(r, g, b);
                btnMinusOne.BackColor = Color.FromArgb(r, g, b);

                btnUpdate.BackColor = Color.FromArgb(r, g, b);

                if (b >= 244) {
                    timerB.Stop();
                    timerR.Start();
                }
            }

            if (g >= 244) {
                b -= 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnPlusOne.BackColor = Color.FromArgb(r, g, b);
                btnMinusOne.BackColor = Color.FromArgb(r, g, b);

                btnUpdate.BackColor = Color.FromArgb(r, g, b);

                if (b <= 65) {
                    timerB.Stop();
                    timerR.Start();
                }
            }
        }
    }
}