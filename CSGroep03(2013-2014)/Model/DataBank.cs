using CSGroep03_2013_2014_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSGroep03_2013_2014_.Model.CSGroep03DataSetTableAdapters;

namespace CSGroep03_2013_2014_
{
    class DataBank
    {
        static DataBank databankInstantie = new DataBank();
        CSGroep03DataSet ds;
        EventsTableAdapter tableEvents;
        UsersTableAdapter tableUser;
        Users_EventsTableAdapter tableUserEvents;

        private DataBank()
        {

            ds = new CSGroep03DataSet();
            tableEvents = new EventsTableAdapter();
            tableUser = new UsersTableAdapter();
            tableUserEvents = new Users_EventsTableAdapter();

        }

        public static DataBank DatabankInstantie
        {
            get { return DataBank.databankInstantie; }
        }

        public List<Event> leesEventsToekomstvrij()
        {
            tableEvents.FillByToekomstvrij(ds.Events);
            List<Event> lijstevents = new List<Event>();
            for (int i = 0; i < ds.Events.Rows.Count; i++)
            {
                Event events = new Event(ds.Events[i].eventID,
                    ds.Events[i].subscriptions,
                    ds.Events[i].maxsubscriptions,
                    ds.Events[i].eventname,
                    ds.Events[i].eventdate,
                    ds.Events[i].organisator);
                lijstevents.Add(events);
            }
            return lijstevents;
        }
        public List<Event> leesEventsToekomstvolzet()
        {
            tableEvents.FillBytoekomstvolzet(ds.Events);
            List<Event> lijstevents = new List<Event>();
            for (int i = 0; i < ds.Events.Rows.Count; i++)
            {
                Event events = new Event(ds.Events[i].eventID,
                    ds.Events[i].subscriptions,
                    ds.Events[i].maxsubscriptions,
                    ds.Events[i].eventname,
                    ds.Events[i].eventdate,
                    ds.Events[i].organisator);
                lijstevents.Add(events);
            }
            return lijstevents;
        }
        public List<Event> leesEventsverleden()
        {
            tableEvents.FillByverleden(ds.Events);
            List<Event> lijstevents = new List<Event>();
            for (int i = 0; i < ds.Events.Rows.Count; i++)
            {
                Event events = new Event(ds.Events[i].eventID,
                    ds.Events[i].subscriptions,
                    ds.Events[i].maxsubscriptions,
                    ds.Events[i].eventname,
                    ds.Events[i].eventdate,
                    ds.Events[i].organisator);
                lijstevents.Add(events);
            }
            return lijstevents;
        }
        public Event LeesEvent(int eventID)
        {
            tableEvents.FillByEventID(ds.Events, eventID);
            if (ds.Events.Rows.Count != 0)
            {
                Event evnt = new Event(ds.Events[0].eventID, ds.Events[0].subscriptions,
                                       ds.Events[0].maxsubscriptions, ds.Events[0].eventname,
                                       ds.Events[0].eventdate, ds.Events[0].organisator);
                return evnt;
            }
            else
                throw new Exception("Geen event met deze eventID");
        }
        public List<Event> leesMijnEvents(User user)
        {
            tableEvents.FillEventsByUserID(ds.Events, user.UserID);
            List<Event> lijstevents = new List<Event>();
            for (int i = 0; i < ds.Events.Rows.Count; i++)
            {
                Event events = new Event(ds.Events[i].eventID,
                    ds.Events[i].subscriptions,
                    ds.Events[i].maxsubscriptions,
                    ds.Events[i].eventname,
                    ds.Events[i].eventdate,
                    ds.Events[i].organisator);
                lijstevents.Add(events);
            }
            return lijstevents;
        }

        public void NieuwEvent(Event events)
        {
            ds.Events.Clear();
            CSGroep03DataSet.EventsRow rij = ds.Events.NewEventsRow();
            VulEventRij(rij, events);
            ds.Events.Rows.Add(rij);
            tableEvents.Update(ds.Events);

            events = new Event(rij.eventID, rij.subscriptions, rij.maxsubscriptions, rij.eventname, rij.eventdate, rij.organisator);
        }
        public void VerminderAantalInschrijvingen(Event evt)
        {
            tableEvents.DecrementSubscriptions(evt.EventId);
        }
        public void VermeerderAantalInschrijvingen(Event evt)
        {
            tableEvents.IncrementSubscriptions(evt.EventId);
        }
        public Event GetLatestInfoEvent(Event evt)
        {
            tableEvents.GetEventByID(ds.Events, evt.EventId);
            Event eventTemp = new Event(ds.Events[0].eventID, ds.Events[0].subscriptions, ds.Events[0].maxsubscriptions, ds.Events[0].eventname, ds.Events[0].eventdate, ds.Events[0].organisator);
            return eventTemp;
        }

        public void VerwijderEventFromUser(User user, Event evt)
        {

            tableUserEvents.DeleteEventFromUser(user.UserID, evt.EventId);
        }
        public void Inschrijven(User user, Event evt)
        {
            tableUserEvents.AddEventToUser(user.UserID, evt.EventId);
        }
        public User getUser(string gebruikersnaam, string wachtwoord)
        {
            tableUser.getUser(ds.Users, gebruikersnaam, wachtwoord);
            User user = new User(ds.Users[0].userID, ds.Users[0].username, ds.Users[0].password);
            return user;
        }
        public void addUser(string gebruikersnaam, string wachtwoord)
        {
            tableUser.addUser(gebruikersnaam, wachtwoord);
        }
        public string getUsernameByUserID(int organisator)
        {
            ds.Users.Clear();
            tableUser.getUsernameByUserID(ds.Users, organisator);
            if (ds.Users.Rows.Count == 0)
                return "";
            else
                return ds.Users[0].username;
        }
        public void UpdateUser(string wachtwoord, string gebruikersnaam)
        {
            tableUser.Update1(wachtwoord, gebruikersnaam);
        }

        public bool checkGebruikersnaamEnWachtwoord(string Gebruikersnaam, string Wachtwoord)
        {
            tableUser.checkGebruikersnaamEnWachtwoord(ds.Users, Gebruikersnaam, Wachtwoord);
            if (ds.Users.Rows.Count != 0)
                return true;
            else
                return false;
        }
        public bool checkDuplicatieGebruikersnaam(string Gebruikersnaam)
        {
            tableUser.checkDuplicatieVanGebruikersnaam(ds.Users, Gebruikersnaam);
            if (ds.Users.Rows.Count == 0)
                return true;
            else
                return false;
        }
        public bool AlreadySubscribed(User ingelogdeUser, Event evt)
        {
            tableUserEvents.CheckIfExists(ds.Users_Events, ingelogdeUser.UserID, evt.EventId);
            if (ds.Users_Events.Count == 0)
                return false;
            else
                return true;
        }

        private void VulEventRij(CSGroep03DataSet.EventsRow rij, Event events)
        {
            rij.eventname = events.EventName;
            rij.eventdate = events.EventDate;
            rij.maxsubscriptions = (byte)events.Maxsubscriptions;
            rij.subscriptions = (byte)events.Subscriptions;
            rij.organisator = (byte)events.Organisator;
        }
    }
}
