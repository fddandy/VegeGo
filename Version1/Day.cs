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
        private float _Water;
        private int _Kcal;
        private float _Protein;
        private float _Fat;
        private float _Carb;
        private float _Fiber;
        private string _Exercise;
        private int _Id_Person;

        public int Id { get => _Id; set => _Id = value; }
        public DateTime Date { get => _Date; set => _Date = value; }
        public float Water { get => _Water; set => _Water = value; }
        public int Kcal { get => _Kcal; set => _Kcal = value; }
        public float Protein { get => _Protein; set => _Protein = value; }
        public float Fat { get => _Fat; set => _Fat = value; }
        public float Carb { get => _Carb; set => _Carb = value; }
        public float Fiber { get => _Fiber; set => _Fiber = value; }
        public string Exercise { get => _Exercise; set => _Exercise = value; }
        public int Id_Person { get => _Id_Person; set => _Id_Person = value; }
    }
}
