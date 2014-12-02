using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGroep03_2013_2014_
{
    public class User
    {
        int userID;
        String userName, password;
        private List<Event> events;

        #region constructor
        public User(int id,String name,string passwd) : this(id,name,passwd,new List<Event>()){}
        public User(int id, string name, string password, List<Event> events)
        {
            userID = id;
            userName = name;
            this.password = password;
            this.events = events;
        }
        #endregion constructors

        #region properties
        public int UserID
        {
            get { return userID; }
        }
        public String UserName
        {
            get { return userName; }
        }
        public List<Event> EventList
        {
            get { return events; }
        }
        #endregion properties

    }
}
