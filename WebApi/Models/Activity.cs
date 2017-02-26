using System;

public class Activity
    {
        public int ActivityID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime EndHour { get; set; }
        public int PlaceID { get; set; }
        public int EventID { get; set; }

        public  Place Place { get; set; }
        public Event Event { get; set; }
    }