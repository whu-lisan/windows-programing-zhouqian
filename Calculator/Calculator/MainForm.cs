using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void juniorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void programGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void seniorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void funcButton_Click(object sender, EventArgs e)
        {
            Form funcForm = new FunctionForm();
            funcForm.Show();
        }
    }
}
