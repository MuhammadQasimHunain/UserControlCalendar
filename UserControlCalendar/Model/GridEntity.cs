using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlCalendar.Model
{
    public class GridEntity
    {
        public string Day { get; set; }
        public int? January { get; set; }
        public int? Feburary { get; set; }
        public int? March { get; set; }
        public int? April { get; set; }
        public int? May { get; set; }
        public int? June { get; set; }
        public int? July { get; set; }
        public int? Augast { get; set; }
        public int? September { get; set; }
        public int? October { get; set; }
        public int? November { get; set; }
        public int? December { get; set; }

        public static List<GridEntity> GetGridEntities(GridMonth gridMonth)
        {
            List<GridEntity> gridEntities = new List<GridEntity>();
            gridEntities.Add(new GridEntity { Day = "Mon", January = gridMonth.January[0] , Feburary = gridMonth.Feburary[0], March = gridMonth.March[0], April = gridMonth.April[0], May = gridMonth.May[0], June = gridMonth.June[0], July = gridMonth.July[0], Augast = gridMonth.Augast[0], September = gridMonth.September[0], October = gridMonth.October[0], November = gridMonth.November[0], December = gridMonth.December[0] });
            gridEntities.Add(new GridEntity { Day = "Tues", January = gridMonth.January[1], Feburary = gridMonth.Feburary[1], March = gridMonth.March[1], April = gridMonth.April[1], May = gridMonth.May[1], June = gridMonth.June[1], July = gridMonth.July[1], Augast = gridMonth.Augast[1], September = gridMonth.September[1], October = gridMonth.October[1], November = gridMonth.November[1], December = gridMonth.December[1] });
            gridEntities.Add(new GridEntity { Day = "Wed", January = gridMonth.January[2], Feburary = gridMonth.Feburary[2], March = gridMonth.March[2], April = gridMonth.April[2], May = gridMonth.May[2], June = gridMonth.June[2], July = gridMonth.July[2], Augast = gridMonth.Augast[2], September = gridMonth.September[2], October = gridMonth.October[2], November = gridMonth.November[2], December = gridMonth.December[2] });
            gridEntities.Add(new GridEntity { Day = "Thu", January = gridMonth.January[3], Feburary = gridMonth.Feburary[3], March = gridMonth.March[3], April = gridMonth.April[3], May = gridMonth.May[3], June = gridMonth.June[3], July = gridMonth.July[3], Augast = gridMonth.Augast[3], September = gridMonth.September[3], October = gridMonth.October[3], November = gridMonth.November[3], December = gridMonth.December[3] });
            gridEntities.Add(new GridEntity { Day = "Fri", January = gridMonth.January[4], Feburary = gridMonth.Feburary[4], March = gridMonth.March[4], April = gridMonth.April[4], May = gridMonth.May[4], June = gridMonth.June[4], July = gridMonth.July[4], Augast = gridMonth.Augast[4], September = gridMonth.September[4], October = gridMonth.October[4], November = gridMonth.November[4], December = gridMonth.December[4] });
            gridEntities.Add(new GridEntity { Day = "Sat", January = gridMonth.January[5], Feburary = gridMonth.Feburary[5], March = gridMonth.March[5], April = gridMonth.April[5], May = gridMonth.May[5], June = gridMonth.June[5], July = gridMonth.July[5], Augast = gridMonth.Augast[5], September = gridMonth.September[5], October = gridMonth.October[5], November = gridMonth.November[5], December = gridMonth.December[5] });
            gridEntities.Add(new GridEntity { Day = "Sun", January = gridMonth.January[6], Feburary = gridMonth.Feburary[6], March = gridMonth.March[6], April = gridMonth.April[6], May = gridMonth.May[6], June = gridMonth.June[6], July = gridMonth.July[6], Augast = gridMonth.Augast[6], September = gridMonth.September[6], October = gridMonth.October[6], November = gridMonth.November[6], December = gridMonth.December[6] });

            gridEntities.Add(new GridEntity { Day = "Mon", January = gridMonth.January[7], Feburary = gridMonth.Feburary[7], March = gridMonth.March[7], April = gridMonth.April[7], May = gridMonth.May[7], June = gridMonth.June[7], July = gridMonth.July[7], Augast = gridMonth.Augast[7], September = gridMonth.September[7], October = gridMonth.October[7], November = gridMonth.November[7], December = gridMonth.December[7] });
            gridEntities.Add(new GridEntity { Day = "Tues", January = gridMonth.January[8], Feburary = gridMonth.Feburary[8], March = gridMonth.March[8], April = gridMonth.April[8], May = gridMonth.May[8], June = gridMonth.June[8], July = gridMonth.July[8], Augast = gridMonth.Augast[8], September = gridMonth.September[8], October = gridMonth.October[8], November = gridMonth.November[8], December = gridMonth.December[8] });
            gridEntities.Add(new GridEntity {  Day = "Wed", January = gridMonth.January[9], Feburary = gridMonth.Feburary[9], March = gridMonth.March[9], April = gridMonth.April[9], May = gridMonth.May[9], June = gridMonth.June[9], July = gridMonth.July[9], Augast = gridMonth.Augast[9], September = gridMonth.September[9], October = gridMonth.October[9], November = gridMonth.November[9], December = gridMonth.December[9] });
            gridEntities.Add(new GridEntity {  Day = "Thu", January = gridMonth.January[10], Feburary = gridMonth.Feburary[10], March = gridMonth.March[10], April = gridMonth.April[10], May = gridMonth.May[10], June = gridMonth.June[10], July = gridMonth.July[10], Augast = gridMonth.Augast[10], September = gridMonth.September[10], October = gridMonth.October[10], November = gridMonth.November[10], December = gridMonth.December[10] });
            gridEntities.Add(new GridEntity {  Day = "Fri", January = gridMonth.January[11], Feburary = gridMonth.Feburary[11], March = gridMonth.March[11], April = gridMonth.April[11], May = gridMonth.May[11], June = gridMonth.June[11], July = gridMonth.July[11], Augast = gridMonth.Augast[11], September = gridMonth.September[11], October = gridMonth.October[11], November = gridMonth.November[11], December = gridMonth.December[11] });
            gridEntities.Add(new GridEntity {  Day = "Sat", January = gridMonth.January[12], Feburary = gridMonth.Feburary[12], March = gridMonth.March[12], April = gridMonth.April[12], May = gridMonth.May[12], June = gridMonth.June[12], July = gridMonth.July[12], Augast = gridMonth.Augast[12], September = gridMonth.September[12], October = gridMonth.October[12], November = gridMonth.November[12], December = gridMonth.December[12] });
            gridEntities.Add(new GridEntity {  Day = "Sun", January = gridMonth.January[13], Feburary = gridMonth.Feburary[13], March = gridMonth.March[13], April = gridMonth.April[13], May = gridMonth.May[13], June = gridMonth.June[13], July = gridMonth.July[13], Augast = gridMonth.Augast[13], September = gridMonth.September[13], October = gridMonth.October[13], November = gridMonth.November[13], December = gridMonth.December[13] });

            gridEntities.Add(new GridEntity {  Day = "Mon", January = gridMonth.January[14], Feburary = gridMonth.Feburary[14], March = gridMonth.March[14], April = gridMonth.April[14], May = gridMonth.May[14], June = gridMonth.June[14], July = gridMonth.July[14], Augast = gridMonth.Augast[14], September = gridMonth.September[14], October = gridMonth.October[14], November = gridMonth.November[14], December = gridMonth.December[14] });
            gridEntities.Add(new GridEntity {  Day = "Tues", January = gridMonth.January[15], Feburary = gridMonth.Feburary[15], March = gridMonth.March[15], April = gridMonth.April[15], May = gridMonth.May[15], June = gridMonth.June[15], July = gridMonth.July[15], Augast = gridMonth.Augast[15], September = gridMonth.September[15], October = gridMonth.October[15], November = gridMonth.November[15], December = gridMonth.December[15] });
            gridEntities.Add(new GridEntity {  Day = "Wed", January = gridMonth.January[16], Feburary = gridMonth.Feburary[16], March = gridMonth.March[16], April = gridMonth.April[16], May = gridMonth.May[16], June = gridMonth.June[16], July = gridMonth.July[16], Augast = gridMonth.Augast[16], September = gridMonth.September[16], October = gridMonth.October[16], November = gridMonth.November[16], December = gridMonth.December[16] });
            gridEntities.Add(new GridEntity {  Day = "Thu", January = gridMonth.January[17], Feburary = gridMonth.Feburary[17], March = gridMonth.March[17], April = gridMonth.April[17], May = gridMonth.May[17], June = gridMonth.June[17], July = gridMonth.July[17], Augast = gridMonth.Augast[17], September = gridMonth.September[17], October = gridMonth.October[17], November = gridMonth.November[17], December = gridMonth.December[17] });
            gridEntities.Add(new GridEntity {  Day = "Fri", January = gridMonth.January[18], Feburary = gridMonth.Feburary[18], March = gridMonth.March[18], April = gridMonth.April[18], May = gridMonth.May[18], June = gridMonth.June[18], July = gridMonth.July[18], Augast = gridMonth.Augast[18], September = gridMonth.September[18], October = gridMonth.October[18], November = gridMonth.November[18], December = gridMonth.December[18] });
            gridEntities.Add(new GridEntity {  Day = "Sat", January = gridMonth.January[19], Feburary = gridMonth.Feburary[19], March = gridMonth.March[19], April = gridMonth.April[19], May = gridMonth.May[19], June = gridMonth.June[19], July = gridMonth.July[19], Augast = gridMonth.Augast[19], September = gridMonth.September[19], October = gridMonth.October[19], November = gridMonth.November[19], December = gridMonth.December[19] });
            gridEntities.Add(new GridEntity {  Day = "Sun", January = gridMonth.January[20], Feburary = gridMonth.Feburary[20], March = gridMonth.March[20], April = gridMonth.April[20], May = gridMonth.May[20], June = gridMonth.June[20], July = gridMonth.July[20], Augast = gridMonth.Augast[20], September = gridMonth.September[20], October = gridMonth.October[20], November = gridMonth.November[20], December = gridMonth.December[20] });

            gridEntities.Add(new GridEntity {  Day = "Mon", January = gridMonth.January[21], Feburary = gridMonth.Feburary[21], March = gridMonth.March[21], April = gridMonth.April[21], May = gridMonth.May[21], June = gridMonth.June[21], July = gridMonth.July[21], Augast = gridMonth.Augast[21], September = gridMonth.September[21], October = gridMonth.October[21], November = gridMonth.November[21], December = gridMonth.December[21] });
            gridEntities.Add(new GridEntity {  Day = "Tues", January = gridMonth.January[22], Feburary = gridMonth.Feburary[22], March = gridMonth.March[22], April = gridMonth.April[22], May = gridMonth.May[22], June = gridMonth.June[22], July = gridMonth.July[22], Augast = gridMonth.Augast[22], September = gridMonth.September[22], October = gridMonth.October[22], November = gridMonth.November[22], December = gridMonth.December[22] });
            gridEntities.Add(new GridEntity {  Day = "Wed", January = gridMonth.January[23], Feburary = gridMonth.Feburary[23], March = gridMonth.March[23], April = gridMonth.April[23], May = gridMonth.May[23], June = gridMonth.June[23], July = gridMonth.July[23], Augast = gridMonth.Augast[23], September = gridMonth.September[23], October = gridMonth.October[23], November = gridMonth.November[23], December = gridMonth.December[23] });
            gridEntities.Add(new GridEntity {  Day = "Thu", January = gridMonth.January[24], Feburary = gridMonth.Feburary[24], March = gridMonth.March[24], April = gridMonth.April[24], May = gridMonth.May[24], June = gridMonth.June[24], July = gridMonth.July[24], Augast = gridMonth.Augast[24], September = gridMonth.September[24], October = gridMonth.October[24], November = gridMonth.November[24], December = gridMonth.December[24] });
            gridEntities.Add(new GridEntity {  Day = "Fri", January = gridMonth.January[25], Feburary = gridMonth.Feburary[25], March = gridMonth.March[25], April = gridMonth.April[25], May = gridMonth.May[25], June = gridMonth.June[25], July = gridMonth.July[25], Augast = gridMonth.Augast[25], September = gridMonth.September[25], October = gridMonth.October[25], November = gridMonth.November[25], December = gridMonth.December[25] });
            gridEntities.Add(new GridEntity {  Day = "Sat", January = gridMonth.January[26], Feburary = gridMonth.Feburary[26], March = gridMonth.March[26], April = gridMonth.April[26], May = gridMonth.May[26], June = gridMonth.June[26], July = gridMonth.July[26], Augast = gridMonth.Augast[26], September = gridMonth.September[26], October = gridMonth.October[26], November = gridMonth.November[26], December = gridMonth.December[26] });
            gridEntities.Add(new GridEntity {  Day = "Sun", January = gridMonth.January[27], Feburary = gridMonth.Feburary[27], March = gridMonth.March[27], April = gridMonth.April[27], May = gridMonth.May[27], June = gridMonth.June[27], July = gridMonth.July[27], Augast = gridMonth.Augast[27], September = gridMonth.September[27], October = gridMonth.October[27], November = gridMonth.November[27], December = gridMonth.December[27] });

            gridEntities.Add(new GridEntity { Day = "Mon", January = gridMonth.January[28], Feburary = gridMonth.Feburary[28], March = gridMonth.March[28], April = gridMonth.April[28], May = gridMonth.May[28], June = gridMonth.June[28], July = gridMonth.July[28], Augast = gridMonth.Augast[28], September = gridMonth.September[28], October = gridMonth.October[28], November = gridMonth.November[28], December = gridMonth.December[28] });
            gridEntities.Add(new GridEntity { Day = "Tues", January = gridMonth.January[29], Feburary = gridMonth.Feburary[29], March = gridMonth.March[29], April = gridMonth.April[29], May = gridMonth.May[29], June = gridMonth.June[29], July = gridMonth.July[29], Augast = gridMonth.Augast[29], September = gridMonth.September[29], October = gridMonth.October[29], November = gridMonth.November[29], December = gridMonth.December[29] });
            gridEntities.Add(new GridEntity { Day = "Wed", January = gridMonth.January[30], Feburary = gridMonth.Feburary[30], March = gridMonth.March[30], April = gridMonth.April[30], May = gridMonth.May[30], June = gridMonth.June[30], July = gridMonth.July[30], Augast = gridMonth.Augast[30], September = gridMonth.September[30], October = gridMonth.October[30], November = gridMonth.November[30], December = gridMonth.December[30] });
            gridEntities.Add(new GridEntity { Day = "Thu", January = gridMonth.January[31], Feburary = gridMonth.Feburary[31], March = gridMonth.March[31], April = gridMonth.April[31], May = gridMonth.May[31], June = gridMonth.June[31], July = gridMonth.July[31], Augast = gridMonth.Augast[31], September = gridMonth.September[31], October = gridMonth.October[31], November = gridMonth.November[31], December = gridMonth.December[31] });
            gridEntities.Add(new GridEntity { Day = "Fri", January = gridMonth.January[32], Feburary = gridMonth.Feburary[32], March = gridMonth.March[32], April = gridMonth.April[32], May = gridMonth.May[32], June = gridMonth.June[32], July = gridMonth.July[32], Augast = gridMonth.Augast[32], September = gridMonth.September[32], October = gridMonth.October[32], November = gridMonth.November[32], December = gridMonth.December[32] });
            gridEntities.Add(new GridEntity { Day = "Sat", January = gridMonth.January[33], Feburary = gridMonth.Feburary[33], March = gridMonth.March[33], April = gridMonth.April[33], May = gridMonth.May[33], June = gridMonth.June[33], July = gridMonth.July[33], Augast = gridMonth.Augast[33], September = gridMonth.September[33], October = gridMonth.October[33], November = gridMonth.November[33], December = gridMonth.December[33] });
            gridEntities.Add(new GridEntity {  Day = "Sun", January = gridMonth.January[34], Feburary = gridMonth.Feburary[34], March = gridMonth.March[34], April = gridMonth.April[34], May = gridMonth.May[34], June = gridMonth.June[34], July = gridMonth.July[34], Augast = gridMonth.Augast[34], September = gridMonth.September[34], October = gridMonth.October[34], November = gridMonth.November[34], December = gridMonth.December[34] });

            gridEntities.Add(new GridEntity {  Day = "Mon", January = gridMonth.January[35], Feburary = gridMonth.Feburary[35], March = gridMonth.March[35], April = gridMonth.April[35], May = gridMonth.May[35], June = gridMonth.June[35], July = gridMonth.July[35], Augast = gridMonth.Augast[35], September = gridMonth.September[35], October = gridMonth.October[35], November = gridMonth.November[35], December = gridMonth.December[35] });
            gridEntities.Add(new GridEntity {  Day = "Tues", January = gridMonth.January[36], Feburary = gridMonth.Feburary[36], March = gridMonth.March[36], April = gridMonth.April[36], May = gridMonth.May[36], June = gridMonth.June[36], July = gridMonth.July[36], Augast = gridMonth.Augast[36], September = gridMonth.September[36], October = gridMonth.October[36], November = gridMonth.November[36], December = gridMonth.December[36] });
            return gridEntities;
        }
    }

    public class GridMonth
    {
        public List<int?> January { get; set; }
        public List<int?> Feburary { get; set; }
        public List<int?> March { get; set; }
        public List<int?> April { get; set; }
        public List<int?> May { get; set; }
        public List<int?> June { get; set; }
        public List<int?> July { get; set; }
        public List<int?> Augast { get; set; }
        public List<int?> September { get; set; }
        public List<int?> October { get; set; }
        public List<int?> November { get; set; }
        public List<int?> December { get; set; }
    }

    public class ShiftDetail
    {
        public int EmployeeID { get; set; }
        public Shift Shift { get; set; }
        public int Month { get; set; }
        public int Date { get; set; }
        public int Year { get; set; }


        public string GetStringValue(int year)
        {
            DateTime dateTime = new DateTime(year, Month, Date);
            return EmployeeID + "\t" + Shift.ToString() + "             "+ dateTime.ToShortDateString();
        }
    }
}
