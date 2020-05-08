using System;

namespace GANDO.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string FirstName { get; set; }

        public string Surname { get; set; }
       
        public int Age { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }


    }
}
