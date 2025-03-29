using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_Basicos
{
    //herança
    internal class CustomerStore : Customer
    {
        //Construtor
        public CustomerStore(string Name, string Address, DateTime Birthday)
        {
            this.Name = Name;
            this.Address = Address;
            this.Birthday = Birthday;
        }
    }
}
