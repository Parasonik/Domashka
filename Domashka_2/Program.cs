using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Domashka_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Joke;
            int x = 5;
            Student Starosta = new Student();
            Student Clown = new Student();
            Student Clown1 = new Student();
            Student Clown2 = new Student();
            Student Clown3 = new Student();
            Student Clown4 = new Student();
            //Console.WriteLine("Введите id студента");
            //Starosta.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите телефонный номер студента");
            //Console.Write("+375");
            //Starosta.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите номер группы студента");
            //Starosta.GroupNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите имя студента");
            //Starosta.Name = Console.ReadLine();
            //Console.WriteLine("Введите фамилию студента");
            //Starosta.Surname = Console.ReadLine();
            //Console.WriteLine("Введите отчество студента");
            //Starosta.Lastname = Console.ReadLine();
            //Console.WriteLine("Введите адрес студента");
            //Starosta.Address = Console.ReadLine();
            //Console.WriteLine("Введите название факультета студента");
            //Starosta.Name = Console.ReadLine();
            //Console.WriteLine("Введите дату рождения студента (год, месяц, день)");
            //Starosta.Birthday = new DateTime( Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) );
            //Console.WriteLine("Введите номер курса студента");
            //Starosta.Id = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine(Starosta.Age(Starosta.Birthday));
            //Starosta.SaySomething();
            Starosta.Amount();
            Starosta.Do_something(ref x,out Joke);
            Console.WriteLine(Joke);
                 
        }
    }
    
}
