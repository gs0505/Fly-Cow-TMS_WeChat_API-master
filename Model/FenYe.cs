using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class FenYe
    {
        public List<OrderForm> orderForm { get; set; }
        /// <summary>
        /// 当前页
        /// </summary>
        public int Dangqianye { get; set; }
        public int Zongtiaoshu { get; set; }
        public int Meiyetiaoshu { get; set; }
        public int masd { get; set; }
        /// <summary>
        /// 多少页
        /// </summary>
        public int PageTotal { get; set; }
    }
}
