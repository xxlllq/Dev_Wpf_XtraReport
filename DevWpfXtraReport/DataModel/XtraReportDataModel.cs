using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevWpfXtraReport.DataModel
{
    public class XtraReportDataModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// 长
        /// </summary>
        public decimal Length { get; set; }
        /// <summary>
        /// 宽
        /// </summary>
        public decimal Width { get; set; }
        /// <summary>
        /// 厚
        /// </summary>
        public decimal Thick { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
