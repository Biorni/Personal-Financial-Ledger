namespace Fedha.Forms
{
    partial class frmAddIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddIncome));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.txtFrom = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label21 = new System.Windows.Forms.Label();
            this.bunifuSeparator13 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtAccount = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtCategory = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtDesc = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtCode = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtAmount = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnAddIncome = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.closeForm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.AcceptsReturn = false;
            this.txtFrom.AcceptsTab = false;
            this.txtFrom.AnimationSpeed = 220;
            this.txtFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFrom.BackColor = System.Drawing.Color.Transparent;
            this.txtFrom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtFrom.BackgroundImage")));
            this.txtFrom.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            this.txtFrom.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtFrom.BorderColorHover = System.Drawing.Color.MediumSeaGreen;
            this.txtFrom.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtFrom.BorderRadius = 35;
            this.txtFrom.BorderThickness = 1;
            this.txtFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtFrom.DefaultText = "";
            this.txtFrom.FillColor = System.Drawing.Color.White;
            this.txtFrom.HideSelection = true;
            this.txtFrom.IconLeft = null;
            this.txtFrom.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.IconPadding = 10;
            this.txtFrom.IconRight = null;
            this.txtFrom.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFrom.Lines = new string[0];
            this.txtFrom.Location = new System.Drawing.Point(36, 98);
            this.txtFrom.MaxLength = 32767;
            this.txtFrom.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtFrom.Modified = false;
            this.txtFrom.Multiline = false;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PasswordChar = '\0';
            this.txtFrom.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFrom.PlaceholderText = "Payment From";
            this.txtFrom.ReadOnly = false;
            this.txtFrom.SelectedText = "";
            this.txtFrom.SelectionLength = 0;
            this.txtFrom.SelectionStart = 0;
            this.txtFrom.ShortcutsEnabled = true;
            this.txtFrom.Size = new System.Drawing.Size(453, 35);
            this.txtFrom.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtFrom.TabIndex = 2;
            this.txtFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFrom.TextMarginLeft = 5;
            this.txtFrom.TextMarginTop = 0;
            this.txtFrom.TextPlaceholder = "Payment From";
            this.txtFrom.UseSystemPasswordChar = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(490, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(31, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 23);
            this.label21.TabIndex = 19;
            this.label21.Text = "Add Income";
            // 
            // bunifuSeparator13
            // 
            this.bunifuSeparator13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator13.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator13.LineThickness = 1;
            this.bunifuSeparator13.Location = new System.Drawing.Point(23, 57);
            this.bunifuSeparator13.Name = "bunifuSeparator13";
            this.bunifuSeparator13.Size = new System.Drawing.Size(497, 35);
            this.bunifuSeparator13.TabIndex = 20;
            this.bunifuSeparator13.Transparency = 255;
            this.bunifuSeparator13.Vertical = false;
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
            this.txtAccount.Location = new System.Drawing.Point(36, 212);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.NomalColor = System.Drawing.Color.White;
            this.txtAccount.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAccount.selectedIndex = 0;
            this.txtAccount.Size = new System.Drawing.Size(228, 35);
            this.txtAccount.TabIndex = 21;
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.Transparent;
            this.txtCategory.BorderRadius = 3;
            this.txtCategory.DisabledColor = System.Drawing.Color.Gray;
            this.txtCategory.ForeColor = System.Drawing.Color.DimGray;
            this.txtCategory.items = new string[] {
        "Salary",
        "Commission"};
            this.txtCategory.Location = new System.Drawing.Point(270, 212);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.NomalColor = System.Drawing.Color.White;
            this.txtCategory.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCategory.selectedIndex = 0;
            this.txtCategory.Size = new System.Drawing.Size(218, 35);
            this.txtCategory.TabIndex = 22;
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
            this.txtDesc.Location = new System.Drawing.Point(36, 155);
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
            this.txtDesc.TabIndex = 23;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesc.TextMarginLeft = 5;
            this.txtDesc.TextMarginTop = 0;
            this.txtDesc.TextPlaceholder = "Payment Description";
            this.txtDesc.UseSystemPasswordChar = false;
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
            this.txtCode.Location = new System.Drawing.Point(270, 276);
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
            this.txtCode.Size = new System.Drawing.Size(218, 35);
            this.txtCode.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtCode.TabIndex = 24;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCode.TextMarginLeft = 5;
            this.txtCode.TextMarginTop = 0;
            this.txtCode.TextPlaceholder = "Transaction ID/Code";
            this.txtCode.UseSystemPasswordChar = false;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
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
            this.txtAmount.Location = new System.Drawing.Point(270, 327);
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
            this.txtAmount.TabIndex = 25;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TextMarginLeft = 5;
            this.txtAmount.TextMarginTop = 0;
            this.txtAmount.TextPlaceholder = "Amount";
            this.txtAmount.UseSystemPasswordChar = false;
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddIncome.AnimationSpeed = 220;
            this.btnAddIncome.BackColor = System.Drawing.Color.Transparent;
            this.btnAddIncome.BackColor1 = System.Drawing.Color.White;
            this.btnAddIncome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddIncome.BackgroundImage")));
            this.btnAddIncome.ButtonText = "Add Transaction";
            this.btnAddIncome.ButtonTextMarginLeft = 0;
            this.btnAddIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIncome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddIncome.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddIncome.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAddIncome.DisabledForecolor = System.Drawing.Color.White;
            this.btnAddIncome.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAddIncome.ForeColor = System.Drawing.Color.Gray;
            this.btnAddIncome.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIncome.IconPadding = 10;
            this.btnAddIncome.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddIncome.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            this.btnAddIncome.IdleBorderRadius = 30;
            this.btnAddIncome.IdleBorderThickness = 1;
            this.btnAddIncome.IdleFillColor = System.Drawing.Color.White;
            this.btnAddIncome.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAddIncome.IdleIconLeftImage")));
            this.btnAddIncome.IdleIconRightImage = null;
            this.btnAddIncome.IndicateFocus = true;
            this.btnAddIncome.Location = new System.Drawing.Point(322, 383);
            this.btnAddIncome.Name = "btnAddIncome";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(69)))));
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(69)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAddIncome.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnAddIncome.OnPressedState = stateProperties2;
            this.btnAddIncome.Size = new System.Drawing.Size(167, 35);
            this.btnAddIncome.TabIndex = 26;
            this.btnAddIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddIncome.TextMarginLeft = 0;
            this.btnAddIncome.Click += new System.EventHandler(this.BtnAddIncome_Click);
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
            this.txtDate.Location = new System.Drawing.Point(37, 276);
            this.txtDate.MinimumSize = new System.Drawing.Size(227, 32);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(227, 32);
            this.txtDate.TabIndex = 27;
            // 
            // closeForm
            // 
            this.closeForm.Interval = 2500;
            this.closeForm.Tick += new System.EventHandler(this.CloseForm_Tick);
            // 
            // frmAddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(532, 447);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnAddIncome);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.bunifuSeparator13);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtFrom;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator13;
        private Bunifu.Framework.UI.BunifuDropdown txtAccount;
        private Bunifu.Framework.UI.BunifuDropdown txtCategory;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtDesc;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtCode;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAmount;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddIncome;
        private Bunifu.UI.WinForms.BunifuDatePicker txtDate;
        private System.Windows.Forms.Timer closeForm;
    }
}