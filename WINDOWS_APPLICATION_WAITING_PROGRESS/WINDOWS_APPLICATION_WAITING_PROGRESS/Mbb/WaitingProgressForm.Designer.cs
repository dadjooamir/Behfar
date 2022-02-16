namespace Mbb
{
	partial class WaitingProgressForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitingProgressForm));
			this.watingProgressPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
			this.watingProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
			this.watingProgressPercentLabel = new Bunifu.UI.WinForms.BunifuLabel();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.fadeInTimer = new System.Windows.Forms.Timer(this.components);
			this.fadeOuttimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.watingProgressPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// watingProgressPictureBox
			// 
			this.watingProgressPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.watingProgressPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("watingProgressPictureBox.Image")));
			this.watingProgressPictureBox.Location = new System.Drawing.Point(0, -5);
			this.watingProgressPictureBox.Name = "watingProgressPictureBox";
			this.watingProgressPictureBox.ShadowDecoration.Parent = this.watingProgressPictureBox;
			this.watingProgressPictureBox.Size = new System.Drawing.Size(300, 128);
			this.watingProgressPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.watingProgressPictureBox.TabIndex = 0;
			this.watingProgressPictureBox.TabStop = false;
			this.watingProgressPictureBox.Click += new System.EventHandler(this.watingProgressPictureBox_Click);
			// 
			// watingProgressBar
			// 
			this.watingProgressBar.BorderRadius = 2;
			this.watingProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.watingProgressBar.FillColor = System.Drawing.Color.Transparent;
			this.watingProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.watingProgressBar.Location = new System.Drawing.Point(0, 120);
			this.watingProgressBar.Name = "watingProgressBar";
			this.watingProgressBar.ProgressColor = System.Drawing.Color.SlateBlue;
			this.watingProgressBar.ProgressColor2 = System.Drawing.Color.Cyan;
			this.watingProgressBar.ShadowDecoration.Parent = this.watingProgressBar;
			this.watingProgressBar.Size = new System.Drawing.Size(300, 15);
			this.watingProgressBar.TabIndex = 1;
			this.watingProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.watingProgressBar.Value = 100;
			// 
			// watingProgressPercentLabel
			// 
			this.watingProgressPercentLabel.AllowParentOverrides = false;
			this.watingProgressPercentLabel.AutoEllipsis = false;
			this.watingProgressPercentLabel.BackColor = System.Drawing.Color.White;
			this.watingProgressPercentLabel.Cursor = System.Windows.Forms.Cursors.Default;
			this.watingProgressPercentLabel.CursorType = System.Windows.Forms.Cursors.Default;
			this.watingProgressPercentLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.watingProgressPercentLabel.Location = new System.Drawing.Point(12, 99);
			this.watingProgressPercentLabel.Name = "watingProgressPercentLabel";
			this.watingProgressPercentLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.watingProgressPercentLabel.Size = new System.Drawing.Size(19, 15);
			this.watingProgressPercentLabel.TabIndex = 2;
			this.watingProgressPercentLabel.Text = "0 %";
			this.watingProgressPercentLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.watingProgressPercentLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// fadeInTimer
			// 
			this.fadeInTimer.Interval = 50;
			this.fadeInTimer.Tick += new System.EventHandler(this.fadeInTimer_Tick);
			// 
			// fadeOuttimer
			// 
			this.fadeOuttimer.Interval = 5;
			this.fadeOuttimer.Tick += new System.EventHandler(this.fadeOuttimer_Tick);
			// 
			// WaitingProgressForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(300, 135);
			this.Controls.Add(this.watingProgressBar);
			this.Controls.Add(this.watingProgressPercentLabel);
			this.Controls.Add(this.watingProgressPictureBox);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "WaitingProgressForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TransparencyKey = System.Drawing.Color.White;
			this.Load += new System.EventHandler(this.WaitingProgressForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.watingProgressPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2PictureBox watingProgressPictureBox;
		private Guna.UI2.WinForms.Guna2ProgressBar watingProgressBar;
		private Bunifu.UI.WinForms.BunifuLabel watingProgressPercentLabel;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Timer fadeInTimer;
		private System.Windows.Forms.Timer fadeOuttimer;
	}
}

