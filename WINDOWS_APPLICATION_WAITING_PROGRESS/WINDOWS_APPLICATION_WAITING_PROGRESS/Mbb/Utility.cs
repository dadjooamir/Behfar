namespace Mbb
{
	public class Utility
	{
		private static WaitingProgressForm _waitingProgressForm;

		private static WaitingProgressForm MyWaitingProgressForm
		{
			get
			{
				if (_waitingProgressForm == null || _waitingProgressForm.IsDisposed == true)
					_waitingProgressForm =
						new WaitingProgressForm();

				return _waitingProgressForm;
			}
			set
			{
				_waitingProgressForm = value;
			}
		}

		public Utility()
		{

		}
		
		public static void ShowWatingForm(int timeOut, System.Windows.Forms.Form form)
		{
			MyWaitingProgressForm.TimeOut = timeOut;
			MyWaitingProgressForm.MyForm = form;

			MyWaitingProgressForm.ShowDialog();
		}


	}
}
