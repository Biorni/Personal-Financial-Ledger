
namespace Fedha.Forms
{
    partial class frmAddWishlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddWishlist));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.txtDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnAddItem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtAmount = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtCode = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtDesc = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtAccount = new Bunifu.Framework.UI.BunifuDropdown();
            this.label21 = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtFrom = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuSeparator13 = new Bunifu.Framework.UI.BunifuSeparator();
            this.closeForm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
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
            this.txtDate.Location = new System.Drawing.Point(264, 217);
            this.txtDate.MinimumSize = new System.Drawing.Size(227, 32);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(227, 32);
            this.txtDate.TabIndex = 38;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.AnimationSpeed = 220;
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.BackColor1 = System.Drawing.Color.White;
            this.btnAddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.BackgroundImage")));
            this.btnAddItem.ButtonText = "Add Item";
            this.btnAddItem.ButtonTextMarginLeft = 0;
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddItem.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAddItem.DisabledForecolor = System.Drawing.Color.White;
            this.btnAddItem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAddItem.ForeColor = System.Drawing.Color.Gray;
            this.btnAddItem.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.IconPadding = 10;
            this.btnAddItem.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            this.btnAddItem.IdleBorderRadius = 30;
            this.btnAddItem.IdleBorderThickness = 1;
            this.btnAddItem.IdleFillColor = System.Drawing.Color.White;
            this.btnAddItem.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.IdleIconLeftImage")));
            this.btnAddItem.IdleIconRightImage = null;
            this.btnAddItem.IndicateFocus = true;
            this.btnAddItem.Location = new System.Drawing.Point(316, 334);
            this.btnAddItem.Name = "btnAddItem";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(69)))));
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(69)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnAddItem.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(177)))), ((int)(((byte)(73)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnAddItem.OnPressedState = stateProperties2;
            this.btnAddItem.Size = new System.Drawing.Size(167, 35);
            this.btnAddItem.TabIndex = 37;
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddItem.TextMarginLeft = 0;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
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
            this.txtAmount.Location = new System.Drawing.Point(272, 268);
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
            this.txtAmount.TabIndex = 36;
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
            this.txtCode.Location = new System.Drawing.Point(29, 268);
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
            this.txtCode.TabIndex = 35;
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
            this.txtDesc.Location = new System.Drawing.Point(30, 157);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtDesc.Modified = false;
            this.txtDesc.Multiline = false;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDesc.PlaceholderText = "Item Description";
            this.txtDesc.ReadOnly = false;
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.ShortcutsEnabled = true;
            this.txtDesc.Size = new System.Drawing.Size(453, 35);
            this.txtDesc.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtDesc.TabIndex = 34;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDesc.TextMarginLeft = 5;
            this.txtDesc.TextMarginTop = 0;
            this.txtDesc.TextPlaceholder = "Item Description";
            this.txtDesc.UseSystemPasswordChar = false;
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
            this.txtAccount.Location = new System.Drawing.Point(30, 214);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.NomalColor = System.Drawing.Color.White;
            this.txtAccount.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAccount.selectedIndex = 0;
            this.txtAccount.Size = new System.Drawing.Size(228, 35);
            this.txtAccount.TabIndex = 32;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(25, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 23);
            this.label21.TabIndex = 30;
            this.label21.Text = "Add Item";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(484, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 29;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.txtFrom.Location = new System.Drawing.Point(30, 100);
            this.txtFrom.MaxLength = 32767;
            this.txtFrom.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtFrom.Modified = false;
            this.txtFrom.Multiline = false;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.PasswordChar = '\0';
            this.txtFrom.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFrom.PlaceholderText = "Item Name";
            this.txtFrom.ReadOnly = false;
            this.txtFrom.SelectedText = "";
            this.txtFrom.SelectionLength = 0;
            this.txtFrom.SelectionStart = 0;
            this.txtFrom.ShortcutsEnabled = true;
            this.txtFrom.Size = new System.Drawing.Size(453, 35);
            this.txtFrom.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtFrom.TabIndex = 28;
            this.txtFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFrom.TextMarginLeft = 5;
            this.txtFrom.TextMarginTop = 0;
            this.txtFrom.TextPlaceholder = "Item Name";
            this.txtFrom.UseSystemPasswordChar = false;
            // 
            // bunifuSeparator13
            // 
            this.bunifuSeparator13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator13.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator13.LineThickness = 1;
            this.bunifuSeparator13.Location = new System.Drawing.Point(17, 59);
            this.bunifuSeparator13.Name = "bunifuSeparator13";
            this.bunifuSeparator13.Size = new System.Drawing.Size(497, 35);
            this.bunifuSeparator13.TabIndex = 31;
            this.bunifuSeparator13.Transparency = 255;
            this.bunifuSeparator13.Vertical = false;
            // 
            // closeForm
            // 
            this.closeForm.Interval = 2500;
            // 
            // frmAddWishlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(531, 394);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.bunifuSeparator13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddWishlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDatePicker txtDate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddItem;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAmount;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtCode;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtDesc;
        private Bunifu.Framework.UI.BunifuDropdown txtAccount;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtFrom;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator13;
        private System.Windows.Forms.Timer closeForm;
    }
}