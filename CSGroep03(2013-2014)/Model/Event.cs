using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGroep03_2013_2014_
{
    public class Event
    {
        Controller controller;
        int eventId, subscriptions, maxsubscriptions,organisator;
        string eventName;
        DateTime eventDate;

        public Event(int id, int sub, int msub, string name, DateTime date, int org)
        {
            eventId = id;
            subscriptions = sub;
            maxsubscriptions = msub;
            eventName = name;
            eventDate = date;
            organisator = org;
            controller = new Controller();
        }

        #region properties
        public DateTime EventDate
        {
            get { return eventDate; }
        }
        public string EventName
        {
            get { return eventName; }
        }
        public int Maxsubscriptions
        {
            get { return maxsubscriptions; }
        }
        public int Subscriptions
        {
            get { return subscriptions; }
        }
        public int EventId
        {
            get { return eventId; }
        }
        public int Organisator
        {
            get { return organisator; }
        }
        #endregion properties

        #region methods
        public override string ToString()
        {
            string name = "";
            string user = controller.getUsernameByUserID(organisator);
            if (eventName.Length <= 35)
                name = string.Format("{0,-35}", eventName);
            else
            {
                name = eventName.Substring(0,32);
                name += "...";
            }
            return String.Format("{0}\t{1}\t{2}\t{3,5}\t\t{4}", name, EventDate.ToShortDateString(), Subscriptions, Maxsubscriptions,user);
        }
        public override bool Equals(Object obj)
        {
            if (obj is Event)
            {
                Event evt = (Event)obj;
                if (evt.EventId == this.EventId)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        #endregion methods

    }
}
