using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControlCalendar.Model;

namespace UserControlCalendar
{
    public partial class MainForm : Form
    {
        List<Label> lstDates = new List<Label>();
        List<Employee> employees = new List<Employee>();
        public MainForm()
        {
            InitializeComponent();
            calendar1.UseWaitCursor = false;
            calendar1.Cursor = Cursors.Default;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 85; i++)
            {
                int year = 2015 + i;
                cmbYear.Items.Add(string.Format("Year-{0}", year));
            }
            cmbYear.SelectedItem = string.Format("Year-{0}", DateTime.Now.Year);
        }

        private void calendar1_Load(object sender, EventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yearSelected = this.cmbYear.SelectedItem.ToString().Replace("Year-", string.Empty);
            
            if (!yearSelected.Equals(string.Empty))
            {
                LoadCalendarDate(yearSelected);
            }
        }



        private void LoadCalendarDate(string year)
        {
            List<CheckBox> lstDates = new List<CheckBox>(calendar1.lstDates);
            for (int i = 0; i < lstDates.Count; i++)
            {
                lstDates[i].Text = "                        ";
            }
            List<CheckBox> lblJanuar = lstDates.Take(37).ToList();
            lstDates.RemoveRange(0, 37);
            
            List<CheckBox> lblFeb = lstDates.Take(37).ToList();
            lstDates.RemoveRange(0, 37);

            List<CheckBox> lblMar = lstDates.Take(37).ToList();
            lstDates.RemoveRange(0, 37);

            List<CheckBox> lblApril = lstDates.Take(37).ToList();
            lstDates.RemoveRange(0, 37);

            List<CheckBox> lblMay = lstDates.Take(37).ToList();
            lstDates.RemoveRange(0, 37);

            List<CheckBox> lblJun = lstDates.Take(37).ToList();
            lstDates.RemoveRange(0, 37);

            List<CheckBox> lblJul = lstDates.Take(37).ToList();
            lstDates.RemoveRange(0, 37);

            List<CheckBox> lblAug = lstDates.Take(37).ToList();
            lstDates.RemoveRange(0, 37);

            List<CheckBox> lblSep = lstDates.Take(37).ToList();
            lstDates.RemoveRange(0, 37);

            List<CheckBox> lblOct = lstDates.Take(37).ToList();
            lstDates.RemoveRange(0, 37);

            List<CheckBox> lblNov = lstDates.Take(37).ToList();
            lstDates.RemoveRange(0, 37);

            List<CheckBox> lblDec = lstDates.Take(37).ToList();
            lstDates.RemoveRange(0, 37);

            int yearParsed = int.Parse(year);
            DateTime FirstDayOfYear = new DateTime(yearParsed, 1, 1);

            PopulateMonth(lblJanuar, year,1 , 31);
            PopulateMonth(lblFeb, year, 2, IsLeapYear(FirstDayOfYear.Year) ? 29 : 28);
            PopulateMonth(lblMar, year, 3, 31);
            PopulateMonth(lblApril, year, 4, 30);
            PopulateMonth(lblMay, year, 5, 31);
            PopulateMonth(lblJun, year, 6, 30);
            PopulateMonth(lblJul, year, 7, 31);
            PopulateMonth(lblAug, year, 8, 31);
            PopulateMonth(lblSep, year, 9, 30);
            PopulateMonth(lblOct, year, 10, 31);
            PopulateMonth(lblNov, year, 11, 30);
            PopulateMonth(lblDec, year, 12, 31);


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

        private void PopulateMonth(List<CheckBox> lstLabels, string year,int month,int daysOfMonth) {
            int yearParsed = int.Parse(year);
            DateTime FirstDayOfYear = new DateTime(yearParsed, month, 1);
            switch (FirstDayOfYear.DayOfWeek.ToString())
            {
                case "Tuesday":
                    lstLabels.RemoveRange(0,1);
                    break;
                case "Wednesday":
                    lstLabels.RemoveRange(0, 2);
                    break;
                case "Thursday":
                    lstLabels.RemoveRange(0, 3);
                    break;
                case "Friday":
                    lstLabels.RemoveRange(0, 4);
                    break;
                case "Saturday":
                    lstLabels.RemoveRange(0, 5);
                    break;
                case "Sunday":
                    lstLabels.RemoveRange(0, 6);
                    break;
                default:
                    break;
            }
            PopulateDates(lstLabels, daysOfMonth);
        }

        private void PopulateDates(List<CheckBox> lstLabels, int daysOfMonth)
        {
            for (int i = 0; i < daysOfMonth; i++)
            {
                lstLabels[i].Text =  (i + 1).ToString() + "                        ";
            }
        }

        private void cmbYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string yearSelected = this.cmbYear.SelectedItem.ToString().Replace("Year-", string.Empty);
            if (!yearSelected.Equals(string.Empty))
            {
                LoadCalendarDate(yearSelected);
            }
        }

        private void btnLoadEmployeeData_Click(object sender, EventArgs e)
        {
            employees = Employee.GetEmployees();

        }
    }
}
