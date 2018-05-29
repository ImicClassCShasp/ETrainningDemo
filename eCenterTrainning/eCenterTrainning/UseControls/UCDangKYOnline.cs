using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Configuration;

namespace eCenterTrainning.UseControls
{
    public partial class UCDangKYOnline : UserControl
    {        
        readonly BackgroundWorker _worker = new BackgroundWorker();
        const string IMIC_GETCONTACT = "stdContactGets";
        SqlConnection m_objConnection;
        public UCDangKYOnline()
        {
            InitializeComponent();
        }       
        private void _worker_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            // Simulate work (uploading Excel records to SQL Server)
            for (var i = 1; i <= 20; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                // Upload some data here, Sleep(100) is just an example
                Thread.Sleep(100);

                // Calculate current progress and report
                worker.ReportProgress(i);
            }           
        }

        void WorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarControl1.Increment(e.ProgressPercentage);
            if (e.ProgressPercentage == 20)
            {
                MessageBox.Show("");
            }
        }

        void WorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            progressBarControl1.Reset();             
        }
        
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            InnitThread();
            //progressBarControl1.Visible=false;
            //btnGetData.Enabled = false;

        }

        public void InnitThread() {
            //Progress Bar
            progressBarControl1.Visible = true;
            _worker.WorkerReportsProgress = true;
            _worker.DoWork += _worker_DoWork;
            _worker.ProgressChanged += WorkerProgressChanged;
            _worker.RunWorkerCompleted += WorkerRunWorkerCompleted;
            _worker.RunWorkerAsync();
        }
    }
}
