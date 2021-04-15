using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework_examination_system
{
    //Класс для запуска события
    public class RefreshClass
    {
        //Делегат указывающий на метод для обновления списков с тестами
        public delegate void EventButtonClickHandler(Object source, EventArgs e);
        //Событие для обновления тестов
        public event EventButtonClickHandler events;
        //Делегат указывающий на метод для обновления списков с результатами тестирования
        public delegate void EventRefreshResultHandler(Object source, EventArgs e);
        //Событие для обновления списков с результатами тестирования
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
