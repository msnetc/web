using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack;
using MyApp.ServiceModel.Adr;

namespace MyApp.ServiceModel
{
    [Route("/AdrUpload")]
    public  class AdrUploadRequest : IReturn<AdrUploadResponse>
    {
        public String RsId { get; set; }
        public List<ADR_REPORT> AdrReports { get; set; }
        public List<ADR_RPT_DOUBT_MERGE> AdrRptDoubtMerges { get; set; }
        public List<ADR_RPT_ADRNAME> AdrRptAdrnames { get; set; }
        public List<ADR_RPT_DISEASE> AdrRptDiseases { get; set; }
        public List<ADR_RPT_ONCE> AdrRptOnces { get; set; }
        public List<ADR_RPT_FAMILY> AdrRptFamilys { get; set; }
        public List<ADR_RPT_ATTACHMENT> AdrRptAttachments { get; set; }
        public List<ADR_ATTACHMENTS> AdrAttachmentss { get; set; }
        public List<ADR_RPT_HARM> AdrRptHarms { get; set; }
        public List<ADR_RPT_IMPORTANT> AdrRptImportants { get; set; }

        public Byte[] btUploadFile { get; set; }

        public string filename { get; set; }
    }
}
