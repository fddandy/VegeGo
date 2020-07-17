using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
    public class HealthCard
    {
        int _Id;
        DateTime _BirthDate;
        float _Weight;
        int _Height;
        string _ActLevel;
        int _IdPerson;

        public int Id { get => _Id; set => _Id = value; }
        public float Weight { get => _Weight; set => _Weight = value; }
        public int Height { get => _Height; set => _Height = value; }
        public string ActLevel { get => _ActLevel; set => _ActLevel = value; }
        public int IdPerson { get => _IdPerson; set => _IdPerson = value; }
        public DateTime BirthDate { get => _BirthDate; set => _BirthDate = value; }
    }
}
