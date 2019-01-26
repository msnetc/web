using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack;
using ServiceStack.Configuration;
using ServiceStack.Data;

namespace MyApp.ServiceInterface
{
    public class ServiceBase : Service
    {
        private IDbConnectionFactory connectionFactory;
        public IDbConnectionFactory DbConnectionFactory
        {
            get
            {
                if (connectionFactory != null) return  connectionFactory;
                return connectionFactory = base.TryResolve<IDbConnectionFactory>();
               
            }
        }


        public String AdrServerUserName
        {
            get
            {
                return base.TryResolve<IAppSettings>().Get<String>("AdrServer.UserName");
            }

        }

        public String AdrServerUserPwd
        {
            get
            {
                return base.TryResolve<IAppSettings>().Get<String>("AdrServer.UserPwd");
            }

        }

        public String AdrServerUrl
        {
            get
            {
                return base.TryResolve<IAppSettings>().Get<String>("AdrServer.Url");
            }

        }
    }
}
