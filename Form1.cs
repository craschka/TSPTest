using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TSPTest
{
    public partial class Form1 : Form
    {
        private TankstellenUsecaseController moersController = new TankstellenUsecaseController(new HTTPDownloader(),new AgilityHTMLParser(),"moers", new SimpleTextFileAuditor("moers.txt"));
        private TankstellenUsecaseController duesseldorfController = new TankstellenUsecaseController(new HTTPDownloader(), new AgilityHTMLParser(), "Düsseldorf", new SimpleTextFileAuditor("duesseldorf.txt"));
        public Form1()
        {
            InitializeComponent();
            moersController.NotificateIfNew(Notification());
            duesseldorfController.NotificateIfNew(NotificationDDorf());
        }

        private Action<string> Notification()
        {
            return x =>
            {
                notifyIcon1.BalloonTipText = x;
                notifyIcon1.ShowBalloonTip(2000);
                AktualisiereForm(x);
            };
        }

        private Action<string> NotificationDDorf()
        {
            return x =>
            {
                notifyIcon1.BalloonTipText = x;
                notifyIcon1.ShowBalloonTip(2000);
                AktualisiereFormDDorf(x);
            };
        }

        private void AktualisiereForm(string x)
        {
            tankstellenName.Text = x;
        }

        private void AktualisiereFormDDorf(string x)
        {
            tankstelleDdorf.Text = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moersController.NotificateIfNew(Notification());
            duesseldorfController.NotificateIfNew(NotificationDDorf());
        }

		  private void timer1_Tick(object sender, EventArgs e)
		  {
              moersController.NotificateIfNew(Notification());
		  }

          private void timer2_Tick(object sender, EventArgs e)
          {
              duesseldorfController.NotificateIfNew(NotificationDDorf());
          }
    }
}
