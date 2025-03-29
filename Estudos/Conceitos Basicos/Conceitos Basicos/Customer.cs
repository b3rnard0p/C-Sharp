using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_Basicos
{
    internal class Customer
    {
        //Atributos
        public string Name {  get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }

        //Construtor
        //public Customer(string Name, string Address, DateTime Birthday)
        //{
        //    this.Name = Name;
        //    this.Address = Address;
        //    this.Birthday = Birthday;
        //}

        //Método usando os atributos
        public void SendWelcomeKit()
        {
            Console.WriteLine("Welcome " + Name + "! Your credit card is on the way.");
        }
    }
}
