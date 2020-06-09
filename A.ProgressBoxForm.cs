using System.Threading;
using System.Windows.Forms;

namespace CalibrationHelper
{
    public partial class ProgressBoxForm : Form
    {
        private delegate void WaitBoxDelegate(int CurrentStep);
        private WaitBoxDelegate del;

        public ProgressBoxForm()
        {
            InitializeComponent();
            this.ProgressBar.Maximum = 100;
            del = this.UpdateProgressInternal;
        }


        private void UpdateProgressInternal(int CurrentStep)
        {
            if (this.Handle == null)
            {
                return;
            }
            this.ProgressBar.Value = CurrentStep;
        }

        public void UpdateProgress(int CurrentStep)
        {
            try
            {
                this.Invoke(del, CurrentStep);
            }
            catch
            {

            }
       }

    }
    public class ProgressBoxInvokation
    {
        // ****** Create a ProgressBoxForm for process monitoring inside the form ******
        private ProgressBoxForm ProgressBox = new ProgressBoxForm();
        private bool ProgressBoxVisible = false, ProgressBoxDone = false;

        public ProgressBoxInvokation(string threadName)
        {
            //Create new thread for showing the ProgressBoxForm containing the loading status
            Thread ProgressBoxThread = new Thread(new ThreadStart(this.ProgressBoxRunningThread));
            ProgressBoxThread.Start();
            ProgressBoxThread.Name = threadName;
        }

        private void ProgressBoxRunningThread() //Individual thread for ProgressBoxForm continuous showing while loading
        {
            ProgressBox.Show();

            while (!ProgressBoxDone)
            {
                ProgressBox.Visible = ProgressBoxVisible && !ProgressBox.Visible ? true : ProgressBox.Visible;
                ProgressBox.Visible = !ProgressBoxVisible && ProgressBox.Visible ? false : ProgressBox.Visible;
                Application.DoEvents();
            }
            ProgressBox.Close();
            this.ProgressBox.Dispose();
        }

        public void ProgressBoxUpdate(int CurrentStep) //Public ProgressBoxForm update method, manipulated directly by child method
        {
            this.ProgressBox.UpdateProgress(CurrentStep);
        }

        public void ProgressBoxStart() //Public ProgressBoxForm start method, manipulated directly by child method
        {
            ProgressBoxVisible = true; //shows the ProgressBox
        }

        public void ProgressBoxFinish() //Public ProgressBoxForm finish method, manipulated directly by child method
        {
            ProgressBoxVisible = false; //hides the ProgressBox
            ProgressBoxDone = true; //finishes the thread loop
        }
    }
}
