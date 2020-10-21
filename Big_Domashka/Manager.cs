using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Big_Domashka
{
    public class Manager : Person
    {
        public Guid id { get; set; }

        public string role = "manager";
        public  string login { get; set; }
        public int password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string phonenumber { get; set; } // зачем вообще хоть что то делать приватным
    }
}
