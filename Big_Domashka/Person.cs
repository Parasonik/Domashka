using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Big_Domashka
{
    public class Person
    {
        public static List<Manager> users_Manager = new List<Manager>();
        public static List<Buyer> users_Buyer = new List<Buyer>();
        public Guid id { get; set; }

        public string role;
        public string login { get; set; }
        public int password { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private string phoneNumber { get; set; }
        public Person()
        {

        }
        public Person(Manager manager)
        {
            id = manager.id;
            role = manager.role;
            login = manager.login;
            password = manager.password;
            name = manager.name;
            surname = manager.surname;
            phoneNumber = manager.phonenumber;
        }
        public Person(Buyer buyer) 
        {
            id = buyer.id;
            role = buyer.role;
            login = buyer.login;
            password = buyer.password;
            name = buyer.name;
            surname = buyer.surname;
            phoneNumber = buyer.phonenumber;
        }
        private static Person FindUsers_Manager_And_Prove(string login_check, int password_check, List<Manager> user)
        {
            var person1 = user.Find(m => m.login == login_check);
            if (person1 != null && person1.password.Equals(password_check))
            {
                Person person = new Person(person1);
                return person1;
            }
            return null;
        }
        private static Person FindUsers_Manager_And_Prove(string login_check, int password_check, List<Buyer> user)
        {
            var person1 = user.Find(m => m.login == login_check);
            if (person1 != null && person1.password.Equals(password_check))
            {
                Person person = new Person(person1);
                return person1;
            }
            return null;
        }
        public static Person Sign_in()
        {
            Console.Write("Введите логин  ");
            string login_check = Console.ReadLine();
            Console.Write("Введите пароль  ");
            int password_check = (Console.ReadLine()).GetHashCode();
            FindUsers_Manager_And_Prove(login_check,password_check, users_Manager);
            FindUsers_Manager_And_Prove(login_check, password_check, users_Buyer);
            var manager = users_Manager.Find(m => m.login == login_check);
            
            if (manager != null && manager.password.Equals(password_check)) {
                Person person = new Person(manager);
                return person;
            }
            var buyer = users_Buyer.Find(m => m.login == login_check);
            
            if (buyer != null && buyer.password.Equals(password_check)) {
                Person person = new Person(buyer);
                return person; 
            }
            return null;

            //for (int i = 0; i < users_Manager.Count; i++)
            //{

            //    if (users_Manager.ElementAt<Manager>(i).login == login_check)
            //    { 
            //        Console.Write("Введите пароль  ");
            //        int password_check = (Console.ReadLine()).GetHashCode();
            //            if (users_Manager.ElementAt<Manager>(i).password == password_check)
            //            {
            //                // как тут не повторять код

            //                return i;
            //            }
            //    }

            //}
            //for (int i = 0; i <users_Manager_buyer.Count; i++)
            //{
            //    if (users_Manager_buyer.ElementAt<Buyer>(i).login == login_check)
            //    {
            //        Console.Write("Введите пароль  ");
            //        int password_check = (Console.ReadLine()).GetHashCode();
            //            if (users_Manager_buyer.ElementAt<Buyer>(i).password == password_check)
            //            {
            //                Console.WriteLine("Ура вы вошли в аккаунт");
            //                return i;
            //            }
            //    }
            //}
            //return -1; 
        }
    }
}
