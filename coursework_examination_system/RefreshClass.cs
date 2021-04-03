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

        public void StartRefreshEvent(Object sender, EventArgs e)
        {
            if (this.events != null)
            {
                events.Invoke(sender, e);
            }
        }
    }
}
