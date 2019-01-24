using System;
using System.Reflection;

namespace MyApp.ServiceModel.Adr
{
    [Serializable]
    public class ADR_RPT_DISEASE
    {
        private string _FD_OBJECTID;

        private string _RPT_FD_OBJECTID;

        private decimal _DISEASE_ID;

        private string _DISEASE_NAME;

        public decimal DISEASE_ID
        {
            get
            {
                return this._DISEASE_ID;
            }
            set
            {
                this._DISEASE_ID = value;
            }
        }

        public string DISEASE_NAME
        {
            get
            {
                return this._DISEASE_NAME;
            }
            set
            {
                this._DISEASE_NAME = value;
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
                if (str == null)
                {
                }
                else if (str == "FD_OBJECTID")
                {
                    this.FD_OBJECTID = (string)value;
                }
                else if (str == "RPT_FD_OBJECTID")
                {
                    this.RPT_FD_OBJECTID = (string)value;
                }
                else if (str == "DISEASE_ID")
                {
                    this.DISEASE_ID = (decimal)value;
                }
                else
                {
                    if (str != "DISEASE_NAME")
                    {
                        return;
                    }
                    this.DISEASE_NAME = (string)value;
                }
                return;
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

        public ADR_RPT_DISEASE()
        {
        }
    }
}