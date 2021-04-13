using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlCalendar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 85; i++)
            {
                int year = 2015 + i;
                cmbYear.Items.Add(string.Format("Year-{0}",year));
            }
            cmbYear.SelectedItem = string.Format("Year-{0}", DateTime.Now.Year);
        }

        private void calendar1_Load(object sender, EventArgs e)
        {

        }
    }
}
