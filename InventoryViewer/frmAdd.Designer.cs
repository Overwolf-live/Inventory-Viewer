namespace InventoryViewer
{
    partial class frmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pctBoxAppImg = new System.Windows.Forms.PictureBox();
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.timerG = new System.Windows.Forms.Timer(this.components);
            this.timerB = new System.Windows.Forms.Timer(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtItemName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemSerialNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemCount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblItemTotalPrice = new MaterialSkin.Controls.MaterialLabel();
            this.txtItemType = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnMinusOne = new System.Windows.Forms.Button();
            this.btnPlusOne = new System.Windows.Forms.Button();
            this.chkExtinguisher = new System.Windows.Forms.CheckBox();
            this.txtEquipDate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblstartdate_expiresdate = new MaterialSkin.Controls.MaterialLabel();
            this.txtExpiresDate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlFormBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAppImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFormBorder
            // 
            this.pnlFormBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormBorder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlFormBorder.Controls.Add(this.lbltitle);
            this.pnlFormBorder.Controls.Add(this.btnClose);
            this.pnlFormBorder.Controls.Add(this.pctBoxAppImg);
            this.pnlFormBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBorder.Name = "pnlFormBorder";
            this.pnlFormBorder.Size = new System.Drawing.Size(405, 26);
            this.pnlFormBorder.TabIndex = 0;
            this.pnlFormBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFormBorder_MouseDown);
            this.pnlFormBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFormBorder_MouseMove);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(22, 4);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(52, 16);
            this.lbltitle.TabIndex = 91;
            this.lbltitle.Text = "%title%";
            this.lbltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbltitle_MouseDown);
            this.lbltitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbltitle_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(380, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 26);
            this.btnClose.TabIndex = 92;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "❌";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pctBoxAppImg
            // 
            this.pctBoxAppImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctBoxAppImg.Location = new System.Drawing.Point(4, 4);
            this.pctBoxAppImg.Name = "pctBoxAppImg";
            this.pctBoxAppImg.Size = new System.Drawing.Size(18, 18);
            this.pctBoxAppImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxAppImg.TabIndex = 90;
            this.pctBoxAppImg.TabStop = false;
            // 
            // timerR
            // 
            this.timerR.Tick += new System.EventHandler(this.timerR_Tick);
            // 
            // timerG
            // 
            this.timerG.Tick += new System.EventHandler(this.timerG_Tick);
            // 
            // timerB
            // 
            this.timerB.Tick += new System.EventHandler(this.timerB_Tick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(99, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(101, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Дотати";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(206, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(101, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Depth = 0;
            this.txtItemName.Hint = "Назва";
            this.txtItemName.Location = new System.Drawing.Point(12, 51);
            this.txtItemName.MaxLength = 100;
            this.txtItemName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.SelectedText = "";
            this.txtItemName.SelectionLength = 0;
            this.txtItemName.SelectionStart = 0;
            this.txtItemName.Size = new System.Drawing.Size(236, 23);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.TabStop = false;
            this.txtItemName.UseSystemPasswordChar = false;
            // 
            // txtItemSerialNum
            // 
            this.txtItemSerialNum.Depth = 0;
            this.txtItemSerialNum.Hint = "Серійний код";
            this.txtItemSerialNum.Location = new System.Drawing.Point(254, 51);
            this.txtItemSerialNum.MaxLength = 8;
            this.txtItemSerialNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemSerialNum.Name = "txtItemSerialNum";
            this.txtItemSerialNum.PasswordChar = '\0';
            this.txtItemSerialNum.SelectedText = "";
            this.txtItemSerialNum.SelectionLength = 0;
            this.txtItemSerialNum.SelectionStart = 0;
            this.txtItemSerialNum.Size = new System.Drawing.Size(136, 23);
            this.txtItemSerialNum.TabIndex = 1;
            this.txtItemSerialNum.TabStop = false;
            this.txtItemSerialNum.UseSystemPasswordChar = false;
            this.txtItemSerialNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemSerialNum_KeyPress);
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Depth = 0;
            this.txtItemPrice.Hint = "Ціна/шт";
            this.txtItemPrice.Location = new System.Drawing.Point(12, 94);
            this.txtItemPrice.MaxLength = 8;
            this.txtItemPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.PasswordChar = '\0';
            this.txtItemPrice.SelectedText = "";
            this.txtItemPrice.SelectionLength = 0;
            this.txtItemPrice.SelectionStart = 0;
            this.txtItemPrice.Size = new System.Drawing.Size(173, 23);
            this.txtItemPrice.TabIndex = 2;
            this.txtItemPrice.TabStop = false;
            this.txtItemPrice.UseSystemPasswordChar = false;
            this.txtItemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemPrice_KeyPress);
            this.txtItemPrice.TextChanged += new System.EventHandler(this.txtItemPrice_TextChanged);
            // 
            // txtItemCount
            // 
            this.txtItemCount.Depth = 0;
            this.txtItemCount.Enabled = false;
            this.txtItemCount.Hint = "Кількість";
            this.txtItemCount.Location = new System.Drawing.Point(195, 94);
            this.txtItemCount.MaxLength = 8;
            this.txtItemCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemCount.Name = "txtItemCount";
            this.txtItemCount.PasswordChar = '\0';
            this.txtItemCount.SelectedText = "";
            this.txtItemCount.SelectionLength = 0;
            this.txtItemCount.SelectionStart = 0;
            this.txtItemCount.Size = new System.Drawing.Size(135, 23);
            this.txtItemCount.TabIndex = 3;
            this.txtItemCount.TabStop = false;
            this.txtItemCount.UseSystemPasswordChar = false;
            this.txtItemCount.TextChanged += new System.EventHandler(this.txtItemCount_TextChanged);
            // 
            // lblItemTotalPrice
            // 
            this.lblItemTotalPrice.AutoSize = true;
            this.lblItemTotalPrice.Depth = 0;
            this.lblItemTotalPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblItemTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemTotalPrice.Location = new System.Drawing.Point(191, 148);
            this.lblItemTotalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemTotalPrice.Name = "lblItemTotalPrice";
            this.lblItemTotalPrice.Size = new System.Drawing.Size(202, 19);
            this.lblItemTotalPrice.TabIndex = 98;
            this.lblItemTotalPrice.Text = "Поточна сума: %totalprice%";
            // 
            // txtItemType
            // 
            this.txtItemType.Depth = 0;
            this.txtItemType.Hint = "Тип";
            this.txtItemType.Location = new System.Drawing.Point(12, 146);
            this.txtItemType.MaxLength = 100;
            this.txtItemType.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.PasswordChar = '\0';
            this.txtItemType.SelectedText = "";
            this.txtItemType.SelectionLength = 0;
            this.txtItemType.SelectionStart = 0;
            this.txtItemType.Size = new System.Drawing.Size(173, 23);
            this.txtItemType.TabIndex = 4;
            this.txtItemType.TabStop = false;
            this.txtItemType.UseSystemPasswordChar = false;
            this.txtItemType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemType_KeyPress);
            // 
            // btnMinusOne
            // 
            this.btnMinusOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinusOne.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMinusOne.FlatAppearance.BorderSize = 0;
            this.btnMinusOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusOne.ForeColor = System.Drawing.Color.White;
            this.btnMinusOne.Location = new System.Drawing.Point(366, 94);
            this.btnMinusOne.Name = "btnMinusOne";
            this.btnMinusOne.Size = new System.Drawing.Size(24, 24);
            this.btnMinusOne.TabIndex = 99;
            this.btnMinusOne.TabStop = false;
            this.btnMinusOne.Text = "-";
            this.btnMinusOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusOne.UseVisualStyleBackColor = false;
            this.btnMinusOne.Click += new System.EventHandler(this.btnMinusOne_Click);
            // 
            // btnPlusOne
            // 
            this.btnPlusOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlusOne.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPlusOne.FlatAppearance.BorderSize = 0;
            this.btnPlusOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusOne.ForeColor = System.Drawing.Color.White;
            this.btnPlusOne.Location = new System.Drawing.Point(336, 94);
            this.btnPlusOne.Name = "btnPlusOne";
            this.btnPlusOne.Size = new System.Drawing.Size(24, 24);
            this.btnPlusOne.TabIndex = 100;
            this.btnPlusOne.TabStop = false;
            this.btnPlusOne.Text = "+";
            this.btnPlusOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusOne.UseVisualStyleBackColor = false;
            this.btnPlusOne.Click += new System.EventHandler(this.btnPlusOne_Click);
            // 
            // chkExtinguisher
            // 
            this.chkExtinguisher.AutoSize = true;
            this.chkExtinguisher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkExtinguisher.Location = new System.Drawing.Point(12, 185);
            this.chkExtinguisher.Name = "chkExtinguisher";
            this.chkExtinguisher.Size = new System.Drawing.Size(97, 18);
            this.chkExtinguisher.TabIndex = 101;
            this.chkExtinguisher.Text = "Вогнегасник";
            this.chkExtinguisher.UseVisualStyleBackColor = true;
            this.chkExtinguisher.CheckedChanged += new System.EventHandler(this.chkExtinguisher_CheckedChanged);
            // 
            // txtEquipDate
            // 
            this.txtEquipDate.Depth = 0;
            this.txtEquipDate.Hint = "%nowdate%";
            this.txtEquipDate.Location = new System.Drawing.Point(12, 252);
            this.txtEquipDate.MaxLength = 19;
            this.txtEquipDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEquipDate.Name = "txtEquipDate";
            this.txtEquipDate.PasswordChar = '\0';
            this.txtEquipDate.SelectedText = "";
            this.txtEquipDate.SelectionLength = 0;
            this.txtEquipDate.SelectionStart = 0;
            this.txtEquipDate.Size = new System.Drawing.Size(173, 23);
            this.txtEquipDate.TabIndex = 102;
            this.txtEquipDate.TabStop = false;
            this.txtEquipDate.UseSystemPasswordChar = false;
            // 
            // lblstartdate_expiresdate
            // 
            this.lblstartdate_expiresdate.AutoSize = true;
            this.lblstartdate_expiresdate.Depth = 0;
            this.lblstartdate_expiresdate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblstartdate_expiresdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblstartdate_expiresdate.Location = new System.Drawing.Point(8, 217);
            this.lblstartdate_expiresdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblstartdate_expiresdate.Name = "lblstartdate_expiresdate";
            this.lblstartdate_expiresdate.Size = new System.Drawing.Size(319, 19);
            this.lblstartdate_expiresdate.TabIndex = 104;
            this.lblstartdate_expiresdate.Text = "Початок терміну дії:         Кінець терміну дії:";
            // 
            // txtExpiresDate
            // 
            this.txtExpiresDate.Depth = 0;
            this.txtExpiresDate.Hint = "%expiresdate%";
            this.txtExpiresDate.Location = new System.Drawing.Point(191, 252);
            this.txtExpiresDate.MaxLength = 19;
            this.txtExpiresDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtExpiresDate.Name = "txtExpiresDate";
            this.txtExpiresDate.PasswordChar = '\0';
            this.txtExpiresDate.SelectedText = "";
            this.txtExpiresDate.SelectionLength = 0;
            this.txtExpiresDate.SelectionStart = 0;
            this.txtExpiresDate.Size = new System.Drawing.Size(199, 23);
            this.txtExpiresDate.TabIndex = 105;
            this.txtExpiresDate.TabStop = false;
            this.txtExpiresDate.UseSystemPasswordChar = false;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 358);
            this.Controls.Add(this.txtExpiresDate);
            this.Controls.Add(this.lblstartdate_expiresdate);
            this.Controls.Add(this.txtEquipDate);
            this.Controls.Add(this.chkExtinguisher);
            this.Controls.Add(this.btnPlusOne);
            this.Controls.Add(this.btnMinusOne);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.lblItemTotalPrice);
            this.Controls.Add(this.txtItemCount);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.txtItemSerialNum);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlFormBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "%title%";
            this.ClientSizeChanged += new System.EventHandler(this.frmAdd_ClientSizeChanged);
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAppImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox pctBoxAppImg;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timerR;
        private System.Windows.Forms.Timer timerG;
        private System.Windows.Forms.Timer timerB;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemSerialNum;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemCount;
        private MaterialSkin.Controls.MaterialLabel lblItemTotalPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemType;
        private System.Windows.Forms.Button btnMinusOne;
        private System.Windows.Forms.Button btnPlusOne;
        private System.Windows.Forms.CheckBox chkExtinguisher;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEquipDate;
        private MaterialSkin.Controls.MaterialLabel lblstartdate_expiresdate;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtExpiresDate;
    }
}