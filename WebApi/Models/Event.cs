using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Event
    {
        public int EventID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public bool Active { get; set; }
        public bool Viewable { get; set; }
        public bool Gameable{ get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<PhotoEvent> PhotoEvents { get; set; }
        public virtual ICollection<UserEvent> UserGames { get; set; }
    }