using System;
using System.Reflection;

namespace MyApp.ServiceModel.Adr
{
    [Serializable]
    public class ADR_RPT_ADRNAME
    {
        private string _FD_OBJECTID;

        private string _RPT_FD_OBJECTID;

        private decimal _ADR_ID;

        private string _ADR_NAME;

        private long _HARM_LEVEL;

        private int _ADR_ORDER;

        public decimal ADR_ID
        {
            get
            {
                return this._ADR_ID;
            }
            set
            {
                this._ADR_ID = value;
            }
        }

        public string ADR_NAME
        {
            get
            {
                return this._ADR_NAME;
            }
            set
            {
                this._ADR_NAME = value;
            }
        }

        public int ADR_ORDER
        {
            get
            {
                return this._ADR_ORDER;
            }
            set
            {
                this._ADR_ORDER = value;
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

        public long HARM_LEVEL
        {
            get
            {
                return this._HARM_LEVEL;
            }
            set
            {
                this._HARM_LEVEL = value;
            }
        }

        public object this[string strName]
        {
            set
            {
                string str = strName;
                if (str != null)
                {
                    switch (str)
                    {
                        case "FD_OBJECTID":
                            {
                                this.FD_OBJECTID = (string)value;
                                break;
                            }
                        case "RPT_FD_OBJECTID":
                            {
                                this.RPT_FD_OBJECTID = (string)value;
                                break;
                            }
                        case "ADR_ID":
                            {
                                this.ADR_ID = (decimal)value;
                                break;
                            }
                        case "ADR_NAME":
                            {
                                this.ADR_NAME = (string)value;
                                break;
                            }
                        case "HARM_LEVEL":
                            {
                                this.HARM_LEVEL = (long)value;
                                break;
                            }
                        case "ADR_ORDER":
                            {
                                this.ADR_ORDER = (int)value;
                                break;
                            }
                        default:
                            {
                                return;
                            }
                    }
                }
                else
                {
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

        public ADR_RPT_ADRNAME()
        {
        }
    }
}