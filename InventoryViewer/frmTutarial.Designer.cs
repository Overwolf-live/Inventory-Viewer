namespace InventoryViewer
{
    partial class frmTutarial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTutarial));
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pctBoxAppImg = new System.Windows.Forms.PictureBox();
            this.timerB = new System.Windows.Forms.Timer(this.components);
            this.timerG = new System.Windows.Forms.Timer(this.components);
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.lblCreateDataBase = new MaterialSkin.Controls.MaterialLabel();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.pctBoxCreateDataBase = new System.Windows.Forms.PictureBox();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.pnlSecondPage = new System.Windows.Forms.Panel();
            this.pnlThirdPage = new System.Windows.Forms.Panel();
            this.lblFillDataTables = new MaterialSkin.Controls.MaterialLabel();
            this.pctBoxFilDataTable = new System.Windows.Forms.PictureBox();
            this.lblSaveDataTable = new MaterialSkin.Controls.MaterialLabel();
            this.pctBoxSaveDataTable = new System.Windows.Forms.PictureBox();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.pnlFormBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAppImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCreateDataBase)).BeginInit();
            this.pnlSecondPage.SuspendLayout();
            this.pnlThirdPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFilDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSaveDataTable)).BeginInit();
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
            this.pnlFormBorder.Size = new System.Drawing.Size(710, 26);
            this.pnlFormBorder.TabIndex = 1;
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
            this.btnClose.Location = new System.Drawing.Point(685, 0);
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
            // timerB
            // 
            this.timerB.Tick += new System.EventHandler(this.timerB_Tick);
            // 
            // timerG
            // 
            this.timerG.Tick += new System.EventHandler(this.timerG_Tick);
            // 
            // timerR
            // 
            this.timerR.Tick += new System.EventHandler(this.timerR_Tick);
            // 
            // lblCreateDataBase
            // 
            this.lblCreateDataBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreateDataBase.AutoSize = true;
            this.lblCreateDataBase.Depth = 0;
            this.lblCreateDataBase.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCreateDataBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCreateDataBase.Location = new System.Drawing.Point(38, 318);
            this.lblCreateDataBase.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCreateDataBase.Name = "lblCreateDataBase";
            this.lblCreateDataBase.Size = new System.Drawing.Size(631, 19);
            this.lblCreateDataBase.TabIndex = 21;
            this.lblCreateDataBase.Text = "1. Для початку відкрийте MS Access DataBase та створіть базу даних із форматом .m" +
    "db";
            // 
            // btnNext1
            // 
            this.btnNext1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext1.FlatAppearance.BorderSize = 0;
            this.btnNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext1.ForeColor = System.Drawing.Color.White;
            this.btnNext1.Location = new System.Drawing.Point(661, 400);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNext1.Size = new System.Drawing.Size(36, 34);
            this.btnNext1.TabIndex = 20;
            this.btnNext1.TabStop = false;
            this.btnNext1.Text = ">";
            this.btnNext1.UseVisualStyleBackColor = false;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // pctBoxCreateDataBase
            // 
            this.pctBoxCreateDataBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctBoxCreateDataBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBoxCreateDataBase.Image = global::InventoryViewer.Properties.Resources.create_database;
            this.pctBoxCreateDataBase.Location = new System.Drawing.Point(120, 48);
            this.pctBoxCreateDataBase.Name = "pctBoxCreateDataBase";
            this.pctBoxCreateDataBase.Size = new System.Drawing.Size(516, 254);
            this.pctBoxCreateDataBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxCreateDataBase.TabIndex = 19;
            this.pctBoxCreateDataBase.TabStop = false;
            // 
            // btnBack1
            // 
            this.btnBack1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack1.FlatAppearance.BorderSize = 0;
            this.btnBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.ForeColor = System.Drawing.Color.White;
            this.btnBack1.Location = new System.Drawing.Point(12, 400);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBack1.Size = new System.Drawing.Size(36, 34);
            this.btnBack1.TabIndex = 22;
            this.btnBack1.TabStop = false;
            this.btnBack1.Text = "<";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // pnlSecondPage
            // 
            this.pnlSecondPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSecondPage.Controls.Add(this.pnlThirdPage);
            this.pnlSecondPage.Controls.Add(this.lblSaveDataTable);
            this.pnlSecondPage.Controls.Add(this.pctBoxSaveDataTable);
            this.pnlSecondPage.Location = new System.Drawing.Point(0, 26);
            this.pnlSecondPage.Name = "pnlSecondPage";
            this.pnlSecondPage.Size = new System.Drawing.Size(710, 368);
            this.pnlSecondPage.TabIndex = 23;
            // 
            // pnlThirdPage
            // 
            this.pnlThirdPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThirdPage.Controls.Add(this.lblFillDataTables);
            this.pnlThirdPage.Controls.Add(this.pctBoxFilDataTable);
            this.pnlThirdPage.Location = new System.Drawing.Point(0, 0);
            this.pnlThirdPage.Name = "pnlThirdPage";
            this.pnlThirdPage.Size = new System.Drawing.Size(710, 368);
            this.pnlThirdPage.TabIndex = 24;
            // 
            // lblFillDataTables
            // 
            this.lblFillDataTables.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFillDataTables.AutoSize = true;
            this.lblFillDataTables.Depth = 0;
            this.lblFillDataTables.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFillDataTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFillDataTables.Location = new System.Drawing.Point(25, 292);
            this.lblFillDataTables.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFillDataTables.Name = "lblFillDataTables";
            this.lblFillDataTables.Size = new System.Drawing.Size(669, 57);
            this.lblFillDataTables.TabIndex = 23;
            this.lblFillDataTables.Text = resources.GetString("lblFillDataTables.Text");
            // 
            // pctBoxFilDataTable
            // 
            this.pctBoxFilDataTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctBoxFilDataTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBoxFilDataTable.Image = global::InventoryViewer.Properties.Resources.fill_datatable;
            this.pctBoxFilDataTable.Location = new System.Drawing.Point(104, 22);
            this.pctBoxFilDataTable.Name = "pctBoxFilDataTable";
            this.pctBoxFilDataTable.Size = new System.Drawing.Size(516, 254);
            this.pctBoxFilDataTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxFilDataTable.TabIndex = 22;
            this.pctBoxFilDataTable.TabStop = false;
            // 
            // lblSaveDataTable
            // 
            this.lblSaveDataTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSaveDataTable.AutoSize = true;
            this.lblSaveDataTable.Depth = 0;
            this.lblSaveDataTable.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSaveDataTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSaveDataTable.Location = new System.Drawing.Point(220, 292);
            this.lblSaveDataTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaveDataTable.Name = "lblSaveDataTable";
            this.lblSaveDataTable.Size = new System.Drawing.Size(293, 19);
            this.lblSaveDataTable.TabIndex = 23;
            this.lblSaveDataTable.Text = "2. Збережіть таблицю із назвою: \"Items\"";
            // 
            // pctBoxSaveDataTable
            // 
            this.pctBoxSaveDataTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctBoxSaveDataTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBoxSaveDataTable.Image = global::InventoryViewer.Properties.Resources.save_datatable;
            this.pctBoxSaveDataTable.Location = new System.Drawing.Point(104, 22);
            this.pctBoxSaveDataTable.Name = "pctBoxSaveDataTable";
            this.pctBoxSaveDataTable.Size = new System.Drawing.Size(516, 254);
            this.pctBoxSaveDataTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxSaveDataTable.TabIndex = 22;
            this.pctBoxSaveDataTable.TabStop = false;
            // 
            // btnNext2
            // 
            this.btnNext2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNext2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext2.FlatAppearance.BorderSize = 0;
            this.btnNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext2.ForeColor = System.Drawing.Color.White;
            this.btnNext2.Location = new System.Drawing.Point(661, 400);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNext2.Size = new System.Drawing.Size(36, 34);
            this.btnNext2.TabIndex = 24;
            this.btnNext2.TabStop = false;
            this.btnNext2.Text = ">";
            this.btnNext2.UseVisualStyleBackColor = false;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // btnBack2
            // 
            this.btnBack2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack2.FlatAppearance.BorderSize = 0;
            this.btnBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.ForeColor = System.Drawing.Color.White;
            this.btnBack2.Location = new System.Drawing.Point(12, 400);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBack2.Size = new System.Drawing.Size(36, 34);
            this.btnBack2.TabIndex = 25;
            this.btnBack2.TabStop = false;
            this.btnBack2.Text = "<";
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // frmTutarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(709, 446);
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.btnNext2);
            this.Controls.Add(this.pnlSecondPage);
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.lblCreateDataBase);
            this.Controls.Add(this.btnNext1);
            this.Controls.Add(this.pctBoxCreateDataBase);
            this.Controls.Add(this.pnlFormBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTutarial";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTutarial";
            this.ClientSizeChanged += new System.EventHandler(this.frmTutarial_ClientSizeChanged);
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAppImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxCreateDataBase)).EndInit();
            this.pnlSecondPage.ResumeLayout(false);
            this.pnlSecondPage.PerformLayout();
            this.pnlThirdPage.ResumeLayout(false);
            this.pnlThirdPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxFilDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxSaveDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctBoxAppImg;
        private System.Windows.Forms.Timer timerB;
        private System.Windows.Forms.Timer timerG;
        private System.Windows.Forms.Timer timerR;
        private MaterialSkin.Controls.MaterialLabel lblCreateDataBase;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.PictureBox pctBoxCreateDataBase;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Panel pnlSecondPage;
        private MaterialSkin.Controls.MaterialLabel lblSaveDataTable;
        private System.Windows.Forms.PictureBox pctBoxSaveDataTable;
        private System.Windows.Forms.Panel pnlThirdPage;
        private MaterialSkin.Controls.MaterialLabel lblFillDataTables;
        private System.Windows.Forms.PictureBox pctBoxFilDataTable;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.Button btnBack2;
    }
}