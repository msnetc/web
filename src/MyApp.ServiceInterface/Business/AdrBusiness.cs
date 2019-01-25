using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MyApp.ServiceInterface.utils;
using MyApp.ServiceModel;
using MyApp.ServiceModel.Adr;
using ServiceStack;

namespace MyApp.ServiceInterface.Business
{
    public interface IAdrBusiness
    {
        void UploadToAdr(AdrUploadRequest request);
    }

   public class AdrBusiness : IAdrBusiness
    {
        public DataSet ToDataSet(AdrUploadRequest request)
        {
            DataSet ds = new DataSet();
            DataTable dtAdrReports = request.AdrReports?.ToList().ToDataTable();
            ds.Tables.Add(dtAdrReports);
            DataTable dtAdrRptDoubtMerges = request.AdrRptDoubtMerges?.ToList().ToDataTable();
            ds.Tables.Add(dtAdrRptDoubtMerges);
            DataTable dtAdrRptAdrnames = request.AdrRptAdrnames?.ToList().ToDataTable();
            ds.Tables.Add(dtAdrRptAdrnames);
            DataTable dtAdrRptDiseases = request.AdrRptDiseases?.ToList().ToDataTable();
            ds.Tables.Add(dtAdrRptDiseases);
            DataTable dtAdrRptOnces = request.AdrRptOnces?.ToList().ToDataTable();
            ds.Tables.Add(dtAdrRptOnces);
            DataTable dtAdrRptFamilys = request.AdrRptFamilys?.ToList().ToDataTable();
            ds.Tables.Add(dtAdrRptFamilys);
            DataTable dtAdrRptAttachments = request.AdrRptAttachments?.ToList().ToDataTable();
            ds.Tables.Add(dtAdrRptAttachments);
            DataTable dtAdrAttachmentss = request.AdrAttachmentss?.ToList().ToDataTable();
            ds.Tables.Add(dtAdrAttachmentss);
            DataTable dtAdrRptHarms = request.AdrRptHarms?.ToList().ToDataTable();
            ds.Tables.Add(dtAdrRptHarms);
            DataTable dtAdrRptImportants = request.AdrRptImportants?.ToList().ToDataTable(); ;
            ds.Tables.Add(dtAdrRptImportants);
            return ds;
        }

        public void UploadToAdr(AdrUploadRequest request)
        {
            DataSet ds = ToDataSet(request);            
        }
    }
}
