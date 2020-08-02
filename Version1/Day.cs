using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
    class Day
    {
        private int _Id;
        private DateTime _Date;
        private double _Water;
        private int _Kcal;
        private double _Protein;
        private double _Fat;
        private double _Carb;
        private double _Fiber;
        private string _Exercise;
        private int _Id_Person;

        public int Id { get => _Id; set => _Id = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public double Water { get => _Water; set => _Water = value; }
        public int Kcal { get => _Kcal; set => _Kcal = value; }
        public double Protein { get => _Protein; set => _Protein = value; }
        public double Fat { get => _Fat; set => _Fat = value; }
        public double Carb { get => _Carb; set => _Carb = value; }
        public double Fiber { get => _Fiber; set => _Fiber = value; }
        public string Exercise { get => _Exercise; set => _Exercise = value; }
        public int Id_Person { get => _Id_Person; set => _Id_Person = value; }
    }
}
