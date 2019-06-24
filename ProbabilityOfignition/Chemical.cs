using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityOfignition
{
    public class Chemical
    {
        private double _mie_adj;
        private double _mie_v;
        private double _sd;//1-[(1-s2)*e-st]
        private double _mag;
        private double _mat;
        private double _mt;

        public double OutdoorLeaks
        {
            get { return 1.0; }
        } 
        public double IndoordoorLeaks
        {
            get { return 1.5; }
        }
        public string Name { get; set; }
        public double MIE { get; set; }
      
        public double MIE_V
        {

            get
            {
                if (Pressure != 0)
                {
                    if (PhaseEnum == PhaseEnum.Vaqor)
                    {
                        _mie_v = MIE;
                    }
                    else
                    {
                        _mie_v = MIE * Math.Pow(10000 / Pressure, 0.25);
                    }
                
                }
                return _mie_v;
            }
            set { _mie_v = value; }
        }
     
        public double MIE_Adj
        {
            get
            {
                if (MIE_V != 0)
                {
                    _mie_adj = MIE_V * Math.Exp(0.0044 * (60 - Temperature));
                }
                return _mie_adj;
            }

            set { _mie_adj = value; }

        }

        public double SD
        {
            get
            {
                _sd = 1 - ((1 - Math.Pow(Strength, 2) * Math.Exp(-Strength * Temperature)));
                return Math.Round(_sd, 3);
            }
            set
            {
                _sd = value;
            }
        }
        public double MAG
        {
            get
            {
                switch (LeakEnum)
                {
                    case LeakEnum.AmountReleased:
                        switch (PhaseEnum)
                        {
                            case PhaseEnum.Liquid:
                                _mag = Math.Pow(AmountReleased / 5000, 0.3);
                                break;
                            case PhaseEnum.Vaqor:
                                _mag = Math.Pow(AmountReleased / 1000, 0.5);
                                break;
                            default:
                                break;
                        }
                        break;
                    case LeakEnum.HoleDiameter:
                        switch (PhaseEnum)
                        {
                            case PhaseEnum.Liquid:
                                _mag = Math.Pow(HoleDiameter, 0.6);
                                break;
                            case PhaseEnum.Vaqor:
                                _mag = HoleDiameter;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                return _mag;

            }
            set { _mag = value; }
        }

        public double MAT
        {
            get
            {
                _mat = 0.5 - 1.7 * Math.Log10(MIE);
                return _mat;
            }
            set { _mat = value; }
        }

        public double MT
        {
            get {

                _mt = 0.4 + (Temperature - 1.3 * FP) / 230;
                return _mt; }

            set { _mt = value; }

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
        /// <summary>
        /// 点火强度
        /// </summary>
        public double Strength;

        public PhaseEnum PhaseEnum;

        public LeakEnum LeakEnum;
        /// <summary>
        /// 泄露量
        /// </summary>
        public double AmountReleased;
        /// <summary>
        /// 泄露孔直径
        /// </summary>
        public double HoleDiameter;
    }
    public enum PhaseEnum
    {
        Liquid = 0,//:液体
        Vaqor = 1//:水汽
    }

    public enum LeakEnum
    {
        AmountReleased=0,
        HoleDiameter=1

    }
    public class ChemicalHelper
    {
        private ChemicalHelper() { }

        private static ChemicalHelper _Instance = new ChemicalHelper();
        public static ChemicalHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ChemicalHelper();
                }
                return _Instance;
            }

        }

        public Chemical GetByName(string name, Dictionary<string, DataRow> dic)
        {
            Chemical c = new ProbabilityOfignition.Chemical();
            double d;
            if (dic != null && dic.ContainsKey(name))
            {

                if (double.TryParse(dic[name]["MIE (mJ)"]?.ToString(), out d))
                {
                    c.MIE = d;
                }
                if (double.TryParse(dic[name]["AIT (F)"]?.ToString(), out d))
                {
                    c.AIT = d;
                }
                if (double.TryParse(dic[name]["NBP"]?.ToString(), out d))
                {
                    c.NBP = d;
                }
                if (double.TryParse(dic[name]["FP"]?.ToString(), out d))
                {
                    c.FP = d;
                }

            }

            return c;
        }
    }
}
