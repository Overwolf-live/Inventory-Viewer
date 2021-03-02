namespace InventoryViewer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.pnlFormMenu = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSightOut = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pctBoxAppImg = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnChooseDataBase = new System.Windows.Forms.Button();
            this.listItems = new MaterialSkin.Controls.MaterialListView();
            this.columnItemNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSerialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnExists = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnItemType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEqDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnExDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlListHeader = new System.Windows.Forms.Panel();
            this.txtItemType = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblItemCount = new MaterialSkin.Controls.MaterialLabel();
            this.lblItemTotalPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblItemPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblNum = new MaterialSkin.Controls.MaterialLabel();
            this.txtItemExists = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemSerialNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtItemName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlStartPage = new System.Windows.Forms.Panel();
            this.lnkTutorial = new System.Windows.Forms.LinkLabel();
            this.lblTutorial = new MaterialSkin.Controls.MaterialLabel();
            this.lblGreetings = new MaterialSkin.Controls.MaterialLabel();
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.timerG = new System.Windows.Forms.Timer(this.components);
            this.timerB = new System.Windows.Forms.Timer(this.components);
            this.pnlFormBorder.SuspendLayout();
            this.pnlFormMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAppImg)).BeginInit();
            this.pnlListHeader.SuspendLayout();
            this.pnlStartPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormBorder
            // 
            this.pnlFormBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormBorder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlFormBorder.Controls.Add(this.btnMaximize);
            this.pnlFormBorder.Controls.Add(this.lbltitle);
            this.pnlFormBorder.Controls.Add(this.btnMinimize);
            this.pnlFormBorder.Controls.Add(this.btnClose);
            this.pnlFormBorder.Controls.Add(this.btnHide);
            this.pnlFormBorder.Location = new System.Drawing.Point(40, -1);
            this.pnlFormBorder.Name = "pnlFormBorder";
            this.pnlFormBorder.Size = new System.Drawing.Size(1106, 26);
            this.pnlFormBorder.TabIndex = 0;
            this.pnlFormBorder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlFormBorder_MouseDoubleClick);
            this.pnlFormBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFormBorder_MouseDown);
            this.pnlFormBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFormBorder_MouseMove);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1060, -2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 29);
            this.btnMaximize.TabIndex = 90;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Text = "🗖";
            this.btnMaximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.btnMaximize, "Зменшити");
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(-4, 5);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(52, 16);
            this.lbltitle.TabIndex = 89;
            this.lbltitle.Text = "%title%";
            this.lbltitle.DoubleClick += new System.EventHandler(this.lbltitle_DoubleClick);
            this.lbltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbltitle_MouseDown);
            this.lbltitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbltitle_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1060, -2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(24, 29);
            this.btnMinimize.TabIndex = 85;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "🗗";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.btnMinimize, "Збільшити");
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1083, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 26);
            this.btnClose.TabIndex = 84;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "❌";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.btnClose, "Закрити");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(1035, 2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(24, 26);
            this.btnHide.TabIndex = 83;
            this.btnHide.TabStop = false;
            this.btnHide.Text = "—";
            this.btnHide.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip.SetToolTip(this.btnHide, "Згорнути");
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // pnlFormMenu
            // 
            this.pnlFormMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFormMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlFormMenu.Controls.Add(this.btnRefresh);
            this.pnlFormMenu.Controls.Add(this.btnSave);
            this.pnlFormMenu.Controls.Add(this.btnSightOut);
            this.pnlFormMenu.Controls.Add(this.btnEdit);
            this.pnlFormMenu.Controls.Add(this.btnSettings);
            this.pnlFormMenu.Controls.Add(this.btnDelete);
            this.pnlFormMenu.Controls.Add(this.btnAdd);
            this.pnlFormMenu.Controls.Add(this.pctBoxAppImg);
            this.pnlFormMenu.Location = new System.Drawing.Point(0, -1);
            this.pnlFormMenu.Name = "pnlFormMenu";
            this.pnlFormMenu.Size = new System.Drawing.Size(40, 551);
            this.pnlFormMenu.TabIndex = 88;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(0, 186);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "⟳";
            this.toolTip.SetToolTip(this.btnRefresh, "Оновити");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(0, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 3;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "🖪";
            this.toolTip.SetToolTip(this.btnSave, "Зберегти");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSightOut
            // 
            this.btnSightOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSightOut.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSightOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSightOut.FlatAppearance.BorderSize = 0;
            this.btnSightOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSightOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSightOut.ForeColor = System.Drawing.Color.White;
            this.btnSightOut.Location = new System.Drawing.Point(0, 454);
            this.btnSightOut.Name = "btnSightOut";
            this.btnSightOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSightOut.Size = new System.Drawing.Size(40, 47);
            this.btnSightOut.TabIndex = 5;
            this.btnSightOut.TabStop = false;
            this.btnSightOut.Text = "⎗";
            this.toolTip.SetToolTip(this.btnSightOut, "Завершити роботу");
            this.btnSightOut.UseVisualStyleBackColor = false;
            this.btnSightOut.Click += new System.EventHandler(this.btnSightOut_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(0, 66);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.TabStop = false;
            this.btnEdit.Text = "✎";
            this.toolTip.SetToolTip(this.btnEdit, "Редагувати");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettings.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 504);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSettings.Size = new System.Drawing.Size(40, 47);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "⛯";
            this.toolTip.SetToolTip(this.btnSettings, "Налаштування");
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(0, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "✕";
            this.toolTip.SetToolTip(this.btnDelete, "Видалити");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(0, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.toolTip.SetToolTip(this.btnAdd, "Додати");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pctBoxAppImg
            // 
            this.pctBoxAppImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pctBoxAppImg.Location = new System.Drawing.Point(12, 5);
            this.pctBoxAppImg.Name = "pctBoxAppImg";
            this.pctBoxAppImg.Size = new System.Drawing.Size(18, 18);
            this.pctBoxAppImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxAppImg.TabIndex = 14;
            this.pctBoxAppImg.TabStop = false;
            this.toolTip.SetToolTip(this.pctBoxAppImg, "Огляд інвентаря");
            // 
            // btnChooseDataBase
            // 
            this.btnChooseDataBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChooseDataBase.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChooseDataBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChooseDataBase.FlatAppearance.BorderSize = 0;
            this.btnChooseDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseDataBase.ForeColor = System.Drawing.Color.White;
            this.btnChooseDataBase.Location = new System.Drawing.Point(479, 228);
            this.btnChooseDataBase.Name = "btnChooseDataBase";
            this.btnChooseDataBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChooseDataBase.Size = new System.Drawing.Size(168, 34);
            this.btnChooseDataBase.TabIndex = 16;
            this.btnChooseDataBase.TabStop = false;
            this.btnChooseDataBase.Text = "Оберіть базу даних";
            this.btnChooseDataBase.UseVisualStyleBackColor = false;
            this.btnChooseDataBase.Click += new System.EventHandler(this.btnChooseDataBase_Click);
            // 
            // listItems
            // 
            this.listItems.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnItemNum,
            this.columnItemName,
            this.columnSerialNumber,
            this.columnPrice,
            this.columnTotalPrice,
            this.columnExists,
            this.columnCount,
            this.columnItemType,
            this.columnEqDate,
            this.columnExDate});
            this.listItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.listItems.Depth = 0;
            this.listItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.listItems.FullRowSelect = true;
            this.listItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listItems.HideSelection = false;
            this.listItems.Location = new System.Drawing.Point(39, 24);
            this.listItems.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listItems.MouseState = MaterialSkin.MouseState.OUT;
            this.listItems.MultiSelect = false;
            this.listItems.Name = "listItems";
            this.listItems.OwnerDraw = true;
            this.listItems.ShowGroups = false;
            this.listItems.Size = new System.Drawing.Size(1108, 538);
            this.listItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listItems.TabIndex = 89;
            this.listItems.TabStop = false;
            this.listItems.UseCompatibleStateImageBehavior = false;
            this.listItems.View = System.Windows.Forms.View.Details;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.listItems_SelectedIndexChanged);
            this.listItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listItems_KeyDown);
            this.listItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listItems_MouseDown);
            // 
            // columnItemNum
            // 
            this.columnItemNum.Text = "№";
            this.columnItemNum.Width = 70;
            // 
            // columnItemName
            // 
            this.columnItemName.Text = "";
            this.columnItemName.Width = 176;
            // 
            // columnSerialNumber
            // 
            this.columnSerialNumber.Text = "";
            this.columnSerialNumber.Width = 160;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Ціна/шт";
            this.columnPrice.Width = 153;
            // 
            // columnTotalPrice
            // 
            this.columnTotalPrice.Text = "Сума";
            this.columnTotalPrice.Width = 140;
            // 
            // columnExists
            // 
            this.columnExists.Text = "";
            this.columnExists.Width = 140;
            // 
            // columnCount
            // 
            this.columnCount.Text = "Кількість";
            this.columnCount.Width = 123;
            // 
            // columnItemType
            // 
            this.columnItemType.Text = "";
            this.columnItemType.Width = 200;
            // 
            // columnEqDate
            // 
            this.columnEqDate.Width = 0;
            // 
            // columnExDate
            // 
            this.columnExDate.Width = 0;
            // 
            // pnlListHeader
            // 
            this.pnlListHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListHeader.Controls.Add(this.txtItemType);
            this.pnlListHeader.Controls.Add(this.lblItemCount);
            this.pnlListHeader.Controls.Add(this.lblItemTotalPrice);
            this.pnlListHeader.Controls.Add(this.lblItemPrice);
            this.pnlListHeader.Controls.Add(this.lblNum);
            this.pnlListHeader.Controls.Add(this.txtItemExists);
            this.pnlListHeader.Controls.Add(this.txtItemSerialNum);
            this.pnlListHeader.Controls.Add(this.txtItemName);
            this.pnlListHeader.Location = new System.Drawing.Point(39, 24);
            this.pnlListHeader.Name = "pnlListHeader";
            this.pnlListHeader.Size = new System.Drawing.Size(1107, 41);
            this.pnlListHeader.TabIndex = 91;
            // 
            // txtItemType
            // 
            this.txtItemType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemType.BackColor = System.Drawing.Color.White;
            this.txtItemType.Depth = 0;
            this.txtItemType.Hint = "Тип";
            this.txtItemType.Location = new System.Drawing.Point(976, 10);
            this.txtItemType.MaxLength = 100;
            this.txtItemType.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.PasswordChar = '\0';
            this.txtItemType.SelectedText = "";
            this.txtItemType.SelectionLength = 0;
            this.txtItemType.SelectionStart = 0;
            this.txtItemType.Size = new System.Drawing.Size(116, 23);
            this.txtItemType.TabIndex = 101;
            this.txtItemType.TabStop = false;
            this.txtItemType.UseSystemPasswordChar = false;
            this.txtItemType.Click += new System.EventHandler(this.txtItemType_Click);
            this.txtItemType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemType_KeyDown);
            // 
            // lblItemCount
            // 
            this.lblItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Depth = 0;
            this.lblItemCount.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemCount.Location = new System.Drawing.Point(849, 10);
            this.lblItemCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(75, 19);
            this.lblItemCount.TabIndex = 99;
            this.lblItemCount.Text = "Кількість";
            // 
            // lblItemTotalPrice
            // 
            this.lblItemTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemTotalPrice.AutoSize = true;
            this.lblItemTotalPrice.Depth = 0;
            this.lblItemTotalPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblItemTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemTotalPrice.Location = new System.Drawing.Point(570, 11);
            this.lblItemTotalPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemTotalPrice.Name = "lblItemTotalPrice";
            this.lblItemTotalPrice.Size = new System.Drawing.Size(45, 19);
            this.lblItemTotalPrice.TabIndex = 98;
            this.lblItemTotalPrice.Text = "Сума";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Depth = 0;
            this.lblItemPrice.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblItemPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemPrice.Location = new System.Drawing.Point(417, 10);
            this.lblItemPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(66, 19);
            this.lblItemPrice.TabIndex = 97;
            this.lblItemPrice.Text = "Ціна/шт";
            // 
            // lblNum
            // 
            this.lblNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNum.AutoSize = true;
            this.lblNum.Depth = 0;
            this.lblNum.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNum.Location = new System.Drawing.Point(12, 11);
            this.lblNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(64, 19);
            this.lblNum.TabIndex = 92;
            this.lblNum.Text = "№          ";
            // 
            // txtItemExists
            // 
            this.txtItemExists.BackColor = System.Drawing.Color.White;
            this.txtItemExists.Depth = 0;
            this.txtItemExists.Hint = "Наявність";
            this.txtItemExists.Location = new System.Drawing.Point(713, 10);
            this.txtItemExists.MaxLength = 3;
            this.txtItemExists.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemExists.Name = "txtItemExists";
            this.txtItemExists.PasswordChar = '\0';
            this.txtItemExists.SelectedText = "";
            this.txtItemExists.SelectionLength = 0;
            this.txtItemExists.SelectionStart = 0;
            this.txtItemExists.Size = new System.Drawing.Size(117, 23);
            this.txtItemExists.TabIndex = 2;
            this.txtItemExists.TabStop = false;
            this.txtItemExists.UseSystemPasswordChar = false;
            this.txtItemExists.Click += new System.EventHandler(this.txtItemExists_Click);
            this.txtItemExists.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemExists_KeyDown);
            this.txtItemExists.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemExists_KeyPress);
            // 
            // txtItemSerialNum
            // 
            this.txtItemSerialNum.BackColor = System.Drawing.Color.White;
            this.txtItemSerialNum.Depth = 0;
            this.txtItemSerialNum.Hint = "Серійний код";
            this.txtItemSerialNum.Location = new System.Drawing.Point(260, 10);
            this.txtItemSerialNum.MaxLength = 8;
            this.txtItemSerialNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemSerialNum.Name = "txtItemSerialNum";
            this.txtItemSerialNum.PasswordChar = '\0';
            this.txtItemSerialNum.SelectedText = "";
            this.txtItemSerialNum.SelectionLength = 0;
            this.txtItemSerialNum.SelectionStart = 0;
            this.txtItemSerialNum.Size = new System.Drawing.Size(135, 23);
            this.txtItemSerialNum.TabIndex = 1;
            this.txtItemSerialNum.TabStop = false;
            this.txtItemSerialNum.UseSystemPasswordChar = false;
            this.txtItemSerialNum.Click += new System.EventHandler(this.txtItemSerialNum_Click);
            this.txtItemSerialNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemSerialNum_KeyDown);
            this.txtItemSerialNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemSerialNum_KeyPress);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.Depth = 0;
            this.txtItemName.Hint = "Назва";
            this.txtItemName.Location = new System.Drawing.Point(84, 10);
            this.txtItemName.MaxLength = 100;
            this.txtItemName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.SelectedText = "";
            this.txtItemName.SelectionLength = 0;
            this.txtItemName.SelectionStart = 0;
            this.txtItemName.Size = new System.Drawing.Size(151, 23);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.TabStop = false;
            this.txtItemName.UseSystemPasswordChar = false;
            this.txtItemName.Click += new System.EventHandler(this.txtItemName_Click);
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyDown);
            // 
            // pnlStartPage
            // 
            this.pnlStartPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStartPage.Controls.Add(this.lnkTutorial);
            this.pnlStartPage.Controls.Add(this.lblTutorial);
            this.pnlStartPage.Controls.Add(this.btnChooseDataBase);
            this.pnlStartPage.Controls.Add(this.lblGreetings);
            this.pnlStartPage.Location = new System.Drawing.Point(38, 23);
            this.pnlStartPage.Name = "pnlStartPage";
            this.pnlStartPage.Size = new System.Drawing.Size(1109, 527);
            this.pnlStartPage.TabIndex = 96;
            // 
            // lnkTutorial
            // 
            this.lnkTutorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkTutorial.AutoSize = true;
            this.lnkTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTutorial.Location = new System.Drawing.Point(839, 275);
            this.lnkTutorial.Name = "lnkTutorial";
            this.lnkTutorial.Size = new System.Drawing.Size(29, 18);
            this.lnkTutorial.TabIndex = 18;
            this.lnkTutorial.TabStop = true;
            this.lnkTutorial.Text = "тут";
            this.lnkTutorial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTutorial_LinkClicked);
            // 
            // lblTutorial
            // 
            this.lblTutorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTutorial.AutoSize = true;
            this.lblTutorial.Depth = 0;
            this.lblTutorial.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTutorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTutorial.Location = new System.Drawing.Point(227, 275);
            this.lblTutorial.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(650, 19);
            this.lblTutorial.TabIndex = 17;
            this.lblTutorial.Text = "Якщо у вас відсутня потрібна база даних Ви можете створити її власноруч дивитись " +
    "       .";
            // 
            // lblGreetings
            // 
            this.lblGreetings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGreetings.AutoSize = true;
            this.lblGreetings.Depth = 0;
            this.lblGreetings.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGreetings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGreetings.Location = new System.Drawing.Point(263, 195);
            this.lblGreetings.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGreetings.Name = "lblGreetings";
            this.lblGreetings.Size = new System.Drawing.Size(579, 19);
            this.lblGreetings.TabIndex = 0;
            this.lblGreetings.Text = "Для початку натисніть на кнопку нище та оберить базу даних Вашого інвентаря";
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 550);
            this.Controls.Add(this.pnlStartPage);
            this.Controls.Add(this.pnlListHeader);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.pnlFormMenu);
            this.Controls.Add(this.pnlFormBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "%title%";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            this.pnlFormMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxAppImg)).EndInit();
            this.pnlListHeader.ResumeLayout(false);
            this.pnlListHeader.PerformLayout();
            this.pnlStartPage.ResumeLayout(false);
            this.pnlStartPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlFormMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pctBoxAppImg;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnSettings;
        private MaterialSkin.Controls.MaterialListView listItems;
        private System.Windows.Forms.ColumnHeader columnItemNum;
        private System.Windows.Forms.ColumnHeader columnItemName;
        private System.Windows.Forms.ColumnHeader columnSerialNumber;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnTotalPrice;
        private System.Windows.Forms.ColumnHeader columnExists;
        private System.Windows.Forms.ColumnHeader columnCount;
        private System.Windows.Forms.Button btnSightOut;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlListHeader;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemExists;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemName;
        private MaterialSkin.Controls.MaterialLabel lblNum;
        private MaterialSkin.Controls.MaterialLabel lblItemPrice;
        private MaterialSkin.Controls.MaterialLabel lblItemTotalPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemSerialNum;
        private MaterialSkin.Controls.MaterialLabel lblItemCount;
        private System.Windows.Forms.ColumnHeader columnItemType;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemType;
        private System.Windows.Forms.Panel pnlStartPage;
        private MaterialSkin.Controls.MaterialLabel lblGreetings;
        private System.Windows.Forms.Button btnChooseDataBase;
        private System.Windows.Forms.Timer timerR;
        private System.Windows.Forms.Timer timerG;
        private System.Windows.Forms.Timer timerB;
        private MaterialSkin.Controls.MaterialLabel lblTutorial;
        private System.Windows.Forms.LinkLabel lnkTutorial;
        private System.Windows.Forms.ColumnHeader columnEqDate;
        private System.Windows.Forms.ColumnHeader columnExDate;
    }
}

