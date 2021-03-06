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
    public class Christmas : ICalendarEvent
    {
        public Christmas()
        {
            EventId = Guid.NewGuid().ToString();

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            using (Stream myStream = myAssembly.GetManifestResourceStream("CalendarUserControl.HolidayIcons.ChristmasTree.png"))
            {
                Icon = null;
                if (myStream != null) Icon = new Bitmap(myStream);
            }
        }

        public bool ShouldRender(DateTime calendarDate)
        {
            return calendarDate.Month == 12 && calendarDate.Day == 25;
        }

        public Color BackgroundColor => Color.FromArgb(250, 150, 150);
        public Color TextColor => Color.Black;
        public Font Font => new Font("Arial", 10, FontStyle.Regular);
        public string EventName => "Christmas";
        public string EventId { get; }
        public int EventHeight => 34;
        public bool ShowIcon => true;
        public Bitmap Icon
        {
            get;
        }
    }
}
