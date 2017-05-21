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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            editForm = new EditClientForm();
            this.CenterToScreen();
        }
        EditClientForm editForm;
        private void Add_Click(object sender, EventArgs e)
        {
            editForm.ShowDialog();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            editForm.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
           
        }
    }
}
