using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.ServiceInterface.utils;
using MyApp.ServiceModel;
using MyApp.ServiceModel.Adr;
using MyApp.ServiceModel.DataModel;
using ServiceStack;
using ServiceStack.Configuration;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace MyApp.ServiceInterface.Business
{
    public interface IAdrBusiness
    {
        void UploadToAdr(AdrUploadRequest request);
    }

   public class AdrBusiness : IAdrBusiness
   {
       public IAppSettings AppSettings { get; set; }
       public IDbConnectionFactory DbConnectionFactory { get; set; }

        private DataSet ToDataSet(AdrUploadRequest request)
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
            DataTable dtAdrRptImportants = request.AdrRptImportants?.ToList().ToDataTable(); 
            ds.Tables.Add(dtAdrRptImportants);
            return ds;
        }

        public void UploadToAdr(AdrUploadRequest request)
        {
            
            DataSet ds = ToDataSet(request);
            object[] objArray = new object[] { ds, AppSettings.Get<String>("AdrServer.UserName"), AppSettings.Get<String>("AdrServer.UserPwd"), request.btUploadFile, request.filename };
            AdrUploadParameter requestParameter = new AdrUploadParameter();
            requestParameter.objArray = objArray;
            using (var client = new XmlServiceClient(AppSettings.Get<String>("AdrServer.Url")))
            {
                Task<String> uploadToAdrTask = client.PostAsync(requestParameter);
                uploadToAdrTask.ContinueWith<String>(task =>
                {
                    if (uploadToAdrTask.IsSuccess()) { 
                        using (var db = DbConnectionFactory.OpenDbConnection())
                        {
                            //成功
                            db.UpdateOnly(() => new ReportSupervision(){ ReferStatus =1},p => p.Id == request.RsId);
                            db.Close();
                            return task.Result;
                        }
                    }
                    using (var db = DbConnectionFactory.OpenDbConnection())
                    {
                        //失败
                        db.UpdateOnly(() => new ReportSupervision() { ReferStatus = 2 }, p => p.Id == request.RsId);
                        db.Close();
                        return task.Result;
                    }
                });
            }
           
        }
    }
}
