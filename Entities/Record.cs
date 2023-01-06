using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Record
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Adress { get; set; }
        public string EmailAdress { get; set; }
        public string WebSite { get; set; }
        public string Explain { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }
}
