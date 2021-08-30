using System;
namespace Laba2._1.Net
{
    [Serializable]
    public class Kabinet
    {
        public Avtorization Login;
        public string Name;
        public int Age;

        public Kabinet() { }

        public Kabinet(string name, int age, Avtorization n)
        {
            Name = name;
            Login = n;
            Age = age;

        }


    }
}
