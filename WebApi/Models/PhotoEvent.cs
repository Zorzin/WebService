public class PhotoEvent
    {
        public int PhotoEventID { get; set; }
        
        public int PhotoID { get; set; }
        
        public int EventID { get; set; }

        public  Event Event { get; set; }
        public  Photo Photo { get; set; }
    }