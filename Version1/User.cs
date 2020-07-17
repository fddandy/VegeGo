using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
    public class User
    {
        private int _Id;

        private string _Name;

        private string _SurName;

        private string _Login;

        private string _Password;

        public string Name { get => _Name; set => _Name = value; }
        public string SurName { get => _SurName; set => _SurName = value; }
        public string Login { get => _Login;}
        public string Password { get => _Password; }
        public int Id { get => _Id; set => _Id = value; }
        public User(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            SurName = surname;
        }
    }
}
