using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Event
    {
        public int EventID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool Active { get; set; }
        public bool Viewable { get; set; }
        public string Baner { get;set;}

        public  ICollection<Activity> Activities { get; set; }
        public  ICollection<PhotoEvent> PhotoEvents { get; set; }
    }