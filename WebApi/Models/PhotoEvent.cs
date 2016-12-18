public class PhotoEvent
    {
        public int PhotoEventID { get; set; }
        
        public int PhotoID { get; set; }
        
        public int EventID { get; set; }

        public virtual Event Event { get; set; }
        public virtual Photo Photo { get; set; }
    }