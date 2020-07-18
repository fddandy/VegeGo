using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
     class Update
    {
        private DateTime _Date;

        private float _Weight;

        private string _ActLevel;

        private int _IhHC;
        public DateTime Date { get => _Date; set => _Date = value; }
        public float Weight { get => _Weight; set => _Weight = value; }
        public string ActLevel { get => _ActLevel; set => _ActLevel = value; }
        public int IhHC { get => _IhHC; set => _IhHC = value; }
    }
}
