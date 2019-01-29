using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ServiceStack.DataAnnotations;

namespace MyApp.ServiceModel.DataModel
{
    [Alias("report_supervision")]
    public class ReportSupervision
    {

        [Alias("id")]
        public String Id { get; set; }

        [Alias("report_id")]
        public String ReportId { get; set; }

        [Alias("report_way")]
        public int  ReportWay{ get; set; }

        [Alias("report_quantity")]
        public int ReportQuantity { get; set; }

        [Alias("refer_status")]
        public byte ReferStatus { get; set; }

        [Alias("refer_result_info")]
        public String ReferResultInfo { get; set; }

        [Alias("REVISION")]
        public int Revision { get; set; }

        [Alias("CREATED_TIME")]
        public DateTime? CreateTime { get; set; }

        [Alias("UPDATED_TIME")]
        public DateTime? UpdateTime { get; set; }

        [Alias("CREATED_BY")]
        public String CreateBy { get; set; }

        [Alias("UPDATED_BY")]
        public int UpdateBy { get; set; }
    }
}
