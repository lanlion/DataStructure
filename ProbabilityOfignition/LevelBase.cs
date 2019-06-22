using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbabilityOfignition
{
    public abstract class LevelBase
    {
        private Chemical _chemical;
        private double _temperature;
        public Chemical Chemical
        {

            get { return _chemical; }
            set { _chemical = value; }
        }
        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }
        public LevelBase(Chemical chemical, double temperature)
        {
            _chemical = chemical;
            _temperature = temperature;
        }
        public LevelBase() { }
        /// <summary>
        /// 静态引燃
        /// </summary>
        /// <returns></returns>
        public abstract double StaticIgnition { get; set; }
        /// <summary>
        /// 自然引燃
        /// </summary>
        /// <returns></returns>
        public abstract double NaturalIgnition { get; set; }
        /// <summary>
        /// 立即引燃
        /// </summary>
        /// <returns></returns>
        public abstract double ImmediateIgnition { get; set; }
        /// <summary>
        /// 延迟引燃
        /// </summary>
        /// <returns></returns>
        public abstract double DelayedIgnition { get; set; }
    }
}
