using System;
using System.Globalization;
using System.Resources;

namespace KEY_GENERATOR_FOR_LICENSE_KEY
{	
	public partial class MainForm : System.Windows.Forms.Form
	{
		//----------------------------- Fields - Properites - Layers

		public bool English_Language
		{
			get; set;
		}
		public bool Persian_Language
		{
			get; set;
		}
		public bool Turkish_Language
		{
			get; set;
		}

		ResourceManager _resourceManager;
		CultureInfo _cultureInfo;

		private SKGL.Generate _generate = new SKGL.Generate();
		private SKGL.Validate _validate = new SKGL.Validate();
		private int _day;

		System.DateTime _dateTime = System.DateTime.Now;
		private string _expireDate;

		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


		//----------------------------- Constructor

		public MainForm()
		{
			InitializeComponent();
		}

		//----------------------------- Events Control

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			_resourceManager = new ResourceManager("KEY_GENERATOR_FOR_LICENSE_KEY.Languages.Res", typeof(MainForm).Assembly);

			selectLanguageComboBox.SelectedIndex = 0;

			English_Language = true;
			Persian_Language = false;
			Turkish_Language = false;
		}

		private void MainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void MinimizedButton_Click(object sender, EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}

		private void SelectLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectIndex = selectLanguageComboBox.SelectedIndex;

