using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityOfignition
{
    public class LevelOne :LevelBase
    {
        private double _posi=0.05;
        private double _poni ;
        private double _poii ;
        private double _podiIndoor ;
        private double _podiOutdoor;
        public override double POSI
        {
            get
            {
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
                if (temp<0.9)
                {
                    _poni = 0;
                }
                else if(temp>1.2)
                {
                    _poni = 1;
                }
                else 
                {
                    _poni=  1 - 5000 * Math.Exp(-9.5 * temp);
                }
                return Math.Round( _poni,3);
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
                _poii = 0.05 + (1 - 0.05) * _poni;
                return Math.Round(_poii,3);
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
                _podiOutdoor = 0.15 - 0.25 * Math.Log(Chemical.MIE,10);
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
                _podiIndoor = 1.5 * PODIOutdoor;
                return Math.Round(_podiIndoor,3);
            }

            set
            {
                _podiIndoor = value;
            }
        }
        public LevelOne(Chemical chemical) : base(chemical)
        {
        }
        private LevelOne() { }
       
       

    }
}
