using System;
using System.Collections.Generic;
using System.Text;

namespace Domashka_2
{
    public partial class Student
    {
        static int Kolvo;
        const string Univesrity= "BSUIR";
        public long id { get; private set; } //возможно ли иметь readonly у свойста
        private long phoneNumber;
        private long groupNumber;
        private string name;
        private string surname;
        private string lastname;
        private string address;
        private string faculty;
        private DateTime birthday;
        private byte courseNumber;
        //readonly public long Id {
        //    get { return id; } set { if (value > 0) { id = value; } else { Console.WriteLine("Id не может быть отрицательным"); } }
        //}
        public long PhoneNumber {
            get { return phoneNumber; } private set { if (value > 0) { phoneNumber = value; } else { Console.WriteLine("Номер телефона не может быть отрицательным"); if (value < 1000000000 && value > 99999999) { phoneNumber = value; } else { Console.WriteLine("Номер телефона не может содержать больше 9 цифр"); } } } 
        }
        public long GroupNumber {
            get { return groupNumber; } set { if (value > 0) { groupNumber = value; } else { Console.WriteLine("Номер группы не может быть отрицательным"); } } }
        public string Name
        {
            get => name; set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Это поле должно быть заполнено");
                name = value;
            }
        }
        public string Surname
        {
            get => surname; set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Это поле должно быть заполнено");
                surname = value;
            }
        }
        public string Lastname
        {
            get => lastname; set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Это поле должно быть заполнено");
                lastname = value;
            }
        }
        public string Address
        {
            get => address; set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Это поле должно быть заполнено");
                address = value;
            }
        }
        public string Faculty
        {
            get => faculty; set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Это поле должно быть заполнено");
                faculty = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                DateTime proverka = new DateTime(1870);
                if (DateTime.Today >= value && value.Year > proverka.Year)
                { birthday = value; }
                else
                { Console.WriteLine("Ошибка"); }
            }
        }
        public byte CourseNumber {
            get { return courseNumber; } set { if (value > 0) { courseNumber = value; } else { Console.WriteLine("номер курса не может быть отрицательным"); 
                } } }
        //private Student() 
        //{ }
        public Student(long k)
        {
            if (k <= 0)
            {
                Console.WriteLine("Id не может быть отрицательным");
            }
            else
            {
                id = k;
            }
            Kolvo++;
        }
        public Student()
        {
            
            Kolvo++;
        }
        public Student(byte a)
        {
            CourseNumber = a;
            Kolvo++;
        }
        public Student(string b, long c)
        {
            Faculty = "CD";
            id = 912601;
            Kolvo++;
        }
        static Student()
        {
            Console.WriteLine("Это сообщение покажется при создании объекта этого класса только в первый раз");
            
        }
        public int Age(DateTime Birthday)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - Birthday.Year;
            if (Birthday > now.AddYears(-age)) age--;
            return age;
        }
        public void Do_something(ref int x, out int z)
        {
            z = x + 5;
        }
        public void Amount()
        {
            Console.WriteLine(Kolvo);
        }
        
    }
}
