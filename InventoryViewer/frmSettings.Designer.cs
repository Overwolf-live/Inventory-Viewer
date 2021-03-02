namespace InventoryViewer
{
    partial class frmSettings
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblColor = new MaterialSkin.Controls.MaterialLabel();
            this.pctBoxPreview = new System.Windows.Forms.PictureBox();
            this.btnDefaultColor = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnMagenta = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnPink = new System.Windows.Forms.Button();
            this.btnDarkCyan = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.pnlPreviewFormBorder = new System.Windows.Forms.Panel();
            this.btnPreviewMaximize = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnPreviewClose = new System.Windows.Forms.Button();
            this.btnPreviewHide = new System.Windows.Forms.Button();
            this.pctBoxPreviewAppImg = new System.Windows.Forms.PictureBox();
            this.pnlPreviewFormMenu = new System.Windows.Forms.Panel();
            this.btnPreviewChooseDataBase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.timerG = new System.Windows.Forms.Timer(this.components);
            this.timerB = new System.Windows.Forms.Timer(this.components);
            this.pnlFormBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAppImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPreview)).BeginInit();
            this.pnlPreviewFormBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPreviewAppImg)).BeginInit();
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
            this.pnlFormBorder.Location = new System.Drawing.Point(0, -1);
            this.pnlFormBorder.Name = "pnlFormBorder";
            this.pnlFormBorder.Size = new System.Drawing.Size(801, 26);
            this.pnlFormBorder.TabIndex = 2;
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
            this.btnClose.Location = new System.Drawing.Point(776, 0);
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
            this.btnCancel.Location = new System.Drawing.Point(687, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancel.Size = new System.Drawing.Size(101, 36);
            this.btnCancel.TabIndex = 110;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(568, 402);
            this.btnApply.Name = "btnApply";
            this.btnApply.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnApply.Size = new System.Drawing.Size(113, 36);
            this.btnApply.TabIndex = 109;
            this.btnApply.TabStop = false;
            this.btnApply.Text = "Застосувати";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Depth = 0;
            this.lblColor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblColor.Location = new System.Drawing.Point(12, 34);
            this.lblColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(53, 19);
            this.lblColor.TabIndex = 111;
            this.lblColor.Text = "Колір:";
            // 
            // pctBoxPreview
            // 
            this.pctBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBoxPreview.Location = new System.Drawing.Point(404, 63);
            this.pctBoxPreview.Name = "pctBoxPreview";
            this.pctBoxPreview.Size = new System.Drawing.Size(384, 324);
            this.pctBoxPreview.TabIndex = 118;
            this.pctBoxPreview.TabStop = false;
            // 
            // btnDefaultColor
            // 
            this.btnDefaultColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDefaultColor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDefaultColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDefaultColor.FlatAppearance.BorderSize = 0;
            this.btnDefaultColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaultColor.ForeColor = System.Drawing.Color.White;
            this.btnDefaultColor.Location = new System.Drawing.Point(16, 64);
            this.btnDefaultColor.Name = "btnDefaultColor";
            this.btnDefaultColor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDefaultColor.Size = new System.Drawing.Size(70, 70);
            this.btnDefaultColor.TabIndex = 123;
            this.btnDefaultColor.TabStop = false;
            this.toolTip.SetToolTip(this.btnDefaultColor, "Синій");
            this.btnDefaultColor.UseVisualStyleBackColor = false;
            this.btnDefaultColor.Click += new System.EventHandler(this.btnDefaultColor_Click);
            this.btnDefaultColor.MouseEnter += new System.EventHandler(this.btnDefaultColor_MouseEnter);
            this.btnDefaultColor.MouseLeave += new System.EventHandler(this.btnDefaultColor_MouseLeave);
            // 
            // btnOrange
            // 
            this.btnOrange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrange.FlatAppearance.BorderSize = 0;
            this.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrange.ForeColor = System.Drawing.Color.White;
            this.btnOrange.Location = new System.Drawing.Point(92, 64);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOrange.Size = new System.Drawing.Size(70, 70);
            this.btnOrange.TabIndex = 124;
            this.btnOrange.TabStop = false;
            this.toolTip.SetToolTip(this.btnOrange, "Оранжевий");
            this.btnOrange.UseVisualStyleBackColor = false;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            this.btnOrange.MouseEnter += new System.EventHandler(this.btnOrange_MouseEnter);
            this.btnOrange.MouseLeave += new System.EventHandler(this.btnOrange_MouseLeave);
            // 
            // btnMagenta
            // 
            this.btnMagenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMagenta.BackColor = System.Drawing.Color.Magenta;
            this.btnMagenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMagenta.FlatAppearance.BorderSize = 0;
            this.btnMagenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMagenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagenta.ForeColor = System.Drawing.Color.White;
            this.btnMagenta.Location = new System.Drawing.Point(168, 64);
            this.btnMagenta.Name = "btnMagenta";
            this.btnMagenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMagenta.Size = new System.Drawing.Size(70, 70);
            this.btnMagenta.TabIndex = 125;
            this.btnMagenta.TabStop = false;
            this.toolTip.SetToolTip(this.btnMagenta, "Магента");
            this.btnMagenta.UseVisualStyleBackColor = false;
            this.btnMagenta.Click += new System.EventHandler(this.btnMagenta_Click);
            this.btnMagenta.MouseEnter += new System.EventHandler(this.btnMagenta_MouseEnter);
            this.btnMagenta.MouseLeave += new System.EventHandler(this.btnMagenta_MouseLeave);
            // 
            // btnGreen
            // 
            this.btnGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(205)))), ((int)(((byte)(82)))));
            this.btnGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGreen.FlatAppearance.BorderSize = 0;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.ForeColor = System.Drawing.Color.White;
            this.btnGreen.Location = new System.Drawing.Point(244, 64);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGreen.Size = new System.Drawing.Size(70, 70);
            this.btnGreen.TabIndex = 126;
            this.btnGreen.TabStop = false;
            this.toolTip.SetToolTip(this.btnGreen, "Лайм");
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            this.btnGreen.MouseEnter += new System.EventHandler(this.btnGreen_MouseEnter);
            this.btnGreen.MouseLeave += new System.EventHandler(this.btnGreen_MouseLeave);
            // 
            // btnPurple
            // 
            this.btnPurple.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPurple.BackColor = System.Drawing.Color.Indigo;
            this.btnPurple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPurple.FlatAppearance.BorderSize = 0;
            this.btnPurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurple.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurple.ForeColor = System.Drawing.Color.White;
            this.btnPurple.Location = new System.Drawing.Point(320, 64);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPurple.Size = new System.Drawing.Size(70, 70);
            this.btnPurple.TabIndex = 127;
            this.btnPurple.TabStop = false;
            this.toolTip.SetToolTip(this.btnPurple, "Фіолетовий");
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            this.btnPurple.MouseEnter += new System.EventHandler(this.btnPurple_MouseEnter);
            this.btnPurple.MouseLeave += new System.EventHandler(this.btnPurple_MouseLeave);
            // 
            // btnPink
            // 
            this.btnPink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPink.BackColor = System.Drawing.Color.Violet;
            this.btnPink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPink.FlatAppearance.BorderSize = 0;
            this.btnPink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPink.ForeColor = System.Drawing.Color.White;
            this.btnPink.Location = new System.Drawing.Point(16, 140);
            this.btnPink.Name = "btnPink";
            this.btnPink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPink.Size = new System.Drawing.Size(70, 70);
            this.btnPink.TabIndex = 128;
            this.btnPink.TabStop = false;
            this.toolTip.SetToolTip(this.btnPink, "Рожевий");
            this.btnPink.UseVisualStyleBackColor = false;
            this.btnPink.Click += new System.EventHandler(this.btnPink_Click);
            this.btnPink.MouseEnter += new System.EventHandler(this.btnPink_MouseEnter);
            this.btnPink.MouseLeave += new System.EventHandler(this.btnPink_MouseLeave);
            // 
            // btnDarkCyan
            // 
            this.btnDarkCyan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDarkCyan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnDarkCyan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDarkCyan.FlatAppearance.BorderSize = 0;
            this.btnDarkCyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkCyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarkCyan.ForeColor = System.Drawing.Color.White;
            this.btnDarkCyan.Location = new System.Drawing.Point(92, 140);
            this.btnDarkCyan.Name = "btnDarkCyan";
            this.btnDarkCyan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDarkCyan.Size = new System.Drawing.Size(70, 70);
            this.btnDarkCyan.TabIndex = 129;
            this.btnDarkCyan.TabStop = false;
            this.toolTip.SetToolTip(this.btnDarkCyan, "Темно голубий");
            this.btnDarkCyan.UseVisualStyleBackColor = false;
            this.btnDarkCyan.Click += new System.EventHandler(this.btnDarkCyan_Click);
            this.btnDarkCyan.MouseEnter += new System.EventHandler(this.btnDarkCyan_MouseEnter);
            this.btnDarkCyan.MouseLeave += new System.EventHandler(this.btnDarkCyan_MouseLeave);
            // 
            // btnRed
            // 
            this.btnRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRed.BackColor = System.Drawing.Color.Brown;
            this.btnRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRed.FlatAppearance.BorderSize = 0;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.ForeColor = System.Drawing.Color.White;
            this.btnRed.Location = new System.Drawing.Point(168, 140);
            this.btnRed.Name = "btnRed";
            this.btnRed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRed.Size = new System.Drawing.Size(70, 70);
            this.btnRed.TabIndex = 130;
            this.btnRed.TabStop = false;
            this.toolTip.SetToolTip(this.btnRed, "Червоний");
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            this.btnRed.MouseEnter += new System.EventHandler(this.btnRed_MouseEnter);
            this.btnRed.MouseLeave += new System.EventHandler(this.btnRed_MouseLeave);
            // 
            // btnBlack
            // 
            this.btnBlack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBlack.FlatAppearance.BorderSize = 0;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlack.ForeColor = System.Drawing.Color.White;
            this.btnBlack.Location = new System.Drawing.Point(244, 140);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBlack.Size = new System.Drawing.Size(70, 70);
            this.btnBlack.TabIndex = 131;
            this.btnBlack.TabStop = false;
            this.toolTip.SetToolTip(this.btnBlack, "Чорний");
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            this.btnBlack.MouseEnter += new System.EventHandler(this.btnBlack_MouseEnter);
            this.btnBlack.MouseLeave += new System.EventHandler(this.btnBlack_MouseLeave);
            // 
            // pnlPreviewFormBorder
            // 
            this.pnlPreviewFormBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPreviewFormBorder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlPreviewFormBorder.Controls.Add(this.btnPreviewMaximize);
            this.pnlPreviewFormBorder.Controls.Add(this.lblUserName);
            this.pnlPreviewFormBorder.Controls.Add(this.btnPreviewClose);
            this.pnlPreviewFormBorder.Controls.Add(this.btnPreviewHide);
            this.pnlPreviewFormBorder.Controls.Add(this.pctBoxPreviewAppImg);
            this.pnlPreviewFormBorder.Location = new System.Drawing.Point(403, 63);
            this.pnlPreviewFormBorder.Name = "pnlPreviewFormBorder";
            this.pnlPreviewFormBorder.Size = new System.Drawing.Size(385, 26);
            this.pnlPreviewFormBorder.TabIndex = 93;
            // 
            // btnPreviewMaximize
            // 
            this.btnPreviewMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviewMaximize.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreviewMaximize.FlatAppearance.BorderSize = 0;
            this.btnPreviewMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviewMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewMaximize.ForeColor = System.Drawing.Color.White;
            this.btnPreviewMaximize.Location = new System.Drawing.Point(338, -3);
            this.btnPreviewMaximize.Name = "btnPreviewMaximize";
            this.btnPreviewMaximize.Size = new System.Drawing.Size(24, 29);
            this.btnPreviewMaximize.TabIndex = 137;
            this.btnPreviewMaximize.TabStop = false;
            this.btnPreviewMaximize.Text = "🗖";
            this.btnPreviewMaximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPreviewMaximize.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(22, 5);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(92, 16);
            this.lblUserName.TabIndex = 91;
            this.lblUserName.Text = "%username%";
            // 
            // btnPreviewClose
            // 
            this.btnPreviewClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviewClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreviewClose.FlatAppearance.BorderSize = 0;
            this.btnPreviewClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviewClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewClose.ForeColor = System.Drawing.Color.White;
            this.btnPreviewClose.Location = new System.Drawing.Point(361, 0);
            this.btnPreviewClose.Name = "btnPreviewClose";
            this.btnPreviewClose.Size = new System.Drawing.Size(24, 26);
            this.btnPreviewClose.TabIndex = 136;
            this.btnPreviewClose.TabStop = false;
            this.btnPreviewClose.Text = "❌";
            this.btnPreviewClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPreviewClose.UseVisualStyleBackColor = false;
            // 
            // btnPreviewHide
            // 
            this.btnPreviewHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviewHide.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreviewHide.FlatAppearance.BorderSize = 0;
            this.btnPreviewHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviewHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewHide.ForeColor = System.Drawing.Color.White;
            this.btnPreviewHide.Location = new System.Drawing.Point(314, 0);
            this.btnPreviewHide.Name = "btnPreviewHide";
            this.btnPreviewHide.Size = new System.Drawing.Size(24, 26);
            this.btnPreviewHide.TabIndex = 135;
            this.btnPreviewHide.TabStop = false;
            this.btnPreviewHide.Text = "—";
            this.btnPreviewHide.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPreviewHide.UseVisualStyleBackColor = false;
            // 
            // pctBoxPreviewAppImg
            // 
            this.pctBoxPreviewAppImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctBoxPreviewAppImg.Location = new System.Drawing.Point(4, 4);
            this.pctBoxPreviewAppImg.Name = "pctBoxPreviewAppImg";
            this.pctBoxPreviewAppImg.Size = new System.Drawing.Size(18, 18);
            this.pctBoxPreviewAppImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxPreviewAppImg.TabIndex = 90;
            this.pctBoxPreviewAppImg.TabStop = false;
            // 
            // pnlPreviewFormMenu
            // 
            this.pnlPreviewFormMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPreviewFormMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlPreviewFormMenu.Location = new System.Drawing.Point(403, 89);
            this.pnlPreviewFormMenu.Name = "pnlPreviewFormMenu";
            this.pnlPreviewFormMenu.Size = new System.Drawing.Size(24, 298);
            this.pnlPreviewFormMenu.TabIndex = 132;
            // 
            // btnPreviewChooseDataBase
            // 
            this.btnPreviewChooseDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviewChooseDataBase.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreviewChooseDataBase.FlatAppearance.BorderSize = 0;
            this.btnPreviewChooseDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviewChooseDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewChooseDataBase.ForeColor = System.Drawing.Color.White;
            this.btnPreviewChooseDataBase.Location = new System.Drawing.Point(566, 229);
            this.btnPreviewChooseDataBase.Name = "btnPreviewChooseDataBase";
            this.btnPreviewChooseDataBase.Size = new System.Drawing.Size(91, 26);
            this.btnPreviewChooseDataBase.TabIndex = 93;
            this.btnPreviewChooseDataBase.TabStop = false;
            this.btnPreviewChooseDataBase.Text = "—︎";
            this.btnPreviewChooseDataBase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPreviewChooseDataBase.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 133;
            this.label1.Text = "——————————————————————————————————————————";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(374, -55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 134;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
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
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreviewChooseDataBase);
            this.Controls.Add(this.pnlPreviewFormMenu);
            this.Controls.Add(this.pnlPreviewFormBorder);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnDarkCyan);
            this.Controls.Add(this.btnPink);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnMagenta);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnDefaultColor);
            this.Controls.Add(this.pctBoxPreview);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.pnlFormBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "%title%";
            this.ClientSizeChanged += new System.EventHandler(this.frmSettings_ClientSizeChanged);
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAppImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPreview)).EndInit();
            this.pnlPreviewFormBorder.ResumeLayout(false);
            this.pnlPreviewFormBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxPreviewAppImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pctBoxAppImg;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private MaterialSkin.Controls.MaterialLabel lblColor;
        private System.Windows.Forms.PictureBox pctBoxPreview;
        private System.Windows.Forms.Button btnDefaultColor;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnMagenta;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnPink;
        private System.Windows.Forms.Button btnDarkCyan;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Panel pnlPreviewFormBorder;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pctBoxPreviewAppImg;
        private System.Windows.Forms.Panel pnlPreviewFormMenu;
        private System.Windows.Forms.Button btnPreviewChooseDataBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPreviewMaximize;
        private System.Windows.Forms.Button btnPreviewClose;
        private System.Windows.Forms.Button btnPreviewHide;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Timer timerR;
        private System.Windows.Forms.Timer timerG;
        private System.Windows.Forms.Timer timerB;
    }
}