using System;
using System.Reflection;

namespace MyApp.ServiceModel.Adr
{
    [Serializable]
    public class ADR_RPT_ONCE
    {
        private string _FD_OBJECTID;

        private string _ADR_FD_OBJECTID;

        private decimal _ADR_ID;

        private string _ADR_NAME;

        private bool _HARM_LEVEL;

        private decimal _DRUG_ID;

        private string _DRUG_NAME;

        public string ADR_FD_OBJECTID
        {
            get
            {
                return this._ADR_FD_OBJECTID;
            }
            set
            {
                this._ADR_FD_OBJECTID = value;
            }
        }

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

        public decimal DRUG_ID
        {
            get
            {
                return this._DRUG_ID;
            }
            set
            {
                this._DRUG_ID = value;
            }
        }

        public string DRUG_NAME
        {
            get
            {
                return this._DRUG_NAME;
            }
            set
            {
                this._DRUG_NAME = value;
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

        public bool HARM_LEVEL
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
                        case "ADR_FD_OBJECTID":
                            {
                                this.ADR_FD_OBJECTID = (string)value;
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
                                this.HARM_LEVEL = (bool)value;
                                break;
                            }
                        case "DRUG_ID":
                            {
                                this.DRUG_ID = (decimal)value;
                                break;
                            }
                        case "DRUG_NAME":
                            {
                                this.DRUG_NAME = (string)value;
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

        public ADR_RPT_ONCE()
        {
        }
    }
}