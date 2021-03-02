namespace InventoryViewer
{
    partial class frmEdit
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
            this.txtItemName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemSerialNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnPlusOne = new System.Windows.Forms.Button();
            this.btnMinusOne = new System.Windows.Forms.Button();
            this.txtItemType = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemCount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblItemTotalPrice = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtItemExists = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkExtinguisher = new System.Windows.Forms.CheckBox();
            this.txtExpiresDate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblstartdate_expiresdate = new MaterialSkin.Controls.MaterialLabel();
            this.txtEquipDate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.timerG = new System.Windows.Forms.Timer(this.components);
            this.timerB = new System.Windows.Forms.Timer(this.components);
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
            this.pnlFormBorder.TabIndex = 1;
            this.pnlFormBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFormBorder_MouseDown);
            this.pnlFormBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFormBorder_MouseMove);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(22, 5);
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
            this.txtItemName.TabIndex = 2;
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
            this.txtItemSerialNum.TabIndex = 3;
            this.txtItemSerialNum.TabStop = false;
            this.txtItemSerialNum.UseSystemPasswordChar = false;
            this.txtItemSerialNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemSerialNum_KeyPress);
            // 
            // btnPlusOne
            // 
            this.btnPlusOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlusOne.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPlusOne.FlatAppearance.BorderSize = 0;
            this.btnPlusOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusOne.ForeColor = System.Drawing.Color.White;
            this.btnPlusOne.Location = new System.Drawing.Point(336, 93);
            this.btnPlusOne.Name = "btnPlusOne";
            this.btnPlusOne.Size = new System.Drawing.Size(24, 24);
            this.btnPlusOne.TabIndex = 105;
            this.btnPlusOne.TabStop = false;
            this.btnPlusOne.Text = "+";
            this.btnPlusOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPlusOne.UseVisualStyleBackColor = false;
            this.btnPlusOne.Click += new System.EventHandler(this.btnPlusOne_Click);
            // 
            // btnMinusOne
            // 
            this.btnMinusOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinusOne.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMinusOne.FlatAppearance.BorderSize = 0;
            this.btnMinusOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinusOne.ForeColor = System.Drawing.Color.White;
            this.btnMinusOne.Location = new System.Drawing.Point(366, 93);
            this.btnMinusOne.Name = "btnMinusOne";
            this.btnMinusOne.Size = new System.Drawing.Size(24, 24);
            this.btnMinusOne.TabIndex = 104;
            this.btnMinusOne.TabStop = false;
            this.btnMinusOne.Text = "-";
            this.btnMinusOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinusOne.UseVisualStyleBackColor = false;
            this.btnMinusOne.Click += new System.EventHandler(this.btnMinusOne_Click);
            // 
            // txtItemType
            // 
            this.txtItemType.Depth = 0;
            this.txtItemType.Hint = "Тип";
            this.txtItemType.Location = new System.Drawing.Point(12, 138);
            this.txtItemType.MaxLength = 100;
            this.txtItemType.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.PasswordChar = '\0';
            this.txtItemType.SelectedText = "";
            this.txtItemType.SelectionLength = 0;
            this.txtItemType.SelectionStart = 0;
            this.txtItemType.Size = new System.Drawing.Size(199, 23);
            this.txtItemType.TabIndex = 103;
            this.txtItemType.TabStop = false;
            this.txtItemType.UseSystemPasswordChar = false;
            this.txtItemType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemType_KeyPress);
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
            this.txtItemCount.TabIndex = 102;
            this.txtItemCount.TabStop = false;
            this.txtItemCount.UseSystemPasswordChar = false;
            this.txtItemCount.TextChanged += new System.EventHandler(this.txtItemCount_TextChanged);
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
            this.txtItemPrice.TabIndex = 101;
            this.txtItemPrice.TabStop = false;
            this.txtItemPrice.UseSystemPasswordChar = false;
            this.txtItemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemPrice_KeyPress);
            this.txtItemPrice.TextChanged += new System.EventHandler(this.txtItemPrice_TextChanged);
            // 
            // lblItemTotalPrice
            // 
            this.lblItemTotalPrice.AutoSize = true;
            this.lblItemTotalPrice.Depth = 0;
            this.lblItemTotalPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblItemTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemTotalPrice.Location = new System.Drawing.Point(186, 181);
            this.lblItemTotalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemTotalPrice.Name = "lblItemTotalPrice";
            this.lblItemTotalPrice.Size = new System.Drawing.Size(202, 19);
            this.lblItemTotalPrice.TabIndex = 106;
            this.lblItemTotalPrice.Text = "Поточна сума: %totalprice%";
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
            this.btnCancel.Location = new System.Drawing.Point(205, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(101, 36);
            this.btnCancel.TabIndex = 108;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(98, 302);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(101, 36);
            this.btnUpdate.TabIndex = 107;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Оновити";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtItemExists
            // 
            this.txtItemExists.Depth = 0;
            this.txtItemExists.Hint = "Наявність";
            this.txtItemExists.Location = new System.Drawing.Point(217, 138);
            this.txtItemExists.MaxLength = 3;
            this.txtItemExists.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemExists.Name = "txtItemExists";
            this.txtItemExists.PasswordChar = '\0';
            this.txtItemExists.SelectedText = "";
            this.txtItemExists.SelectionLength = 0;
            this.txtItemExists.SelectionStart = 0;
            this.txtItemExists.Size = new System.Drawing.Size(173, 23);
            this.txtItemExists.TabIndex = 109;
            this.txtItemExists.TabStop = false;
            this.txtItemExists.UseSystemPasswordChar = false;
            this.txtItemExists.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemExists_KeyPress);
            // 
            // chkExtinguisher
            // 
            this.chkExtinguisher.AutoSize = true;
            this.chkExtinguisher.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkExtinguisher.Location = new System.Drawing.Point(12, 182);
            this.chkExtinguisher.Name = "chkExtinguisher";
            this.chkExtinguisher.Size = new System.Drawing.Size(97, 18);
            this.chkExtinguisher.TabIndex = 110;
            this.chkExtinguisher.Text = "Вогнегасник";
            this.chkExtinguisher.UseVisualStyleBackColor = true;
            this.chkExtinguisher.CheckedChanged += new System.EventHandler(this.chkExtinguisher_CheckedChanged);
            // 
            // txtExpiresDate
            // 
            this.txtExpiresDate.Depth = 0;
            this.txtExpiresDate.Hint = "%expiresdate%";
            this.txtExpiresDate.Location = new System.Drawing.Point(191, 256);
            this.txtExpiresDate.MaxLength = 19;
            this.txtExpiresDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtExpiresDate.Name = "txtExpiresDate";
            this.txtExpiresDate.PasswordChar = '\0';
            this.txtExpiresDate.SelectedText = "";
            this.txtExpiresDate.SelectionLength = 0;
            this.txtExpiresDate.SelectionStart = 0;
            this.txtExpiresDate.Size = new System.Drawing.Size(199, 23);
            this.txtExpiresDate.TabIndex = 113;
            this.txtExpiresDate.TabStop = false;
            this.txtExpiresDate.UseSystemPasswordChar = false;
            // 
            // lblstartdate_expiresdate
            // 
            this.lblstartdate_expiresdate.AutoSize = true;
            this.lblstartdate_expiresdate.Depth = 0;
            this.lblstartdate_expiresdate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblstartdate_expiresdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblstartdate_expiresdate.Location = new System.Drawing.Point(8, 221);
            this.lblstartdate_expiresdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblstartdate_expiresdate.Name = "lblstartdate_expiresdate";
            this.lblstartdate_expiresdate.Size = new System.Drawing.Size(319, 19);
            this.lblstartdate_expiresdate.TabIndex = 112;
            this.lblstartdate_expiresdate.Text = "Початок терміну дії:         Кінець терміну дії:";
            // 
            // txtEquipDate
            // 
            this.txtEquipDate.Depth = 0;
            this.txtEquipDate.Hint = "%nowdate%";
            this.txtEquipDate.Location = new System.Drawing.Point(12, 256);
            this.txtEquipDate.MaxLength = 19;
            this.txtEquipDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEquipDate.Name = "txtEquipDate";
            this.txtEquipDate.PasswordChar = '\0';
            this.txtEquipDate.SelectedText = "";
            this.txtEquipDate.SelectionLength = 0;
            this.txtEquipDate.SelectionStart = 0;
            this.txtEquipDate.Size = new System.Drawing.Size(173, 23);
            this.txtEquipDate.TabIndex = 111;
            this.txtEquipDate.TabStop = false;
            this.txtEquipDate.UseSystemPasswordChar = false;
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
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 358);
            this.Controls.Add(this.txtExpiresDate);
            this.Controls.Add(this.lblstartdate_expiresdate);
            this.Controls.Add(this.txtEquipDate);
            this.Controls.Add(this.chkExtinguisher);
            this.Controls.Add(this.txtItemExists);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblItemTotalPrice);
            this.Controls.Add(this.btnPlusOne);
            this.Controls.Add(this.btnMinusOne);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.txtItemCount);
            this.Controls.Add(this.txtItemPrice);
            this.Controls.Add(this.txtItemSerialNum);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.pnlFormBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "%title%";
            this.ClientSizeChanged += new System.EventHandler(this.frmEdit_ClientSizeChanged);
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAppImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctBoxAppImg;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemSerialNum;
        private System.Windows.Forms.Button btnPlusOne;
        private System.Windows.Forms.Button btnMinusOne;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemType;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemCount;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemPrice;
        private MaterialSkin.Controls.MaterialLabel lblItemTotalPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemExists;
        private System.Windows.Forms.CheckBox chkExtinguisher;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtExpiresDate;
        private MaterialSkin.Controls.MaterialLabel lblstartdate_expiresdate;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEquipDate;
        private System.Windows.Forms.Timer timerR;
        private System.Windows.Forms.Timer timerG;
        private System.Windows.Forms.Timer timerB;
    }
}