using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string? Address { get; set; }

        public string Phone { get; set; }
        public override string ToString() => this.ToStringProperty();
        public Client(int id, string name, string? address, string phon)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phon;
        }
        public Client()
        {
            this.Id = 0;
            this.Name = null;
            this.Address = null;
            this.Phone = null;
        }
    }
}
