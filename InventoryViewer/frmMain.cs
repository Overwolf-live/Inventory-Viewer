using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace InventoryViewer
{
    public partial class frmMain : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter oda;
        OleDbCommand cmd;
        DataTable dt;
        Point moveStart;

        public static string DBPath, selectedNum, selectedName, selectedSerialNum, selectedPrice, selectedTotalPrice, selectedExists, selectedCount, selectedType, selectedEquipedDate, selectedExpiresDate, settingsFilePath, logFilePath, serialNum;

        string color, EmptyLine;
        int r = 244, g = 65, b = 65;

        public frmMain()
        {
            InitializeComponent();

            settingsFilePath = Application.StartupPath + "\\settings.ini";
            logFilePath = Application.StartupPath + "\\log.dat";

            Lock();

            this.Text = "Огляд інвентаря";

            lbltitle.Text = "Огляд інвентаря";

            pctBoxAppImg.Image = Properties.Resources.inventory;

            btnMinimize.Visible = true;
            btnMaximize.Visible = false;

            columnItemType.Width = 145;

            listItems.HideSelection = true;

            if (!File.Exists(settingsFilePath)) {
                using (TextWriter tw = new StreamWriter(new FileStream(settingsFilePath, FileMode.Create))) {
                    tw.WriteLine("[ColorScheme]");
                    tw.WriteLine("PrimaryColor=Default");
                    tw.Close();
                }
            } else if (File.Exists(settingsFilePath)) {
                using (StreamReader sr = new StreamReader(settingsFilePath)) {
                    EmptyLine = sr.ReadLine();
                    color = sr.ReadLine();
                }
            }

            if (color == "PrimaryColor=Default") {
                btnHide.BackColor = Color.FromArgb(0, 120, 215);
                btnMaximize.BackColor = Color.FromArgb(0, 120, 215);
                btnMinimize.BackColor = Color.FromArgb(0, 120, 215);
                btnClose.BackColor = Color.FromArgb(0, 120, 215);

                btnChooseDataBase.BackColor = Color.FromArgb(0, 120, 215);

                lnkTutorial.LinkColor = Color.FromArgb(0, 120, 215);

                pnlFormBorder.BackColor = Color.FromArgb(0, 120, 215);
                pnlFormMenu.BackColor = Color.FromArgb(0, 120, 215);

                btnAdd.BackColor = Color.FromArgb(0, 120, 215);
                btnEdit.BackColor = Color.FromArgb(0, 120, 215);
                btnDelete.BackColor = Color.FromArgb(0, 120, 215);
                btnSave.BackColor = Color.FromArgb(20, 120, 215);
                btnRefresh.BackColor = Color.FromArgb(0, 120, 215);

                btnSightOut.BackColor = Color.FromArgb(0, 120, 215);
                btnSettings.BackColor = Color.FromArgb(0, 120, 215);
            }
            else if (color == "PrimaryColor=Orange") {               
                btnHide.BackColor = Color.FromArgb(255, 165, 0);
                btnMaximize.BackColor = Color.FromArgb(255, 165, 0);
                btnMinimize.BackColor = Color.FromArgb(255, 165, 0);
                btnClose.BackColor = Color.FromArgb(255, 165, 0);

                btnChooseDataBase.BackColor = Color.FromArgb(255, 165, 0);

                lnkTutorial.LinkColor = Color.FromArgb(255, 165, 0);

                pnlFormBorder.BackColor = Color.FromArgb(255, 165, 0);
                pnlFormMenu.BackColor = Color.FromArgb(255, 165, 0);

                btnAdd.BackColor = Color.FromArgb(255, 165, 0);
                btnEdit.BackColor = Color.FromArgb(255, 165, 0);
                btnDelete.BackColor = Color.FromArgb(255, 165, 0);
                btnSave.BackColor = Color.FromArgb(255, 165, 0);
                btnRefresh.BackColor = Color.FromArgb(255, 165, 0);

                btnSightOut.BackColor = Color.FromArgb(255, 165, 0);
                btnSettings.BackColor = Color.FromArgb(255, 165, 0);
            }
            else if (color == "PrimaryColor=Magenta") {
                btnHide.BackColor = Color.FromArgb(255, 0, 255);
                btnMaximize.BackColor = Color.FromArgb(255, 0, 255);
                btnMinimize.BackColor = Color.FromArgb(255, 0, 255);
                btnClose.BackColor = Color.FromArgb(255, 0, 255);

                btnChooseDataBase.BackColor = Color.FromArgb(255, 0, 255);

                lnkTutorial.LinkColor = Color.FromArgb(255, 0, 255);

                pnlFormBorder.BackColor = Color.FromArgb(255, 0, 255);
                pnlFormMenu.BackColor = Color.FromArgb(255, 0, 255);

                btnAdd.BackColor = Color.FromArgb(255, 0, 255);
                btnEdit.BackColor = Color.FromArgb(255, 0, 255);
                btnDelete.BackColor = Color.FromArgb(255, 0, 255);
                btnSave.BackColor = Color.FromArgb(255, 0, 255);
                btnRefresh.BackColor = Color.FromArgb(255, 0, 255);

                btnSightOut.BackColor = Color.FromArgb(255, 0, 255);
                btnSettings.BackColor = Color.FromArgb(255, 0, 255);
            }
            else if (color == "PrimaryColor=Green") {
                btnHide.BackColor = Color.FromArgb(65, 205, 82);
                btnMaximize.BackColor = Color.FromArgb(65, 205, 82);
                btnMinimize.BackColor = Color.FromArgb(65, 205, 82);
                btnClose.BackColor = Color.FromArgb(65, 205, 82);

                btnChooseDataBase.BackColor = Color.FromArgb(65, 205, 82);

                lnkTutorial.LinkColor = Color.FromArgb(65, 205, 82);

                pnlFormBorder.BackColor = Color.FromArgb(65, 205, 82);
                pnlFormMenu.BackColor = Color.FromArgb(65, 205, 82);

                btnAdd.BackColor = Color.FromArgb(65, 205, 82);
                btnEdit.BackColor = Color.FromArgb(65, 205, 82);
                btnDelete.BackColor = Color.FromArgb(65, 205, 82);
                btnSave.BackColor = Color.FromArgb(65, 205, 82);
                btnRefresh.BackColor = Color.FromArgb(65, 205, 82);

                btnSightOut.BackColor = Color.FromArgb(65, 205, 82);
                btnSettings.BackColor = Color.FromArgb(65, 205, 82);
            }
            else if (color == "PrimaryColor=Purple") {
                btnHide.BackColor = Color.FromArgb(75, 0, 130);
                btnMaximize.BackColor = Color.FromArgb(75, 0, 130);
                btnMinimize.BackColor = Color.FromArgb(75, 0, 130);
                btnClose.BackColor = Color.FromArgb(75, 0, 130);

                btnChooseDataBase.BackColor = Color.FromArgb(75, 0, 130);

                lnkTutorial.LinkColor = Color.FromArgb(75, 0, 130);

                pnlFormBorder.BackColor = Color.FromArgb(75, 0, 130);
                pnlFormMenu.BackColor = Color.FromArgb(75, 0, 130);

                btnAdd.BackColor = Color.FromArgb(75, 0, 130);
                btnEdit.BackColor = Color.FromArgb(75, 0, 130);
                btnDelete.BackColor = Color.FromArgb(75, 0, 130);
                btnSave.BackColor = Color.FromArgb(75, 0, 130);
                btnRefresh.BackColor = Color.FromArgb(75, 0, 130);

                btnSightOut.BackColor = Color.FromArgb(75, 0, 130);
                btnSettings.BackColor = Color.FromArgb(75, 0, 130);
            }
            else if (color == "PrimaryColor=Pink") {
                btnHide.BackColor = Color.FromArgb(238, 130, 238);
                btnMaximize.BackColor = Color.FromArgb(238, 130, 238);
                btnMinimize.BackColor = Color.FromArgb(238, 130, 238);
                btnClose.BackColor = Color.FromArgb(238, 130, 238);

                btnChooseDataBase.BackColor = Color.FromArgb(238, 130, 238);

                lnkTutorial.LinkColor = Color.FromArgb(238, 130, 238);

                pnlFormBorder.BackColor = Color.FromArgb(238, 130, 238);
                pnlFormMenu.BackColor = Color.FromArgb(238, 130, 238);

                btnAdd.BackColor = Color.FromArgb(238, 130, 238);
                btnEdit.BackColor = Color.FromArgb(238, 130, 238);
                btnDelete.BackColor = Color.FromArgb(238, 130, 238);
                btnSave.BackColor = Color.FromArgb(238, 130, 238);
                btnRefresh.BackColor = Color.FromArgb(238, 130, 238);

                btnSightOut.BackColor = Color.FromArgb(238, 130, 238);
                btnSettings.BackColor = Color.FromArgb(238, 130, 238);
            }
            else if (color == "PrimaryColor=DarkCyan") {
                btnHide.BackColor = Color.FromArgb(0, 139, 139);
                btnMaximize.BackColor = Color.FromArgb(0, 139, 139);
                btnMinimize.BackColor = Color.FromArgb(0, 139, 139);
                btnClose.BackColor = Color.FromArgb(0, 139, 139);

                btnChooseDataBase.BackColor = Color.FromArgb(0, 139, 139);

                lnkTutorial.LinkColor = Color.FromArgb(0, 139, 139);

                pnlFormBorder.BackColor = Color.FromArgb(0, 139, 139);
                pnlFormMenu.BackColor = Color.FromArgb(0, 139, 139);

                btnAdd.BackColor = Color.FromArgb(0, 139, 139);
                btnEdit.BackColor = Color.FromArgb(0, 139, 139);
                btnDelete.BackColor = Color.FromArgb(0, 139, 139);
                btnSave.BackColor = Color.FromArgb(0, 139, 139);
                btnRefresh.BackColor = Color.FromArgb(0, 139, 139);

                btnSightOut.BackColor = Color.FromArgb(0, 139, 139);
                btnSettings.BackColor = Color.FromArgb(0, 139, 139);
            }
            else if (color == "PrimaryColor=Red") {
                btnHide.BackColor = Color.FromArgb(165, 42, 42);
                btnMaximize.BackColor = Color.FromArgb(165, 42, 42);
                btnMinimize.BackColor = Color.FromArgb(165, 42, 42);
                btnClose.BackColor = Color.FromArgb(165, 42, 42);

                btnChooseDataBase.BackColor = Color.FromArgb(165, 42, 42);

                lnkTutorial.LinkColor = Color.FromArgb(165, 42, 42);

                pnlFormBorder.BackColor = Color.FromArgb(165, 42, 42);
                pnlFormMenu.BackColor = Color.FromArgb(165, 42, 42);

                btnAdd.BackColor = Color.FromArgb(165, 42, 42);
                btnEdit.BackColor = Color.FromArgb(165, 42, 42);
                btnDelete.BackColor = Color.FromArgb(165, 42, 42);
                btnSave.BackColor = Color.FromArgb(165, 42, 42);
                btnRefresh.BackColor = Color.FromArgb(165, 42, 42);

                btnSightOut.BackColor = Color.FromArgb(165, 42, 42);
                btnSettings.BackColor = Color.FromArgb(165, 42, 42);
            }
            else if (color == "PrimaryColor=Black") {
                btnHide.BackColor = Color.FromArgb(0, 0, 0);
                btnMaximize.BackColor = Color.FromArgb(0, 0, 0);
                btnMinimize.BackColor = Color.FromArgb(0, 0, 0);
                btnClose.BackColor = Color.FromArgb(0, 0, 0);

                btnChooseDataBase.BackColor = Color.FromArgb(0, 0, 0);

                pnlFormBorder.BackColor = Color.FromArgb(0, 0, 0);
                pnlFormMenu.BackColor = Color.FromArgb(0, 0, 0);

                btnAdd.BackColor = Color.FromArgb(0, 0, 0);
                btnEdit.BackColor = Color.FromArgb(0, 0, 0);
                btnDelete.BackColor = Color.FromArgb(0, 0, 0);
                btnSave.BackColor = Color.FromArgb(0, 0, 0);
                btnRefresh.BackColor = Color.FromArgb(0, 0, 0);

                btnSightOut.BackColor = Color.FromArgb(0, 0, 0);
                btnSettings.BackColor = Color.FromArgb(0, 0, 0);
            }
            else if (color == "PrimaryColor=Fade") {
                timerR.Start();
                timerG.Start();
                timerB.Start();
            }
            else {
                btnHide.BackColor = Color.FromArgb(0, 120, 215);
                btnMaximize.BackColor = Color.FromArgb(0, 120, 215);
                btnMinimize.BackColor = Color.FromArgb(0, 120, 215);
                btnClose.BackColor = Color.FromArgb(0, 120, 215);

                btnChooseDataBase.BackColor = Color.FromArgb(0, 120, 215);

                lnkTutorial.LinkColor = Color.FromArgb(0, 120, 215);

                pnlFormBorder.BackColor = Color.FromArgb(0, 120, 215);
                pnlFormMenu.BackColor = Color.FromArgb(0, 120, 215);

                btnAdd.BackColor = Color.FromArgb(0, 120, 215);
                btnEdit.BackColor = Color.FromArgb(0, 120, 215);
                btnDelete.BackColor = Color.FromArgb(0, 120, 215);
                btnSave.BackColor = Color.FromArgb(20, 120, 215);
                btnRefresh.BackColor = Color.FromArgb(0, 120, 215);

                btnSightOut.BackColor = Color.FromArgb(0, 120, 215);
                btnSettings.BackColor = Color.FromArgb(0, 120, 215);
            }
        }

        private void pnlFormBorder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listItems.Select();

            if (WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;

                btnMaximize.Visible = true;
                btnMinimize.Visible = false;

                columnItemType.Width = 364;
            } else if (WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;

                btnMaximize.Visible = false;
                btnMinimize.Visible = true;

                columnItemType.Width = 145;
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

        private void lbltitle_DoubleClick(object sender, EventArgs e)
        {
            listItems.Select();

            if (WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;

                btnMaximize.Visible = true;
                btnMinimize.Visible = false;

                columnItemType.Width = 364;
            } else if (WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;

                btnMaximize.Visible = false;
                btnMinimize.Visible = true;

                columnItemType.Width = 145;
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            listItems.Select();

            if (WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;

                btnMinimize.Visible = false;
                btnMaximize.Visible = true;

                columnItemType.Width = 364;
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            listItems.Select();

            if (WindowState == FormWindowState.Maximized) {
                this.WindowState = FormWindowState.Normal;

                btnMinimize.Visible = true;
                btnMaximize.Visible = false;

                columnItemType.Width = 145;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!File.Exists(logFilePath)) {
                using (TextWriter tw = new StreamWriter(new FileStream(logFilePath, FileMode.Create))) {
                    tw.WriteLine("Запис [" + DateTime.Now.ToLongTimeString() + ", " + DateTime.Now.ToLongDateString() + "]");
                    tw.WriteLine("\n[" + DateTime.Now.ToLongTimeString() + "] - система була закрита");
                    tw.Close();
                }
            } else if (File.Exists(logFilePath)) {

                File.Delete(logFilePath);

                using (TextWriter tw = new StreamWriter(new FileStream(logFilePath, FileMode.Create))) {
                    tw.WriteLine("Запис [" + DateTime.Now.ToLongTimeString() + ", " + DateTime.Now.ToLongDateString() + "]");
                    tw.WriteLine("\n[" + DateTime.Now.ToLongTimeString() + "] - система була закрита");
                    tw.Close();
                }
            }
            this.Dispose();
        }

        private void txtItemName_Click(object sender, EventArgs e)
        {
            LoadData();

            txtItemName.Text = "";
            txtItemSerialNum.Text = "";
            txtItemExists.Text = "";
            txtItemType.Text = "";
        }

        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtItemName.Text)) {
                try {
                    oda = new OleDbDataAdapter("SELECT * FROM Items WHERE Item_Name = '" + txtItemName.Text + "'", conn);

                    FillSearchResult();
                } catch (Exception) {
                    LoadData();
                }
            } else {
                LoadData();
            }
        }

        private void txtItemSerialNum_Click(object sender, EventArgs e)
        {
            LoadData();

            txtItemName.Text = "";
            txtItemSerialNum.Text = "";
            txtItemExists.Text = "";
            txtItemType.Text = "";
        }

        private void txtItemSerialNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtItemSerialNum.Text)) {
                try {
                    oda = new OleDbDataAdapter("SELECT * FROM Items WHERE Item_SerialNum = '" + txtItemSerialNum.Text + "'", conn);

                    FillSearchResult();
                } catch (Exception) {
                    LoadData();
                }
            } else {
                LoadData();
            }
        }

        private void txtItemSerialNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtItemExists_Click(object sender, EventArgs e)
        {
            LoadData();

            txtItemName.Text = "";
            txtItemSerialNum.Text = "";
            txtItemExists.Text = "";
            txtItemType.Text = "";
        }

        private void txtItemExists_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtItemExists.Text)) {
                try {
                    oda = new OleDbDataAdapter("SELECT * FROM Items WHERE Item_Exists = '" + txtItemExists.Text + "'", conn);

                    FillSearchResult();
                } catch (Exception) {
                    LoadData();
                }
            } else {
                LoadData();
            }
        }

        private void txtItemExists_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtItemType_Click(object sender, EventArgs e)
        {
            LoadData();

            txtItemName.Text = "";
            txtItemSerialNum.Text = "";
            txtItemExists.Text = "";
            txtItemType.Text = "";
        }

        private void txtItemType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtItemType.Text)) {
                try {
                    oda = new OleDbDataAdapter("SELECT * FROM Items WHERE Item_Type = '" + txtItemType.Text + "'", conn);

                    FillSearchResult();
                } catch (Exception) {
                    LoadData();
                }
            } else {
                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new frmAdd()).ShowDialog();

            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedNum != null && selectedName != null) {
                (new frmEdit()).ShowDialog();

                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedNum != null) {
                var answer = MessageBox.Show("Ви дійсно бажаєте видалити '" + selectedName + "'?", "Предмет №" + selectedSerialNum, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes) {
                    Delete();

                    LoadData();
                } else {
                    LoadData();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listItems.Items.Count != 0) {
                Save();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();

            txtItemName.Text = "";
            txtItemSerialNum.Text = "";
            txtItemExists.Text = "";
            txtItemType.Text = "";
        }

        private void lnkTutorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new frmTutarial()).ShowDialog();
        }

        private void btnSightOut_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Ви дійсно бажаєте завершити роботу?", "Завершення роботи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes) {
                Lock();

                selectedNum = null;
                selectedName = null;
                selectedSerialNum = null;

                if (!File.Exists(logFilePath)) {
                    using (TextWriter tw = new StreamWriter(new FileStream(logFilePath, FileMode.Create))) {
                        tw.WriteLine("Запис [" + DateTime.Now.ToLongTimeString() + ", " + DateTime.Now.ToLongDateString() + "]");
                        tw.WriteLine("\n[" + DateTime.Now.ToLongTimeString() + "] - система була закрита");
                        tw.Close();
                    }
                } else if (File.Exists(logFilePath)) {

                    File.Delete(logFilePath);

                    using (TextWriter tw = new StreamWriter(new FileStream(logFilePath, FileMode.Create))) {
                        tw.WriteLine("Запис [" + DateTime.Now.ToLongTimeString() + ", " + DateTime.Now.ToLongDateString() + "]");
                        tw.WriteLine("\n[" + DateTime.Now.ToLongTimeString() + "] - система була закрита");
                        tw.Close();
                    }
                }
            } else {
                UnLock();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            (new frmSettings()).ShowDialog();
        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listItems.SelectedItems.Count != 0) {
                selectedNum = listItems.SelectedItems[0].SubItems[0].Text;
                selectedName = listItems.SelectedItems[0].SubItems[1].Text;
                selectedSerialNum = listItems.SelectedItems[0].SubItems[2].Text;
                selectedPrice = listItems.SelectedItems[0].SubItems[3].Text;
                selectedTotalPrice = listItems.SelectedItems[0].SubItems[4].Text;
                selectedExists = listItems.SelectedItems[0].SubItems[5].Text;
                selectedCount = listItems.SelectedItems[0].SubItems[6].Text;
                selectedType = listItems.SelectedItems[0].SubItems[7].Text;
                selectedEquipedDate = listItems.SelectedItems[0].SubItems[8].Text;
                selectedExpiresDate = listItems.SelectedItems[0].SubItems[9].Text;
            }
        }

        private void listItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && selectedNum != null) {
                var answer = MessageBox.Show("Ви дійсно бажаєте видалити '" + selectedName + "'?", "Предмет №" + selectedSerialNum, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answer == DialogResult.Yes) {
                    Delete();

                    LoadData();
                } else {
                    selectedNum = null;
                    selectedName = null;
                    selectedSerialNum = null;
                }
            } else if (e.KeyCode == Keys.F5) {
                txtItemName.Text = "";
                txtItemSerialNum.Text = "";
                txtItemExists.Text = "";
                txtItemType.Text = "";

                selectedNum = null;
                selectedName = null;
                selectedSerialNum = null;

                LoadData();
            }
        }

        private void listItems_MouseDown(object sender, MouseEventArgs e)
        {
            if (listItems.SelectedIndices != null) {
                selectedNum = null;
                selectedName = null;
                selectedSerialNum = null;
            }
        }

        private void btnChooseDataBase_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    DBPath = ofd.FileName;

                    lbltitle.Text = "Огляд інвентаря: " + DBPath;

                    conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath);

                    try {
                        UnLock();

                        LoadData();
                    } catch (Exception) {
                        MessageBox.Show("Сталася помилка під час завантаження даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);

            this.Dispose();
        }

        private void LoadData()
        {
            try {
                conn.Open();

                oda = new OleDbDataAdapter("SELECT * FROM Items", conn);
                dt = new DataTable();

                oda.Fill(dt);

                listItems.Items.Clear();

                selectedNum = null;
                selectedName = null;
                selectedSerialNum = null;

                int itemNum = 1;

                foreach (DataRow row in dt.Rows) {
                    ListViewItem item = new ListViewItem(Convert.ToString(itemNum++));

                    item.SubItems.Add(row["Item_Name"].ToString());
                    item.SubItems.Add(row["Item_SerialNum"].ToString());
                    item.SubItems.Add(row["Item_Price"].ToString());
                    item.SubItems.Add(row["Item_TotalPrice"].ToString());
                    item.SubItems.Add(row["Item_Exists"].ToString());
                    item.SubItems.Add(row["Item_Count"].ToString());
                    item.SubItems.Add(row["Item_Type"].ToString());
                    item.SubItems.Add(row["Item_EquipDate"].ToString());
                    item.SubItems.Add(row["Item_ExpiresDate"].ToString());

                    listItems.Items.Add(item);
                }

                conn.Close();
            } catch (Exception) {
                MessageBox.Show("Обрана Вами база даних не підтримуеться цим застосунком. Будь ласка переконайтеся в тому, що Ви обираєте правильну базу даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Lock();
            }
        }

        private void FillSearchResult()
        {
            dt = new DataTable();

            oda.Fill(dt);

            listItems.Items.Clear();

            int itemNum = 1;

            foreach (DataRow row in dt.Rows) {
                ListViewItem item = new ListViewItem(Convert.ToString(itemNum++));

                item.SubItems.Add(row["Item_Name"].ToString());
                item.SubItems.Add(row["Item_SerialNum"].ToString());
                item.SubItems.Add(row["Item_Price"].ToString());
                item.SubItems.Add(row["Item_TotalPrice"].ToString());
                item.SubItems.Add(row["Item_Exists"].ToString());
                item.SubItems.Add(row["Item_Count"].ToString());
                item.SubItems.Add(row["Item_Type"].ToString());

                listItems.Items.Add(item);

                listItems.Select();
            }
        }

        private void Delete()
        {
            try {
                if (listItems.SelectedIndices != null) {
                    foreach (ListViewItem items in listItems.Items) {
                        conn.Open();

                        cmd = new OleDbCommand("DELETE * FROM Items WHERE Item_SerialNum = '" + selectedSerialNum + "'", conn);

                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }

                    LoadData();
                }
            } catch (Exception) {
                MessageBox.Show("Сталася помилка при видаленні.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save()
        {
            if (listItems.Items != null) {
                try {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Предмети (*.dat)|*.dat", ValidateNames = true }) {
                        if (sfd.ShowDialog() == DialogResult.OK) {
                            using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create))) {
                                foreach (ListViewItem items in listItems.Items) {
                                    tw.WriteLine("№: " + items.SubItems[0].Text + 
                                        "\nНазва: " + items.SubItems[1].Text + 
                                        "\nСерійний номер: " + items.SubItems[2].Text + 
                                        "\nЦіна: " + items.SubItems[3].Text +
                                        "\nСума: " + items.SubItems[4].Text + 
                                        "\nНаявність: " + items.SubItems[5].Text + 
                                        "\nКількість: " + items.SubItems[6].Text + 
                                        "\nТип: " + items.SubItems[7].Text + 
                                        "\n----------------------------------------------");
                                }

                                tw.WriteLine("\nОстаннє збереження було о " + DateTime.Now.ToShortTimeString() + ", " + DateTime.Now.ToLongDateString());
                                tw.Close();
                            }
                        }
                    }
                } catch (Exception) {
                    MessageBox.Show("Сталася помилка при обробці даних.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Lock()
        {
            lbltitle.Text = "Огляд інвентаря";

            pnlListHeader.Visible = false;

            pnlStartPage.Visible = true;
            lblGreetings.Visible = true;
            btnChooseDataBase.Visible = true;

            listItems.Visible = false;

            btnAdd.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = false;
            btnRefresh.Visible = false;

            btnSightOut.Visible = false;
        }

        private void UnLock()
        {
            pnlListHeader.Visible = true;

            pnlFormMenu.Select();

            pnlStartPage.Visible = false;
            lblGreetings.Visible = false;
            btnChooseDataBase.Visible = false;

            listItems.Visible = true;

            btnAdd.Visible = true;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnSave.Visible = true;
            btnRefresh.Visible = true;

            btnSightOut.Visible = true;
        }

        private void timerR_Tick(object sender, EventArgs e)
        {
            if (b >= 244) {
                r -= 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnHide.BackColor = Color.FromArgb(r, g, b);
                btnMaximize.BackColor = Color.FromArgb(r, g, b);
                btnMinimize.BackColor = Color.FromArgb(r, g, b);
                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnChooseDataBase.BackColor = Color.FromArgb(r, g, b);

                lnkTutorial.LinkColor = Color.FromArgb(r, g, b);

                pnlFormMenu.BackColor = Color.FromArgb(r, g, b);

                btnAdd.BackColor = Color.FromArgb(r, g, b);
                btnEdit.BackColor = Color.FromArgb(r, g, b);
                btnDelete.BackColor = Color.FromArgb(r, g, b);
                btnSave.BackColor = Color.FromArgb(r, g, b);
                btnRefresh.BackColor = Color.FromArgb(r, g, b);

                btnSightOut.BackColor = Color.FromArgb(r, g, b);
                btnSettings.BackColor = Color.FromArgb(r, g, b);

                if (r <= 65) {
                    timerR.Stop();
                    timerG.Start();
                }
            }

            if (b <= 65) {
                r += 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnHide.BackColor = Color.FromArgb(r, g, b);
                btnMaximize.BackColor = Color.FromArgb(r, g, b);
                btnMinimize.BackColor = Color.FromArgb(r, g, b);
                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnChooseDataBase.BackColor = Color.FromArgb(r, g, b);

                lnkTutorial.LinkColor = Color.FromArgb(r, g, b);

                pnlFormMenu.BackColor = Color.FromArgb(r, g, b);

                btnAdd.BackColor = Color.FromArgb(r, g, b);
                btnEdit.BackColor = Color.FromArgb(r, g, b);
                btnDelete.BackColor = Color.FromArgb(r, g, b);
                btnSave.BackColor = Color.FromArgb(r, g, b);
                btnRefresh.BackColor = Color.FromArgb(r, g, b);

                btnSightOut.BackColor = Color.FromArgb(r, g, b);
                btnSettings.BackColor = Color.FromArgb(r, g, b);

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

                btnHide.BackColor = Color.FromArgb(r, g, b);
                btnMaximize.BackColor = Color.FromArgb(r, g, b);
                btnMinimize.BackColor = Color.FromArgb(r, g, b);
                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnChooseDataBase.BackColor = Color.FromArgb(r, g, b);

                lnkTutorial.LinkColor = Color.FromArgb(r, g, b);

                pnlFormMenu.BackColor = Color.FromArgb(r, g, b);

                btnAdd.BackColor = Color.FromArgb(r, g, b);
                btnEdit.BackColor = Color.FromArgb(r, g, b);
                btnDelete.BackColor = Color.FromArgb(r, g, b);
                btnSave.BackColor = Color.FromArgb(r, g, b);
                btnRefresh.BackColor = Color.FromArgb(r, g, b);

                btnSightOut.BackColor = Color.FromArgb(r, g, b);
                btnSettings.BackColor = Color.FromArgb(r, g, b);

                if (g >= 244) {
                    timerG.Stop();
                    timerB.Start();
                }
            }

            if (r >= 244) {
                g -= 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnHide.BackColor = Color.FromArgb(r, g, b);
                btnMaximize.BackColor = Color.FromArgb(r, g, b);
                btnMinimize.BackColor = Color.FromArgb(r, g, b);
                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnChooseDataBase.BackColor = Color.FromArgb(r, g, b);

                lnkTutorial.LinkColor = Color.FromArgb(r, g, b);

                pnlFormMenu.BackColor = Color.FromArgb(r, g, b);

                btnAdd.BackColor = Color.FromArgb(r, g, b);
                btnEdit.BackColor = Color.FromArgb(r, g, b);
                btnDelete.BackColor = Color.FromArgb(r, g, b);
                btnSave.BackColor = Color.FromArgb(r, g, b);
                btnRefresh.BackColor = Color.FromArgb(r, g, b);

                btnSightOut.BackColor = Color.FromArgb(r, g, b);
                btnSettings.BackColor = Color.FromArgb(r, g, b);

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

                btnHide.BackColor = Color.FromArgb(r, g, b);
                btnMaximize.BackColor = Color.FromArgb(r, g, b);
                btnMinimize.BackColor = Color.FromArgb(r, g, b);
                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnChooseDataBase.BackColor = Color.FromArgb(r, g, b);

                lnkTutorial.LinkColor = Color.FromArgb(r, g, b);

                pnlFormMenu.BackColor = Color.FromArgb(r, g, b);

                btnAdd.BackColor = Color.FromArgb(r, g, b);
                btnEdit.BackColor = Color.FromArgb(r, g, b);
                btnDelete.BackColor = Color.FromArgb(r, g, b);
                btnSave.BackColor = Color.FromArgb(r, g, b);
                btnRefresh.BackColor = Color.FromArgb(r, g, b);

                btnSightOut.BackColor = Color.FromArgb(r, g, b);
                btnSettings.BackColor = Color.FromArgb(r, g, b);

                if (b >= 244) {
                    timerB.Stop();
                    timerR.Start();
                }
            }

            if (g >= 244) {
                b -= 10;

                pnlFormBorder.BackColor = Color.FromArgb(r, g, b);

                btnHide.BackColor = Color.FromArgb(r, g, b);
                btnMaximize.BackColor = Color.FromArgb(r, g, b);
                btnMinimize.BackColor = Color.FromArgb(r, g, b);
                btnClose.BackColor = Color.FromArgb(r, g, b);

                btnChooseDataBase.BackColor = Color.FromArgb(r, g, b);

                lnkTutorial.LinkColor = Color.FromArgb(r, g, b);

                pnlFormMenu.BackColor = Color.FromArgb(r, g, b);

                btnAdd.BackColor = Color.FromArgb(r, g, b);
                btnEdit.BackColor = Color.FromArgb(r, g, b);
                btnDelete.BackColor = Color.FromArgb(r, g, b);
                btnSave.BackColor = Color.FromArgb(r, g, b);
                btnRefresh.BackColor = Color.FromArgb(r, g, b);

                btnSightOut.BackColor = Color.FromArgb(r, g, b);
                btnSettings.BackColor = Color.FromArgb(r, g, b);

                if (b <= 65) {
                    timerB.Stop();
                    timerR.Start();
                }
            }
        }
    }
}