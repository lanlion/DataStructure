using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityOfignition
{
    public class LevelTwo : LevelBase
    {
        private double _posi;
        private double _poni;
        private double _poii;
        private double _podiIndoor;
        private double _podiOutdoor;
        public override double POSI
        {
            get
            {
                _posi = 0.003 * Math.Pow(Chemical.Pressure, 1 / 3)*Math.Pow(Chemical.MIE_Adj,-0.6);
                return _posi;
            }

            set
            {
                _posi = value;

            }
        }

        public override double PONI
        {
            get
            {
                var temp = Chemical.Temperature / Chemical.AIT;
                if (temp < 0.9)
                {
                    _poni = 0;
                }
                else if (temp > 1.2)
                {
                    _poni = 1;
                }
                else
                {
                    _poni = 1 - 5000 * Math.Exp(-9.5 * temp);
                }
                return _poni;
              
            }

            set
            {
                _poni = value;
            }
        }

        public override double POII
        {
            get
            {
                _poii = PONI + (1 - PONI) * POSI;
                return _poii;
            }

            set
            {
                _poii = value;
            }
        }

        public override double PODIOutdoor
        {
            get
            {
                _podiOutdoor = 0.15 - 0.25 * Math.Log(Chemical.MIE);
                return _podiOutdoor;
            }

            set
            {
                _podiOutdoor = value;
            }
        }
        public override double PODIIndoor
        {
            get
            {
                _podiIndoor = 1.5 * PODIOutdoor;
                return _podiIndoor;
            }

            set
            {
                _podiIndoor = value;
            }
        }
        public LevelTwo(Chemical chemical) : base(chemical)
        {
        }
        private LevelTwo() { }



    }
}
