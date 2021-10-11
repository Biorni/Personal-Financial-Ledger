namespace Fedha.Forms
{
    partial class frmAddExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddExpenses));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtAmount = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtCode = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtDesc = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtAccount = new Bunifu.Framework.UI.BunifuDropdown();
            this.label21 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtTo = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuSeparator13 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtTcost = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.closeForm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.AnimationSpeed = 220;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Add Transaction";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAdd.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAdd.DisabledForecolor = System.Drawing.Color.White;
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAdd.ForeColor = System.Drawing.Color.Gray;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            this.btnAdd.IdleBorderRadius = 30;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.White;
            this.btnAdd.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.IdleIconLeftImage")));
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = true;
            this.btnAdd.Location = new System.Drawing.Point(335, 397);
            this.btnAdd.Name = "btnAdd";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(69)))));
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(69)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAdd.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnAdd.OnPressedState = stateProperties2;
            this.btnAdd.Size = new System.Drawing.Size(173, 35);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.AcceptsReturn = false;
            this.txtAmount.AcceptsTab = false;
            this.txtAmount.AnimationSpeed = 220;
            this.txtAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtAmount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAmount.BackgroundImage")));
            this.txtAmount.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            this.txtAmount.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAmount.BorderColorHover = System.Drawing.Color.MediumSeaGreen;
            this.txtAmount.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAmount.BorderRadius = 35;
            this.txtAmount.BorderThickness = 1;
            this.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtAmount.DefaultText = "";
            this.txtAmount.FillColor = System.Drawing.Color.White;
            this.txtAmount.HideSelection = true;
            this.txtAmount.IconLeft = null;
            this.txtAmount.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.IconPadding = 10;
            this.txtAmount.IconRight = null;
            this.txtAmount.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Lines = new string[0];
            this.txtAmount.Location = new System.Drawing.Point(289, 333);
            this.txtAmount.MaxLength = 32767;
            this.txtAmount.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtAmount.Modified = false;
            this.txtAmount.Multiline = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAmount.PlaceholderText = "Amount";
            this.txtAmount.ReadOnly = false;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(219, 35);
            this.txtAmount.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtAmount.TabIndex = 35;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TextMarginLeft = 5;
            this.txtAmount.TextMarginTop = 0;
            this.txtAmount.TextPlaceholder = "Amount";
            this.txtAmount.UseSystemPasswordChar = false;
            // 
            // txtCode
            // 
            this.txtCode.AcceptsReturn = false;
            this.txtCode.AcceptsTab = false;
            this.txtCode.AnimationSpeed = 220;
            this.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCode.BackColor = System.Drawing.Color.Transparent;
            this.txtCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtCode.BackgroundImage")));
            this.txtCode.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            this.txtCode.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtCode.BorderColorHover = System.Drawing.Color.MediumSeaGreen;
            this.txtCode.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtCode.BorderRadius = 35;
            this.txtCode.BorderThickness = 1;
            this.txtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtCode.DefaultText = "";
            this.txtCode.FillColor = System.Drawing.Color.White;
            this.txtCode.HideSelection = true;
            this.txtCode.IconLeft = null;
            this.txtCode.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.IconPadding = 10;
            this.txtCode.IconRight = null;
            this.txtCode.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(290, 278);
            this.txtCode.MaxLength = 32767;
            this.txtCode.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtCode.Modified = false;
            this.txtCode.Multiline = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCode.PlaceholderText = "Transaction ID/Code";
            this.txtCode.ReadOnly = false;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(219, 35);
            this.txtCode.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtCode.TabIndex = 34;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCode.TextMarginLeft = 5;
            this.txtCode.TextMarginTop = 0;
            this.txtCode.TextPlaceholder = "Transaction ID/Code";
            this.txtCode.UseSystemPasswordChar = false;
            // 
            // txtDesc
            // 
            this.txtDesc.AcceptsReturn = false;
            this.txtDesc.AcceptsTab = false;
            this.txtDesc.AnimationSpeed = 220;
            this.txtDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDesc.BackColor = System.Drawing.Color.Transparent;
            this.txtDesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDesc.BackgroundImage")));
            this.txtDesc.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            this.txtDesc.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtDesc.BorderColorHover = System.Drawing.Color.MediumSeaGreen;
            this.txtDesc.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDesc.BorderRadius = 35;
            this.txtDesc.BorderThickness = 1;
            this.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtDesc.DefaultText = "";
            this.txtDesc.FillColor = System.Drawing.Color.White;
            this.txtDesc.HideSelection = true;
            this.txtDesc.IconLeft = null;
            this.txtDesc.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.IconPadding = 10;
            this.txtDesc.IconRight = null;
            this.txtDesc.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDesc.Lines = new string[0];
            this.txtDesc.Location = new System.Drawing.Point(56, 160);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtDesc.Modified = false;
            this.txtDesc.Multiline = false;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDesc.PlaceholderText = "Payment Description";
            this.txtDesc.ReadOnly = false;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(453, 35);
            this.txtDesc.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtDesc.TabIndex = 33;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesc.TextMarginLeft = 5;
            this.txtDesc.TextMarginTop = 0;
            this.txtDesc.TextPlaceholder = "Payment Description";
            this.txtDesc.UseSystemPasswordChar = false;
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.Transparent;
            this.txtCategory.BorderRadius = 3;
            this.txtCategory.DisabledColor = System.Drawing.Color.Gray;
            this.txtCategory.ForeColor = System.Drawing.Color.DimGray;
            this.txtCategory.items = new string[] {
        "Rent",
        "Internet"};
            this.txtCategory.Location = new System.Drawing.Point(290, 215);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.NomalColor = System.Drawing.Color.White;
            this.txtCategory.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCategory.selectedIndex = 0;
            this.txtCategory.Size = new System.Drawing.Size(218, 35);
            this.txtCategory.TabIndex = 32;
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.Transparent;
            this.txtAccount.BorderRadius = 3;
            this.txtAccount.DisabledColor = System.Drawing.Color.Gray;
            this.txtAccount.ForeColor = System.Drawing.Color.DimGray;
            this.txtAccount.items = new string[] {
        "Cash",
        "Bank"};
            this.txtAccount.Location = new System.Drawing.Point(56, 215);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.NomalColor = System.Drawing.Color.White;
            this.txtAccount.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAccount.selectedIndex = 0;
            this.txtAccount.Size = new System.Drawing.Size(228, 35);
            this.txtAccount.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(51, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 23);
            this.label21.TabIndex = 29;
            this.label21.Text = "Add Expense";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(510, 14);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 29);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 28;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // txtTo
            // 
            this.txtTo.AcceptsReturn = false;
            this.txtTo.AcceptsTab = false;
            this.txtTo.AnimationSpeed = 220;
            this.txtTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTo.BackColor = System.Drawing.Color.Transparent;
            this.txtTo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTo.BackgroundImage")));
            this.txtTo.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            this.txtTo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtTo.BorderColorHover = System.Drawing.Color.MediumSeaGreen;
            this.txtTo.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTo.BorderRadius = 35;
            this.txtTo.BorderThickness = 1;
            this.txtTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtTo.DefaultText = "";
            this.txtTo.FillColor = System.Drawing.Color.White;
            this.txtTo.HideSelection = true;
            this.txtTo.IconLeft = null;
            this.txtTo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.IconPadding = 10;
            this.txtTo.IconRight = null;
            this.txtTo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.Lines = new string[0];
            this.txtTo.Location = new System.Drawing.Point(55, 110);
            this.txtTo.MaxLength = 32767;
            this.txtTo.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtTo.Modified = false;
            this.txtTo.Multiline = false;
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTo.PlaceholderText = "Payment To";
            this.txtTo.ReadOnly = false;
            this.txtTo.SelectedText = "";
            this.txtTo.SelectionLength = 0;
            this.txtTo.SelectionStart = 0;
            this.txtTo.ShortcutsEnabled = true;
            this.txtTo.Size = new System.Drawing.Size(453, 35);
            this.txtTo.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtTo.TabIndex = 27;
            this.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTo.TextMarginLeft = 5;
            this.txtTo.TextMarginTop = 0;
            this.txtTo.TextPlaceholder = "Payment To";
            this.txtTo.UseSystemPasswordChar = false;
            // 
            // bunifuSeparator13
            // 
            this.bunifuSeparator13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator13.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator13.LineThickness = 1;
            this.bunifuSeparator13.Location = new System.Drawing.Point(43, 59);
            this.bunifuSeparator13.Name = "bunifuSeparator13";
            this.bunifuSeparator13.Size = new System.Drawing.Size(497, 35);
            this.bunifuSeparator13.TabIndex = 30;
            this.bunifuSeparator13.Transparency = 255;
            this.bunifuSeparator13.Vertical = false;
            // 
            // txtTcost
            // 
            this.txtTcost.AcceptsReturn = false;
            this.txtTcost.AcceptsTab = false;
            this.txtTcost.AnimationSpeed = 220;
            this.txtTcost.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTcost.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTcost.BackColor = System.Drawing.Color.Transparent;
            this.txtTcost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTcost.BackgroundImage")));
            this.txtTcost.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            this.txtTcost.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtTcost.BorderColorHover = System.Drawing.Color.MediumSeaGreen;
            this.txtTcost.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTcost.BorderRadius = 35;
            this.txtTcost.BorderThickness = 1;
            this.txtTcost.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTcost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTcost.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtTcost.DefaultText = "";
            this.txtTcost.FillColor = System.Drawing.Color.White;
            this.txtTcost.HideSelection = true;
            this.txtTcost.IconLeft = null;
            this.txtTcost.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTcost.IconPadding = 10;
            this.txtTcost.IconRight = null;
            this.txtTcost.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTcost.Lines = new string[0];
            this.txtTcost.Location = new System.Drawing.Point(55, 333);
            this.txtTcost.MaxLength = 32767;
            this.txtTcost.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtTcost.Modified = false;
            this.txtTcost.Multiline = false;
            this.txtTcost.Name = "txtTcost";
            this.txtTcost.PasswordChar = '\0';
            this.txtTcost.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTcost.PlaceholderText = "Transaction Cost";
            this.txtTcost.ReadOnly = false;
            this.txtTcost.SelectedText = "";
            this.txtTcost.SelectionLength = 0;
            this.txtTcost.SelectionStart = 0;
            this.txtTcost.ShortcutsEnabled = true;
            this.txtTcost.Size = new System.Drawing.Size(227, 35);
            this.txtTcost.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtTcost.TabIndex = 37;
            this.txtTcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTcost.TextMarginLeft = 5;
            this.txtTcost.TextMarginTop = 0;
            this.txtTcost.TextPlaceholder = "Transaction Cost";
            this.txtTcost.UseSystemPasswordChar = false;
            // 
            // txtDate
            // 
            this.txtDate.BorderRadius = 1;
            this.txtDate.Color = System.Drawing.Color.White;
            this.txtDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.txtDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.txtDate.DisabledColor = System.Drawing.Color.Gray;
            this.txtDate.DisplayWeekNumbers = false;
            this.txtDate.DPHeight = 0;
            this.txtDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txtDate.FillDatePicker = false;
            this.txtDate.ForeColor = System.Drawing.Color.DimGray;
            this.txtDate.Icon = ((System.Drawing.Image)(resources.GetObject("txtDate.Icon")));
            this.txtDate.IconColor = System.Drawing.Color.Gray;
            this.txtDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.txtDate.Location = new System.Drawing.Point(55, 278);
            this.txtDate.MinimumSize = new System.Drawing.Size(227, 32);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(227, 32);
            this.txtDate.TabIndex = 38;
            // 
            // closeForm
            // 
            this.closeForm.Interval = 2500;
            this.closeForm.Tick += new System.EventHandler(this.CloseForm_Tick);
            // 
            // frmAddExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(552, 474);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTcost);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.bunifuSeparator13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmAddExpenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAmount;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtCode;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtDesc;
        private Bunifu.Framework.UI.BunifuDropdown txtCategory;
        private Bunifu.Framework.UI.BunifuDropdown txtAccount;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtTo;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator13;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtTcost;
        private Bunifu.UI.WinForms.BunifuDatePicker txtDate;
        private System.Windows.Forms.Timer closeForm;
    }
}