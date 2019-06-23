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
                return Math.Round(_posi,3);
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
                return Math.Round(_poni,3);
              
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
                return Math.Round(_poii,3);
            }

            set
            {
                _poii = value;
            }
        }

     
      
        //sd*mag*mat*mt*in(out)
        public override double PODIOutdoor
        {
            get
            {
                _podiOutdoor = Chemical.SD * Chemical.MAG * Chemical.MAT * Chemical.MT * Chemical.OutdoorLeaks;
                return Math.Round(_podiOutdoor,3);
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
                _podiIndoor = Chemical.SD * Chemical.MAG * Chemical.MAT * Chemical.MT * Chemical.IndoordoorLeaks;
                return Math.Round(_podiIndoor,3);
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
