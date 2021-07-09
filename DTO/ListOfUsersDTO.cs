using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpTest
{
   public partial class ListOfUsersDTO
    {
      
            public long Page { get; set; }
            public long PerPage { get; set; }
            public long Total { get; set; }
            public long TotalPages { get; set; }
            public List<Datum> Data { get; set; }
            
        }

        public partial class Datum
        {
            public long Id { get; set; }
            public string Email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public Uri Avatar { get; set; }
        }

        
    }



