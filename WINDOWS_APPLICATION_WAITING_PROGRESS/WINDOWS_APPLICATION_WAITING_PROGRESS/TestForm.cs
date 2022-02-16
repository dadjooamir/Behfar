namespace WINDOWS_APPLICATION_WAITING_PROGRESS
{
	public partial class TestForm : System.Windows.Forms.Form
	{
		private int _timeOut;

		public TestForm()
		{
			InitializeComponent();
		}

		private void getTimeOutTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

		private void getTimeOutTextBox_TextChange(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(getTimeOutTextBox.Text))
			{
				_timeOut = 0;
			}
			else
			{
				_timeOut = int.Parse(getTimeOutTextBox.Text);
			}
		}

		private void setTimeOutButton_Click(object sender, System.EventArgs e)
		{
			if (_timeOut <= 0)
			{
				return;
			}
			else
			{
				this.Hide();
				Mbb.Utility.ShowWatingForm(_timeOut, this);
				
			}
		}

		
	}
}
