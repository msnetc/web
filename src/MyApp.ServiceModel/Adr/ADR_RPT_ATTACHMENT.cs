using System;
using System.Reflection;

namespace MyApp.ServiceModel.Adr
{
    [Serializable]
    public class ADR_RPT_ATTACHMENT
    {
        private string _FD_OBJECTID;

        private string _RPT_FD_OBJECTID;

        private string _FILE_ID;

        public string FD_OBJECTID
        {
            get
            {
                return this._FD_OBJECTID;
            }
            set
            {
                this._FD_OBJECTID = value;
            }
        }

        public string FILE_ID
        {
            get
            {
                return this._FILE_ID;
            }
            set
            {
                this._FILE_ID = value;
            }
        }

        public object this[string strName]
        {
            set
            {
                string str = strName;
                if (str != null)
                {
                    if (str == "FD_OBJECTID")
                    {
                        this.FD_OBJECTID = (string)value;
                        return;
                    }
                    else if (str == "RPT_FD_OBJECTID")
                    {
                        this.RPT_FD_OBJECTID = (string)value;
                        return;
                    }
                    else
                    {
                        if (str != "FILE_ID")
                        {
                            return;
                        }
                        this.FILE_ID = (string)value;
                        return;
                    }
                }
            }
        }

        public string RPT_FD_OBJECTID
        {
            get
            {
                return this._RPT_FD_OBJECTID;
            }
            set
            {
                this._RPT_FD_OBJECTID = value;
            }
        }

        public ADR_RPT_ATTACHMENT()
        {
        }
    }
}