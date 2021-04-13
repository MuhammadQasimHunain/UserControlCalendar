using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarUserControl
{
    public interface ICalendarEvent
    {
        bool ShouldRender(DateTime calendarDate);
        Color BackgroundColor { get; }
        Color TextColor { get; }
        Font Font { get; }
        string EventName { get; }
        string EventId { get; }
        int EventHeight { get; }
        bool ShowIcon { get; }
        Bitmap Icon { get; }
    }
}
