using System;
using System.Reflection;

namespace MyApp.ServiceModel.Adr
{
    [Serializable]
    public class ADR_RPT_HARM
    {
        private string _FD_OBJECTID;

        private long _ADR_CODE_ID;

        private string _RPT_FD_OBJECTID;

        public long ADR_CODE_ID
        {
            get
            {
                return this._ADR_CODE_ID;
            }
            set
            {
                this._ADR_CODE_ID = value;
            }
        }

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
                    else if (str == "ADR_CODE_ID")
                    {
                        this.ADR_CODE_ID = (long)value;
                        return;
                    }
                    else
                    {
                        if (str != "RPT_FD_OBJECTID")
                        {
                            return;
                        }
                        this.RPT_FD_OBJECTID = (string)value;
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

        public ADR_RPT_HARM()
        {
        }
    }
}