using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holmusk.DeveloperChallenge.UI
{
    public partial class frmReactiveSample : Form
    {
        public frmReactiveSample()
        {
            InitializeComponent();
        }

        private static string WaitAWhile(string number)
        {
            //just to simulate some operation that might take a while to complete
            Thread.Sleep(500);
            return number;
        }

        private void WriteValuesRx()
        {
            int maxValue = 30;
            var query = from number in Enumerable.Range(1, maxValue) select WaitAWhile(number.ToString());

            var observableQuery = query.ToObservable(Scheduler.Default);

            observableQuery.ObserveOn(textBox1).Subscribe(n => textBox1.AppendText(n.ToString() + "\r\n"));

            //multiple subscriptions..
            //observableQuery.ObserveOn(progressBar1).Subscribe(n => progressBar1.Value += 1);
        }

    }
}
