using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlCalendar.Model;

namespace UserControlCalendar
{
    public partial class GridView : Form
    {
        ContextMenuStrip menuStrip = new ContextMenuStrip();
        List<ShiftDetail> shiftDetails = new List<ShiftDetail>();
        DataGridViewSelectedCellCollection selectedCellCollection;
        private Shift Shift = Shift.Shift0;
        public GridView()
        {
            InitializeComponent();

        }

        private void GridView_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem("Shift-1");
            menuItem.Click += new EventHandler(menuItem_Click);
            menuItem.Name = "Shift-1";
            menuStrip.Items.Add(menuItem);
            menuItem = new ToolStripMenuItem("Shift-2");
            menuItem.Click += new EventHandler(menuItem_Click);
            menuItem.Name = "Shift-2";
            menuStrip.Items.Add(menuItem);
            menuItem = new ToolStripMenuItem("Shift-3");
            menuItem.Click += new EventHandler(menuItem_Click);
            menuItem.Name = "Shift-3";
            menuStrip.Items.Add(menuItem);

            for (int i = 0; i < 85; i++)
            {
                int year = 2015 + i;
                cmbYear.Items.Add(string.Format("Year-{0}", year));
            }
            cmbYear.SelectedItem = string.Format("Year-{0}", DateTime.Now.Year);
            List<Employee> employees = Employee.GetEmployees();
            for (int i = 0; i < employees.Count; i++)
            {
                cmbEmployees.Items.Add(string.Format("{0}-{1}", employees[i].Id, employees[i].Name));
            }
            cmbEmployees.SelectedItem = string.Format("{0}-{1}", employees[0].Id, employees[0].Name);
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yearSelected = this.cmbYear.SelectedItem.ToString().Replace("Year-", string.Empty);
            if (!yearSelected.Equals(string.Empty))
            {
                List<GridEntity> gridEntities = GetGridEntities(yearSelected);
                dataGridView1.DataSource = gridEntities;
            }
            dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.LightSkyBlue };
            dataGridView1.Columns[0].DefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.LightCyan };
            dataGridView1.Rows[6].DefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.LightCyan };
            dataGridView1.Rows[13].DefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.LightCyan };
            dataGridView1.Rows[20].DefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.LightCyan };
            dataGridView1.Rows[27].DefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.LightCyan };
            dataGridView1.Rows[34].DefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.LightCyan };
            
        }


        private List<GridEntity> GetGridEntities(string year)
        {
            List<GridEntity> gridEntities = PopulateMonth(year);
            return gridEntities;
        }

        private bool IsLeapYear(int year)
        {
            if ((year % 400) == 0)
                return true;
            else if ((year % 100) == 0)
                return false;
            else if ((year % 4) == 0)
                return true;
            else
                return false;
        }


        private List<GridEntity> PopulateMonth(string year)
        {

            int yearParsed = int.Parse(year);
            DateTime FirstDayOfYear = new DateTime(yearParsed, 1, 1);
            List<int?> jan = GetDates(year, 1, 31);
            List<int?> feb = GetDates(year, 2, IsLeapYear(FirstDayOfYear.Year) ? 29 : 28);
            List<int?> mar = GetDates(year, 3, 31);
            List<int?> apr = GetDates(year, 4, 30);
            List<int?> may = GetDates(year, 5, 31);
            List<int?> jun = GetDates(year, 6, 30);
            List<int?> jul = GetDates(year, 7, 31);
            List<int?> aug = GetDates(year, 8, 31);
            List<int?> sep = GetDates(year, 9, 30);
            List<int?> oct = GetDates(year, 10, 31);
            List<int?> nov = GetDates(year, 11, 30);
            List<int?> dec = GetDates(year, 12, 31);
            GridMonth gm = new GridMonth
            {
                January = jan,
                Feburary = feb,
                March = mar,
                April = apr,
                May = may,
                June = jun,
                July = jul,
                Augast = aug,
                September = sep,
                October = oct,
                November = nov,
                December = dec
            };
            List<GridEntity> gridEntities = GridEntity.GetGridEntities(gm);
            return gridEntities;
        }

        private static List<int?> GetDates(string year, int month, int daysOfMonth)
        {
            int yearParsed = int.Parse(year);
            int skipdays = 0;
            DateTime FirstDayOfYear = new DateTime(yearParsed, month, 1);
            switch (FirstDayOfYear.DayOfWeek.ToString())
            {
                case "Tuesday":
                    skipdays = 1;
                    break;
                case "Wednesday":
                    skipdays = 2;
                    break;
                case "Thursday":
                    skipdays = 3;
                    break;
                case "Friday":
                    skipdays = 4;
                    break;
                case "Saturday":
                    skipdays = 5;
                    break;
                case "Sunday":
                    skipdays = 6;
                    break;
                default:
                    break;
            }
            List<int?> dates = new List<int?>();
            for (int i = 0; i < skipdays; i++)
            {
                dates.Add(null);
            }
            for (int i = 1; i <= daysOfMonth; i++)
            {
                dates.Add(i);
            }
            for (int i = skipdays + daysOfMonth; i < 37; i++)
            {
                dates.Add(null);
            }

            return dates;
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        DataGridView currentDG = (DataGridView)sender;
                        selectedCellCollection = currentDG.SelectedCells;
                        menuStrip.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
                    }
                    break;
            }

        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            ToolStripItem menuItem = (ToolStripItem)sender;
            if (menuItem.Name == "Shift-1")
            {
                Shift = Shift.Shift1;
            }
            if (menuItem.Name == "Shift-2")
            {
                Shift = Shift.Shift2;
            }
            if (menuItem.Name == "Shift-3")
            {
                Shift = Shift.Shift3;
            }

            for (int i = 0; i < selectedCellCollection.Count; i++)
            {
                int date = 0;
                if (selectedCellCollection[i].Value != null)
                {
                    int.TryParse(selectedCellCollection[i].Value.ToString(), out date);
                    int month = selectedCellCollection[i].ColumnIndex;
                    int employeeID = int.Parse(cmbEmployees.SelectedItem.ToString().Split('-')[0].ToString());
                    shiftDetails.Add(
                    new ShiftDetail
                    {
                        EmployeeID = employeeID,
                        Month = month,
                        Date = date,
                        Shift = Shift
                    }
                    );

                }

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string yearSelected = this.cmbYear.SelectedItem.ToString().Replace("Year-", string.Empty);
            int year = int.Parse(yearSelected);
            WriteFile(year);
            shiftDetails = new List<ShiftDetail>();
            Shift = Shift.Shift0;
            MessageBox.Show("Data has been saved.");
        }

        private void WriteFile(int year)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("D:\\Test.txt");
                //Write a line of text
                sw.WriteLine(string.Format("EmpID,\tShiftID,           Date"));
                for (int i = 0; i < shiftDetails.Count; i++)
                {
                    sw.WriteLine(shiftDetails[i].GetStringValue(year));
                }

                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
