namespace KEY_GENERATOR_FOR_LICENSE_KEY
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.activeCodeLabel = new System.Windows.Forms.Label();
			this.licenseKeyProducteLabel = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.buttonPaste = new System.Windows.Forms.Button();
			this.buttonCopy = new System.Windows.Forms.Button();
			this.selectLanguageComboBox = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.generateButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.activeCodeTextBox = new System.Windows.Forms.TextBox();
			this.licenseKeyTextBox = new System.Windows.Forms.TextBox();
			this.minimizedButton = new System.Windows.Forms.Button();
			this.dayTextBox = new System.Windows.Forms.TextBox();
			this.enterDayToExpireLabel = new System.Windows.Forms.Label();
			this.createDateLabel = new System.Windows.Forms.Label();
			this.expireDateLabel = new System.Windows.Forms.Label();
			this.createDateTextBox = new System.Windows.Forms.Label();
			this.expireDateTextBox = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// activeCodeLabel
			// 
			this.activeCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.activeCodeLabel.AutoSize = true;
			this.activeCodeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.activeCodeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.activeCodeLabel.Location = new System.Drawing.Point(74, 82);
			this.activeCodeLabel.Name = "activeCodeLabel";
			this.activeCodeLabel.Size = new System.Drawing.Size(69, 13);
			this.activeCodeLabel.TabIndex = 9;
			this.activeCodeLabel.Text = "Active Code:";
			// 
			// licenseKeyProducteLabel
			// 
			this.licenseKeyProducteLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.licenseKeyProducteLabel.AutoSize = true;
			this.licenseKeyProducteLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.licenseKeyProducteLabel.Location = new System.Drawing.Point(36, 117);
			this.licenseKeyProducteLabel.Name = "licenseKeyProducteLabel";
			this.licenseKeyProducteLabel.Size = new System.Drawing.Size(107, 13);
			this.licenseKeyProducteLabel.TabIndex = 10;
			this.licenseKeyProducteLabel.Text = "License Key Product:";
			// 
			// toolTip1
			// 
			this.toolTip1.AutomaticDelay = 10;
			this.toolTip1.AutoPopDelay = 3000;
			this.toolTip1.InitialDelay = 10;
			this.toolTip1.ReshowDelay = 10;
			this.toolTip1.ShowAlways = true;
			this.toolTip1.StripAmpersands = true;
			this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip1.ToolTipTitle = "Info";
			// 
			// buttonPaste
			// 
			this.buttonPaste.BackColor = System.Drawing.Color.Transparent;
			this.buttonPaste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPaste.BackgroundImage")));
			this.buttonPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonPaste.FlatAppearance.BorderSize = 0;
			this.buttonPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.buttonPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPaste.Location = new System.Drawing.Point(405, 76);
			this.buttonPaste.Name = "buttonPaste";
			this.buttonPaste.Size = new System.Drawing.Size(25, 25);
			this.buttonPaste.TabIndex = 4;
			this.toolTip1.SetToolTip(this.buttonPaste, "Paste to control");
			this.buttonPaste.UseVisualStyleBackColor = false;
			this.buttonPaste.Click += new System.EventHandler(this.ButtonPaste_Click);
			// 
			// buttonCopy
			// 
			this.buttonCopy.BackColor = System.Drawing.Color.Transparent;
			this.buttonCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCopy.BackgroundImage")));
			this.buttonCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonCopy.FlatAppearance.BorderSize = 0;
			this.buttonCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCopy.Location = new System.Drawing.Point(405, 111);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new System.Drawing.Size(25, 25);
			this.buttonCopy.TabIndex = 5;
			this.toolTip1.SetToolTip(this.buttonCopy, "Copy from control");
			this.buttonCopy.UseVisualStyleBackColor = false;
			this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
			// 
			// selectLanguageComboBox
			// 
			this.selectLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectLanguageComboBox.FormattingEnabled = true;
			this.selectLanguageComboBox.Items.AddRange(new object[] {
            "EN",
            "FA",
            "TR"});
			this.selectLanguageComboBox.Location = new System.Drawing.Point(500, 9);
			this.selectLanguageComboBox.Name = "selectLanguageComboBox";
			this.selectLanguageComboBox.Size = new System.Drawing.Size(43, 21);
			this.selectLanguageComboBox.TabIndex = 1;
			this.selectLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectLanguageComboBox_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.SlateBlue;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(548, 5);
			this.panel1.TabIndex = 0;
			// 
			// generateButton
			// 
			this.generateButton.Image = ((System.Drawing.Image)(resources.GetObject("generateButton.Image")));
			this.generateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.generateButton.Location = new System.Drawing.Point(44, 151);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(150, 35);
			this.generateButton.TabIndex = 6;
			this.generateButton.Text = "Generate &License";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
			this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.exitButton.Location = new System.Drawing.Point(200, 151);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(150, 35);
			this.exitButton.TabIndex = 7;
			this.exitButton.Text = "&Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
			this.clearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.clearButton.Location = new System.Drawing.Point(354, 151);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(150, 35);
			this.clearButton.TabIndex = 8;
			this.clearButton.Text = "&Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// activeCodeTextBox
			// 
			this.activeCodeTextBox.Location = new System.Drawing.Point(149, 79);
			this.activeCodeTextBox.Name = "activeCodeTextBox";
			this.activeCodeTextBox.Size = new System.Drawing.Size(250, 20);
			this.activeCodeTextBox.TabIndex = 11;
			this.activeCodeTextBox.TextChanged += new System.EventHandler(this.ActiveCodeTextBox_TextChanged);
			// 
			// licenseKeyTextBox
			// 
			this.licenseKeyTextBox.Location = new System.Drawing.Point(149, 113);
			this.licenseKeyTextBox.Name = "licenseKeyTextBox";
			this.licenseKeyTextBox.Size = new System.Drawing.Size(250, 20);
			this.licenseKeyTextBox.TabIndex = 12;
			// 
			// minimizedButton
			// 
			this.minimizedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizedButton.BackgroundImage")));
			this.minimizedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.minimizedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.minimizedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.minimizedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizedButton.Location = new System.Drawing.Point(5, 9);
			this.minimizedButton.Name = "minimizedButton";
			this.minimizedButton.Size = new System.Drawing.Size(20, 20);
			this.minimizedButton.TabIndex = 13;
			this.minimizedButton.UseVisualStyleBackColor = true;
			this.minimizedButton.Click += new System.EventHandler(this.MinimizedButton_Click);
			// 
			// dayTextBox
			// 
			this.dayTextBox.Enabled = false;
			this.dayTextBox.Location = new System.Drawing.Point(149, 44);
			this.dayTextBox.MaxLength = 3;
			this.dayTextBox.Name = "dayTextBox";
			this.dayTextBox.Size = new System.Drawing.Size(55, 20);
			this.dayTextBox.TabIndex = 14;
			this.dayTextBox.Text = "0";
			this.dayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.dayTextBox.TextChanged += new System.EventHandler(this.DayTextBox_TextChanged);
			this.dayTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DayTextBox_KeyPress);
			// 
			// enterDayToExpireLabel
			// 
			this.enterDayToExpireLabel.AutoSize = true;
			this.enterDayToExpireLabel.Location = new System.Drawing.Point(39, 47);
			this.enterDayToExpireLabel.Name = "enterDayToExpireLabel";
			this.enterDayToExpireLabel.Size = new System.Drawing.Size(104, 13);
			this.enterDayToExpireLabel.TabIndex = 15;
			this.enterDayToExpireLabel.Text = "Enter day to expire:";
			// 
			// createDateLabel
			// 
			this.createDateLabel.AutoSize = true;
			this.createDateLabel.Location = new System.Drawing.Point(210, 47);
			this.createDateLabel.Name = "createDateLabel";
			this.createDateLabel.Size = new System.Drawing.Size(82, 13);
			this.createDateLabel.TabIndex = 16;
			this.createDateLabel.Text = "Creattion Date:";
			// 
			// expireDateLabel
			// 
			this.expireDateLabel.AutoSize = true;
			this.expireDateLabel.Location = new System.Drawing.Point(376, 47);
			this.expireDateLabel.Name = "expireDateLabel";
			this.expireDateLabel.Size = new System.Drawing.Size(67, 13);
			this.expireDateLabel.TabIndex = 17;
			this.expireDateLabel.Text = "Expire Date:";
			// 
			// createDateTextBox
			// 
			this.createDateTextBox.AutoSize = true;
			this.createDateTextBox.Location = new System.Drawing.Point(290, 47);
			this.createDateTextBox.Name = "createDateTextBox";
			this.createDateTextBox.Size = new System.Drawing.Size(0, 13);
			this.createDateTextBox.TabIndex = 18;
			// 
			// expireDateTextBox
			// 
			this.expireDateTextBox.AutoSize = true;
			this.expireDateTextBox.Location = new System.Drawing.Point(441, 47);
			this.expireDateTextBox.Name = "expireDateTextBox";
			this.expireDateTextBox.Size = new System.Drawing.Size(0, 13);
			this.expireDateTextBox.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(197, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Creat License Key For Program";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(548, 198);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.expireDateTextBox);
			this.Controls.Add(this.createDateTextBox);
			this.Controls.Add(this.createDateLabel);
			this.Controls.Add(this.enterDayToExpireLabel);
			this.Controls.Add(this.dayTextBox);
			this.Controls.Add(this.minimizedButton);
			this.Controls.Add(this.licenseKeyTextBox);
			this.Controls.Add(this.activeCodeTextBox);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonCopy);
			this.Controls.Add(this.buttonPaste);
			this.Controls.Add(this.selectLanguageComboBox);
			this.Controls.Add(this.licenseKeyProducteLabel);
			this.Controls.Add(this.activeCodeLabel);
			this.Controls.Add(this.expireDateLabel);
			this.Font = new System.Drawing.Font("Tahoma", 8F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label activeCodeLabel;
		private System.Windows.Forms.Label licenseKeyProducteLabel;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ComboBox selectLanguageComboBox;
		private System.Windows.Forms.Button buttonPaste;
		private System.Windows.Forms.Button buttonCopy;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.TextBox activeCodeTextBox;
		private System.Windows.Forms.TextBox licenseKeyTextBox;
		private System.Windows.Forms.Button minimizedButton;
		private System.Windows.Forms.TextBox dayTextBox;
		private System.Windows.Forms.Label enterDayToExpireLabel;
		private System.Windows.Forms.Label createDateLabel;
		private System.Windows.Forms.Label expireDateLabel;
		private System.Windows.Forms.Label createDateTextBox;
		private System.Windows.Forms.Label expireDateTextBox;
		private System.Windows.Forms.Label label1;
	}
}

