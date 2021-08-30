using System;
namespace Laba2._1.Net
{
    [Serializable]
    public class Avtorization
    {

        public int ID;

        public string Password;
        public Avtorization() { }

        public Avtorization(int id, string password)
        {
            ID = id;
            Password = password;
        }

    }
}
