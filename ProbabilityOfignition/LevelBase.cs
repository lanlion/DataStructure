using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public abstract class LevelBase
    {
       
        private Chemical _chemical;
      
        public Chemical Chemical
        {

            get { return _chemical; }
            set { _chemical = value; }
        }
       
        public LevelBase(Chemical chemical)
        {
            _chemical = chemical;
            
        }
        public LevelBase() { }

      

        /// <summary>
        /// 静态引燃
        /// </summary>
        /// <returns></returns>
        public abstract double POSI { get; set; }
        /// <summary>
        /// 自然引燃
        /// </summary>
        /// <returns></returns>
        public abstract double PONI { get; set; }
        /// <summary>
        /// 立即引燃
        /// </summary>
        /// <returns></returns>
        public abstract double POII { get; set; }
        /// <summary>
        /// 延迟引燃--室内
        /// </summary>
        /// <returns></returns>
        public abstract double PODIIndoor { get; set; }
             /// <summary>
             /// 延迟引燃--室外
             /// </summary>
             /// <returns></returns>
        public abstract double PODIOutdoor { get; set; }
    }
}
