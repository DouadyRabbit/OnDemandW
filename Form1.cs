using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnDemandW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int error_succes = 0;
            error_succes =  axArsOle1.Logon("SERVER-NAME-HERE", "USER-NAME-HERE", "USER-PASSWORD-HERE");

            MessageBox.Show(error_succes.ToString());

            axArsOle1.Logoff();
        }
    }
}
