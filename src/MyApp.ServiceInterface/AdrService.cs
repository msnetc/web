using System;
using ServiceStack;
using MyApp.ServiceModel;

namespace MyApp.ServiceInterface
{
    public class AdrService : Service
    {
        public object Any(AdrUploadRequest request)
        {
            try
            {
                return new AdrUploadResponse() { Message = request.AdrReports.Count.ToString(), Code = 200 };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new AdrUploadResponse() { Message = e.Message, Code = 444 };
            }
        
        }
    }
}
