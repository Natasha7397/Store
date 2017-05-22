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
    public partial class PurveyorForm : Form
    {
        public PurveyorForm()
        {
            InitializeComponent();
            editForm = new EditPurveyorForm();
            this.CenterToScreen();
            
        }
        EditPurveyorForm editForm;
        private void Add_Click(object sender, EventArgs e)
        {
            editForm.ShowDialog();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            editForm.ShowDialog();
        }

        private void TablePurveyor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PurveyorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
