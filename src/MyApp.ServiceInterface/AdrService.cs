using System;
using ServiceStack;
using MyApp.ServiceModel;
using MyApp.ServiceInterface.Business;

namespace MyApp.ServiceInterface
{
    public class AdrService : Service
    {
        public IAdrBusiness adrBusiness;
        public object Any(AdrUploadRequest request)
        {
            try
            {
                adrBusiness = base.TryResolve<IAdrBusiness>();
                adrBusiness.UploadToAdr(request);
                return new AdrUploadResponse() { Message =  "成功", Code = 200 };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new AdrUploadResponse() { Message = e.Message, Code = 444 };
            }
        
        }
    }
}
