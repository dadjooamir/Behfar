using System.ComponentModel;

namespace Mbb
{
	internal partial class WaitingProgressForm : System.Windows.Forms.Form
	{

		
		private int _timeOut;
		/// <summary>
		/// This property determines the duration of the activity process.
		/// Which is in milliseconds.
		/// </summary>
		public int TimeOut 
		{
			get
			{
				return _timeOut;
			}

			set
			{
				_timeOut = value;
			}
		}


		private System.Windows.Forms.Form _myForm;

		public System.Windows.Forms.Form MyForm
		{
			get
			{
				if (_myForm == null || _myForm.IsDisposed == true)
				{
					_myForm =
						new System.Windows.Forms.Form();
				}
				return _myForm;
			}
			set
			{
				_myForm = value;
			}
		}


		public WaitingProgressForm()
		{
			InitializeComponent();
		}

		private void WaitingProgressForm_Load(object sender, System.EventArgs e)
		{
			this.Opacity = 0.0;
			fadeInTimer.Start();
			
		}

		private void progressTimer_Tick(object sender, System.EventArgs e)
		{


		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			for (int i = 0; i < watingProgressBar.Maximum+1; i++)
			{
				backgroundWorker1.ReportProgress(i);
				System.Threading.Thread.Sleep(TimeOut);
			}
		}

		private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			watingProgressPercentLabel.Text = $"{e.ProgressPercentage} %";

			watingProgressBar.Value = e.ProgressPercentage;
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			watingProgressPercentLabel.Text = "Progress is done...!";
			watingProgressPercentLabel.ForeColor = System.Drawing.Color.ForestGreen;

		}

		private void watingProgressPictureBox_Click(object sender, System.EventArgs e)
		{
			if (!backgroundWorker1.IsBusy)
			{
				fadeOuttimer.Start();
			}
		}

		private void fadeInTimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity += 0.05;

			if (this.Opacity >= 1)
			{
				watingProgressPercentLabel.ForeColor = System.Drawing.Color.Black;
				backgroundWorker1.WorkerReportsProgress = true;
				backgroundWorker1.RunWorkerAsync();
				fadeInTimer.Stop();
			}
		}

		private void fadeOuttimer_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.05;

			if (this.Opacity <= 0.0)
			{
				fadeInTimer.Stop();
				MyForm.Show();
				this.Close();
			}
		}
	}
}
