using System;
using System.Reflection;

namespace MyApp.ServiceModel.Adr
{
    [Serializable]
    public class ADR_RPT_IMPORTANT
    {
        private string _FD_OBJECTID;

        private string _RPT_FD_OBJECTID;

        private long _CODE_ID;

        private string _CODE_NAME;

        private string _OTHER_COMMENT;

        private long _ORDER_NO;

        public long CODE_ID
        {
            get
            {
                return this._CODE_ID;
            }
            set
            {
                this._CODE_ID = value;
            }
        }

        public string CODE_NAME
        {
            get
            {
                return this._CODE_NAME;
            }
            set
            {
                this._CODE_NAME = value;
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
                        case "CODE_ID":
                            {
                                this.CODE_ID = (long)value;
                                break;
                            }
                        case "CODE_NAME":
                            {
                                this.CODE_NAME = (string)value;
                                break;
                            }
                        case "OTHER_COMMENT":
                            {
                                this.OTHER_COMMENT = (string)value;
                                break;
                            }
                        case "ORDER_NO":
                            {
                                this.ORDER_NO = (long)value;
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

        public long ORDER_NO
        {
            get
            {
                return this._ORDER_NO;
            }
            set
            {
                this._ORDER_NO = value;
            }
        }

        public string OTHER_COMMENT
        {
            get
            {
                return this._OTHER_COMMENT;
            }
            set
            {
                this._OTHER_COMMENT = value;
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

        public ADR_RPT_IMPORTANT()
        {
        }
    }
}