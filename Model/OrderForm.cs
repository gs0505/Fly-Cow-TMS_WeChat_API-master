using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class OrderForm
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int DDId { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNumber { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public string XDTime { get; set; }
        /// <summary>
        /// 委托方
        /// </summary>
        public string Client { get; set; }
        /// <summary>
        /// 始发地
        /// </summary>
        public string Lindisfarne { get; set; }
        /// <summary>
        /// 目的地
        /// </summary>
        public string Destination { get; set; }
        /// <summary>
        /// 货物
        /// </summary>
        public string Goods { get; set; }
        /// <summary>
        /// 重量kg
        /// </summary>
        public string Weight { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string State { get; set; }
    }
}
