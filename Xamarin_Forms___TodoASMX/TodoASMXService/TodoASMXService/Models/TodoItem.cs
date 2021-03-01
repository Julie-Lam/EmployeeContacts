using System;

namespace TodoASMXService.Models
{
    [Serializable]
    public class TodoItem
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Department { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZIP { get; set; }

        public string Country { get; set; }
        //public string Address { get; set; }
        //public int Age { get; set; }

        //public string AllowedToDrive { get; set; }

        //public string Notes { get; set; }

        //public bool Done { get; set; }
    }
}
