using System;

namespace LogDashboard.Models
{

    public class LogModel : ILogModel
    {
        public int Id { get; set; }

        public DateTime LongDate { get; set; }

        public string Level { get; set; }
        /// <summary>
        /// 响应内容
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// K3Cloud中的 单据唯一标识
        /// </summary>
        public string fromId { get; set; }
        /// <summary>
        /// 订单编码(单据编码)
        /// </summary>
        public string crmId { get; set; }
        /// <summary>
        /// 请求内容
        /// </summary>
        public string callData { get; set; }

        public string Logger { get; set; }

        public string Exception { get; set; }
    }

}
