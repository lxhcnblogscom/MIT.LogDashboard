using System;

namespace LogDashboard.Models
{
    public class SearchLogInput
    {
        public bool All { get; set; }

        public bool Unique { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public bool ToDay { get; set; }

        public string Level { get; set; }

        public bool Hour { get; set; }

        public int Page { get; set; }

        public int PageSize { get; set; }
        /// <summary>
        /// 响应内容
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        ///单据唯一标识
        /// </summary>
        public string fromId { get; set; }
        /// <summary>
        /// 订单编码(单据编码)
        /// </summary
        public string crmId { get; set; }
        /// <summary>
        /// 请求内容
        /// </summary
        public string callData { get; set; }

        public SearchLogInput()
        {
            Page = 1;
            PageSize = 10;
        }
    }
}
