using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegete
{
    public delegate void Logger(string message);
    //bir veya birden fazla methodu çağırmamıza yarar.Invoke ile kullanılır.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void SmsLogger(string message)
        {
            lblSms.Text = message;
        }
        public void MailLogger(string message)
        {
            lblMail.Text = message;
        }
        public void XmlLogger(string message)
        {
            lblXml.Text = message;
        }
        public void DbLogger(string message)
        {
            lblDb.Text = message;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Logger logger = new Logger(SmsLogger);
            logger += MailLogger;
            logger += XmlLogger;
            logger += DbLogger;

            logger.Invoke("Hello World");
        }
    }
}
