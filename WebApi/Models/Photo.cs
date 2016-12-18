using System.Collections.Generic;

public class Photo
    {
        public int PhotoID { get; set; }
        public string Source { get; set; }
        public string Text { get; set; }

        public virtual ICollection<PhotoEvent> PhotoEvents { get; set; }
    }