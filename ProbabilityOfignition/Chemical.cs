using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityOfignition
{
    public class Chemical
    {
        public string Name { get; set; }
        public double MIE { get; set; }

        private double _mie_v;
        public double MIE_V {

            get {
                if (Pressure!=0)
                {
                    _mie_v = MIE * Math.Pow(10000 / Pressure, 0.25);
                }              
                return _mie_v;
            }
            set { _mie_v = value; } }
        private double _mie_adj;
        public double MIE_Adj {
            get {
                if (MIE_V!=0)
                {
                    _mie_adj = MIE_V * Math.Exp(0.0044*(60-Temperature));
                }
                return _mie_adj;
            }

            set { _mie_adj = value; }

        }
        public double AIT { get; set; }
        public string Reactivity { get; set; }
        public double NBP { get; set; }
        public double FP { get; set; }
        /// <summary>
        /// 温度
        /// </summary>
        public double Temperature;
        /// <summary>
        /// 压力
        /// </summary>
        public double Pressure;
    }

    public class ChemicalHelper
    {
        private ChemicalHelper() { }

        private static  ChemicalHelper _Instance = new ChemicalHelper();
        public static ChemicalHelper Instance
        {
            get
            {
                if (_Instance==null)
                {
                    _Instance = new ChemicalHelper();
                }              
                return _Instance;
            }

        }

        public Chemical GetByName(string name)
        {
            Chemical c = new ProbabilityOfignition.Chemical();
            switch (name)
            {
                case "Acetaldehyde":
                    c.MIE = 0.13;
                    c.AIT = 347;
                    c.NBP = 68.54;
                    c.FP = -36.04;
                    break;
                case "Acetone":                 
                    c.MIE = 0.19;
                    c.AIT = 869;
                    c.NBP = 132.98;
                    c.FP = -0.04;
                    break;
                case "Acrolein":               
                    c.MIE = 0.13;
                    c.AIT = 455;
                    c.NBP = 126.5;
                    c.FP = -14.8;
                    break;
                default:
                    break;
            }
            return c;
        }
    }
}
