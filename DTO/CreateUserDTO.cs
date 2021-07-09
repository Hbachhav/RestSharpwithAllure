using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharpTest
{
   public class CreateUserDTO
    {

        
        public string Name { get; set; }
        public string Job { get; set; }
        public long Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
    
}
}