			switch (selectIndex)
			{
				case 0:

					if (!English_Language)
					{
						English_Language = true;
						Persian_Language = false;
						Turkish_Language = false;

						minimizedButton.Location = new System.Drawing.Point(523, 9);
						selectLanguageComboBox.Location = new System.Drawing.Point(x: 5, y: 9);

						enterDayToExpireLabel.Location = new System.Drawing.Point(39,47);
						enterDayToExpireLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
						dayTextBox.Location = new System.Drawing.Point(149,44);
						dayTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;

						createDateLabel.Location = new System.Drawing.Point(210, 47);
						createDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
						createDateTextBox.Location = new System.Drawing.Point(290, 47);
						createDateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;

						expireDateLabel.Location = new System.Drawing.Point(380, 47);
						expireDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
						expireDateTextBox.Location = new System.Drawing.Point(445, 47);
						expireDateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;

						activeCodeLabel.Location = new System.Drawing.Point(x: 74, y: 82);
						activeCodeTextBox.Location = new System.Drawing.Point(x: 149, y: 79);
						activeCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
						activeCodeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;

						licenseKeyProducteLabel.Location = new System.Drawing.Point(x: 36, y: 117);
						licenseKeyTextBox.Location = new System.Drawing.Point(x: 149, y: 113);

						licenseKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
						licenseKeyProducteLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;

						buttonPaste.Location = new System.Drawing.Point(x: 405, y: 77);
						buttonCopy.Location = new System.Drawing.Point(x: 405, y: 111);

						clearButton.Location = new System.Drawing.Point(x: 354, y: 151);
						generateButton.Location = new System.Drawing.Point(x: 44, y: 151);

						Switch_language();
					}
					else
					{
						return;
					}

					break;
				case 1:

					if (!Persian_Language)
					{
						Persian_Language = true;
						English_Language = false;
						Turkish_Language = false;

						minimizedButton.Location = new System.Drawing.Point(5, 9);
						selectLanguageComboBox.Location = new System.Drawing.Point(x: 500, y: 9);

						enterDayToExpireLabel.Location = new System.Drawing.Point(405, 47);
						enterDayToExpireLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
						dayTextBox.Location = new System.Drawing.Point(344, 44);
						dayTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

						createDateLabel.Location = new System.Drawing.Point(282, 47);
						createDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
						createDateTextBox.Location = new System.Drawing.Point(219, 47);
						createDateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

						expireDateLabel.Location = new System.Drawing.Point(136, 47);
						expireDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
						expireDateTextBox.Location = new System.Drawing.Point(73, 47);
						expireDateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

						activeCodeLabel.Location = new System.Drawing.Point(x: 405, y: 82);
						activeCodeTextBox.Location = new System.Drawing.Point(x: 149, y: 79);
						activeCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
						activeCodeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

						licenseKeyProducteLabel.Location = new System.Drawing.Point(x: 405, y: 116);
						licenseKeyTextBox.Location = new System.Drawing.Point(x: 149, y: 113);
						licenseKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
						licenseKeyProducteLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

						buttonPaste.Location = new System.Drawing.Point(x: 118, y: 77);
						buttonCopy.Location = new System.Drawing.Point(x: 118, y: 111);

						clearButton.Location = new System.Drawing.Point(x: 44, y: 151);
						generateButton.Location = new System.Drawing.Point(x: 354, y: 151);

						Switch_language();
					}
					else
					{
						return;
					}

					break;
				case 2:

					if (!Turkish_Language)
					{
						Turkish_Language = true;
						English_Language = false;
						Persian_Language = false;

						minimizedButton.Location = new System.Drawing.Point(523, 9);
						selectLanguageComboBox.Location = new System.Drawing.Point(x: 5, y: 9);

						enterDayToExpireLabel.Location = new System.Drawing.Point(14, 47);
						enterDayToExpireLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
						dayTextBox.Location = new System.Drawing.Point(149, 44);
						dayTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;

						createDateLabel.Location = new System.Drawing.Point(210, 47);
						createDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
						createDateTextBox.Location = new System.Drawing.Point(290, 47);
						createDateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;

						expireDateLabel.Location = new System.Drawing.Point(380, 47);
						expireDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
						expireDateTextBox.Location = new System.Drawing.Point(445, 47);
						expireDateTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;

						activeCodeLabel.Location = new System.Drawing.Point(x: 74, y: 82);
						activeCodeTextBox.Location = new System.Drawing.Point(x: 149, y: 79);
						activeCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
						activeCodeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;

						licenseKeyProducteLabel.Location = new System.Drawing.Point(x: 36, y: 117);
						licenseKeyTextBox.Location = new System.Drawing.Point(x: 149, y: 113);

						licenseKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
						licenseKeyProducteLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;

						buttonPaste.Location = new System.Drawing.Point(x: 405, y: 77);
						buttonCopy.Location = new System.Drawing.Point(x: 405, y: 111);

						clearButton.Location = new System.Drawing.Point(x: 354, y: 151);
						generateButton.Location = new System.Drawing.Point(x: 44, y: 151);

						Switch_language();
					}
					else
					{
						return;
					}

					break;

				default:
					break;
			}
		}

		private void DayTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void DayTextBox_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(dayTextBox.Text) || string.Compare(dayTextBox.Text,"0")==0)
			{
				_day = 0;

				createDateTextBox.Text = String.Empty;
				expireDateTextBox.Text = String.Empty;
			}
			else
			{
				_day = int.Parse(dayTextBox.Text);

				ShowExpireDate(_day);
			}


		}

		private void ShowExpireDate(int day)
		{
			string nowDate = null;
			string nextDate = null;
			nowDate = _dateTime.ToShortDateString();
			nextDate =  _dateTime.AddDays(day).ToShortDateString();

			_expireDate = _dateTime.AddDays(day).ToShortDateString();

			if (day == 0)
			{
				return;
			}
			else
			{
				createDateTextBox.Text = $"{nowDate}";

				expireDateTextBox.Text = $"{nextDate}";
			}
		}

		private void ActiveCodeTextBox_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(activeCodeTextBox.Text))
			{
				dayTextBox.Enabled = false;
			}
			else
			{
				dayTextBox.Enabled = true;
			}
		}

		private void GenerateButton_Click(object sender, System.EventArgs e)
		{
			licenseKeyTextBox.Text = Mbb.LockUtility.GetLicenseKeyBySQLServer(activeCodeTextBox.Text);
		}

		private void ButtonPaste_Click(object sender, EventArgs e)
		{
			activeCodeTextBox.Text = System.Windows.Forms.Clipboard.GetText();
		}

		private void ButtonCopy_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(licenseKeyTextBox.Text))
			{
				return;
			}
			else
			{
				string licenseKey = $"{licenseKeyTextBox.Text} - {_expireDate}";

				System.Windows.Forms.Clipboard.SetText(licenseKey);
			}
			
		}

		private void ClearButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Clipboard.Clear();
			licenseKeyTextBox.Clear();
			activeCodeTextBox.Clear();
			dayTextBox.Text = "0";
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}


		//----------------------------- Methods

		private void Switch_language()
		{
			if (English_Language)
			{
				_cultureInfo = CultureInfo.CreateSpecificCulture("en-US");
			}
			else if (Persian_Language)
			{
				_cultureInfo = CultureInfo.CreateSpecificCulture("fa-IR");
			}
			else
			{
				_cultureInfo = CultureInfo.CreateSpecificCulture("tr-TR");
			}

			enterDayToExpireLabel.Text = _resourceManager.GetString("Enter_Day_To_Expire", _cultureInfo);

			createDateLabel.Text = _resourceManager.GetString("Creattion_Date", _cultureInfo);
			expireDateLabel.Text = _resourceManager.GetString("Expire_Date", _cultureInfo);

			activeCodeLabel.Text = _resourceManager.GetString("Active_Code", _cultureInfo);
			licenseKeyProducteLabel.Text = _resourceManager.GetString("License_Key_Producte", _cultureInfo);

			generateButton.Text = _resourceManager.GetString("Generate_License_Button", _cultureInfo);
			exitButton.Text = _resourceManager.GetString("Exit_Button", _cultureInfo);
			clearButton.Text = _resourceManager.GetString("Clear_Button", _cultureInfo);

			toolTip1.SetToolTip(buttonPaste, _resourceManager.GetString("Paste_To_Control", _cultureInfo));
			toolTip1.SetToolTip(buttonCopy, _resourceManager.GetString("Copy_From_Control", _cultureInfo));

			toolTip1.ToolTipTitle = _resourceManager.GetString("Information", _cultureInfo);
		}

		
	}
}
