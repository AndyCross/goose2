using System.Collections.Generic;

namespace goose2s.Models {
    public class UserProfile {
        public string country { get; set; }
        public string display_name { get; set; }
        public Dictionary<string,string> external_urls { get; set; }
        public string href { get; set; }
        public string id { get; set; }
        public Image[] images { get; set; }
        public string product { get; set; }
        public string type { get; set; }
        public string uri { get; set; }
        public long HeartBeat {get;set;}
    }
}