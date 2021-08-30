using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization;

namespace Laba2._1.Net
{


    class Program
    {
        static void Main(string[] args)
        {



           /* Console.WriteLine("Enter your id");
            int i = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter your password");
            string p = Console.ReadLine();
            Console.WriteLine("Enter your name");
            string n = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int a = Convert.ToInt32(Console.ReadLine());

            Kabinet name = new Kabinet(n, a, new Avtorization(i, p));

          SoapFormatter serializer = new SoapFormatter();

             FileStream fs = File.Create("SoapFile.soap");

             serializer.Serialize(fs, name);

              Console.WriteLine("Объект сериализован");
            fs.Close();*/


            FileStream fs = new FileStream("SoapFile.soap", FileMode.Open);
            SoapFormatter serializer1 = new SoapFormatter();
            Kabinet name1 = (Kabinet)serializer1.Deserialize(fs);
            Console.WriteLine("Id:" + name1.Login.ID);
            Console.WriteLine("Password:" + name1.Login.Password);
            Console.WriteLine("Name:" + name1.Name);
            Console.WriteLine("Age:" + name1.Age);
            fs.Close();
            Console.ReadKey();



        }
    }

}
