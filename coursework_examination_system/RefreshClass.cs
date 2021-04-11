using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_examination_system
{
    public class RefreshClass
    {
        public delegate void EventButtonClickHandler(Object source, EventArgs e);
        public event EventButtonClickHandler events;
        public delegate void EventRefreshResultHandler(Object source, EventArgs e);
        public event EventRefreshResultHandler eventsResult;

        public void StartRefreshEvent(Object sender, EventArgs e)
        {
            if (this.events != null)
            {
                events.Invoke(sender, e);
            }
        }

        public void StartRefreshResultEvent(Object sender, EventArgs e)
        {
            if (this.eventsResult != null)
            {
                eventsResult.Invoke(sender, e);
            }
        }
    }
}
