using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Enumeração_e_Composição.Entities
{
    class Client
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }

        public Client()
        {

        }

        public Client (string Name, string Email, DateTime BirthDate)
        {
            name = Name;
            email = Email;
            birthDate = BirthDate;
        }

        public override string ToString()
        {
            return name +
                ", ("+
                birthDate.ToString("dd/MM/yyyy")+
                ") - "+
                email;
        }
    }
}
