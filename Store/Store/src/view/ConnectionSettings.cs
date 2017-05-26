using Store.src.control;
using Store.src.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class ConnectionSettings : Form
    {
        public ConnectionSettings()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
       
        private void ConnectionSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            ConnectionParams.IpAddress = IPText.Text;
            ConnectionParams.Port = PortText.Text;
            Close();
        }
    }
}
