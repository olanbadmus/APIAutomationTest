using System;
using System.Collections.Generic;
using System.Text;

namespace APIAutomationDemo.RestHelper
{
    
        public partial class ListOfUsersDTO
        {
            public long Page { get; set; }
            public long PerPage { get; set; }
            public long Total { get; set; }
            public long TotalPages { get; set; }
            public List<Data> Data { get; set; }
            //public Ad Ad { get; set; }
        }

        //public partial class Ad
        //{
        //    public string company { get; set; }
        //    public Uri url { get; set; }
        //    public string text { get; set; }
        //}


    public partial class Data
        {
            public long id { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public Uri avatar { get; set; }
            public string company { get; set; }
            public string url { get; set; }
            public string text { get; set; }
    }
        
        public class CreatUserInfo
        {
            public string name { get; set; }
            public string job { get; set; }
            public DateTime date { get; set; }

        }


    
}
