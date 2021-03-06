using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalendarUserControl.HolidayEvents
{
    public class Halloween : ICalendarEvent
    {
        public Halloween()
        {
            EventId = Guid.NewGuid().ToString();

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            using (Stream myStream = myAssembly.GetManifestResourceStream("CalendarUserControl.HolidayIcons.Pumpkin.png"))
            {
                Icon = null;
                if (myStream != null) Icon = new Bitmap(myStream);
            }
        }

        public bool ShouldRender(DateTime calendarDate)
        {
            return calendarDate.Month == 10 && calendarDate.Day == 31;
        }

        public Color BackgroundColor => Color.Orange;
        public Color TextColor => Color.Black;
        public Font Font => new Font("Arial", 10, FontStyle.Regular);
        public string EventName => "Halloween";
        public string EventId { get; }
        public int EventHeight => 34;
        public bool ShowIcon => true;
        public Bitmap Icon
        {
            get;
        }
    }
}
