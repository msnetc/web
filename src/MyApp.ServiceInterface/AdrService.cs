using System;
using System.Threading.Tasks;
using ServiceStack;
using MyApp.ServiceModel;
using MyApp.ServiceInterface.Business;
using ServiceStack.Logging;

namespace MyApp.ServiceInterface
{
    public class AdrService : ServiceBase
    {
        public IAdrBusiness adrBusiness;
        public static ILog Log = LogManager.GetLogger(typeof(AdrService));
        public object Post(AdrUploadRequest request)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(request.RsId))
                {
                    return new AdrUploadResponse() { Message = "id不能为空", Code = 200 };
                }
                adrBusiness = base.TryResolve<IAdrBusiness>();
                adrBusiness.UploadToAdr(request);
                return new AdrUploadResponse() { Message =  "调用成功", Code = 200 };
            }
            catch (Exception e)
            {
                return new AdrUploadResponse() { Message = e.Message, Code = 444 };
            }
        
        }
    }
}
