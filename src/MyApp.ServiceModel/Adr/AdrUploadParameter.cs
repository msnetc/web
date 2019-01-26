using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack;

namespace MyApp.ServiceModel.Adr
{
    public class AdrUploadParameter : IReturn<String>
    {
        public object[] objArray { get; set; }
    }
    
}
