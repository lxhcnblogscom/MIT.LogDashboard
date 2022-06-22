using System;

namespace LogDashboard.Models
{
    public interface ILogModel
    {
        int Id { get; set; }

        DateTime LongDate { get; set; }

        string Level { get; set; }

        string Logger { get; set; }
        /// <summary>
        /// 响应内容
        /// </summary>
        string Message { get; set; }
        /// <summary>
        /// 单据唯一标识
        /// </summary>
        string fromId { get; set; }
        /// <summary>
        /// 订单编码(单据编码)
        /// </summary>
        string crmId { get; set; }
        /// <summary>
        /// 请求内容
        /// </summary>
        string callData { get; set; }

        string Exception { get; set; }
    }
}
