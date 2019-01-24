using System;
using System.Reflection;

namespace MyApp.ServiceModel.Adr
{
    [Serializable]
    public class ADR_RPT_DOUBT_MERGE
    {
        private string _FD_OBJECTID;

        private string _RPT_FD_OBJECTID;

        private bool _DRUG_ATTR;

        private long _DRUG_ORDER;

        private string _APPROVAL_NO;

        private long _GENERAL_ID;

        private string _GENERAL_NAME;

        private decimal _DRUG_ID;

        private string _DRUG_NAME;

        private long _DOSAGE_FORM;

        private decimal _FACTORY_ID;

        private string _FACTORY_NAME;

        private string _BATCH_NO;

        private decimal _DOSAGE;

        private long _DRUG_UNIT;

        private int _TIMES;

        private int _PERIOD_DAY;

        private long _USAGE_MODE;

        private DateTime _START_DATE;

        private DateTime _END_DATE;

        private decimal _CAUSE_ID;

        private string _CAUSE;

        private string _SEARCH_CODE;

        private bool _GE_NAME_FLAG;

        private string _DOSAGE_FORM_NAME;

        private string _DRUG_UNIT_NAME;

        private string _USAGE_MODE_NAME;

        public string APPROVAL_NO
        {
            get
            {
                return this._APPROVAL_NO;
            }
            set
            {
                this._APPROVAL_NO = value;
            }
        }

        public string BATCH_NO
        {
            get
            {
                return this._BATCH_NO;
            }
            set
            {
                this._BATCH_NO = value;
            }
        }

        public string CAUSE
        {
            get
            {
                return this._CAUSE;
            }
            set
            {
                this._CAUSE = value;
            }
        }

        public decimal CAUSE_ID
        {
            get
            {
                return this._CAUSE_ID;
            }
            set
            {
                this._CAUSE_ID = value;
            }
        }

        public decimal DOSAGE
        {
            get
            {
                return this._DOSAGE;
            }
            set
            {
                this._DOSAGE = value;
            }
        }

        public long DOSAGE_FORM
        {
            get
            {
                return this._DOSAGE_FORM;
            }
            set
            {
                this._DOSAGE_FORM = value;
            }
        }

        public string DOSAGE_FORM_NAME
        {
            get
            {
                return this._DOSAGE_FORM_NAME;
            }
            set
            {
                this._DOSAGE_FORM_NAME = value;
            }
        }

        public bool DRUG_ATTR
        {
            get
            {
                return this._DRUG_ATTR;
            }
            set
            {
                this._DRUG_ATTR = value;
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

        public long DRUG_ORDER
        {
            get
            {
                return this._DRUG_ORDER;
            }
            set
            {
                this._DRUG_ORDER = value;
            }
        }

        public long DRUG_UNIT
        {
            get
            {
                return this._DRUG_UNIT;
            }
            set
            {
                this._DRUG_UNIT = value;
            }
        }

        public string DRUG_UNIT_NAME
        {
            get
            {
                return this._DRUG_UNIT_NAME;
            }
            set
            {
                this._DRUG_UNIT_NAME = value;
            }
        }

        public DateTime END_DATE
        {
            get
            {
                return this._END_DATE;
            }
            set
            {
                this._END_DATE = value;
            }
        }

        public decimal FACTORY_ID
        {
            get
            {
                return this._FACTORY_ID;
            }
            set
            {
                this._FACTORY_ID = value;
            }
        }

        public string FACTORY_NAME
        {
            get
            {
                return this._FACTORY_NAME;
            }
            set
            {
                this._FACTORY_NAME = value;
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

        public bool GE_NAME_FLAG
        {
            get
            {
                return this._GE_NAME_FLAG;
            }
            set
            {
                this._GE_NAME_FLAG = value;
            }
        }

        public long GENERAL_ID
        {
            get
            {
                return this._GENERAL_ID;
            }
            set
            {
                this._GENERAL_ID = value;
            }
        }

        public string GENERAL_NAME
        {
            get
            {
                return this._GENERAL_NAME;
            }
            set
            {
                this._GENERAL_NAME = value;
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
                        case "DRUG_ATTR":
                            {
                                this.DRUG_ATTR = (bool)value;
                                break;
                            }
                        case "DRUG_ORDER":
                            {
                                this.DRUG_ORDER = (long)value;
                                break;
                            }
                        case "APPROVAL_NO":
                            {
                                this.APPROVAL_NO = (string)value;
                                break;
                            }
                        case "GENERAL_ID":
                            {
                                this.GENERAL_ID = (long)value;
                                break;
                            }
                        case "GENERAL_NAME":
                            {
                                this.GENERAL_NAME = (string)value;
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
                        case "DOSAGE_FORM":
                            {
                                this.DOSAGE_FORM = (long)value;
                                break;
                            }
                        case "FACTORY_ID":
                            {
                                this.FACTORY_ID = (decimal)value;
                                break;
                            }
                        case "FACTORY_NAME":
                            {
                                this.FACTORY_NAME = (string)value;
                                break;
                            }
                        case "BATCH_NO":
                            {
                                this.BATCH_NO = (string)value;
                                break;
                            }
                        case "DOSAGE":
                            {
                                this.DOSAGE = (decimal)value;
                                break;
                            }
                        case "DRUG_UNIT":
                            {
                                this.DRUG_UNIT = (long)value;
                                break;
                            }
                        case "TIMES":
                            {
                                this.TIMES = (int)value;
                                break;
                            }
                        case "PERIOD_DAY":
                            {
                                this.PERIOD_DAY = (int)value;
                                break;
                            }
                        case "USAGE_MODE":
                            {
                                this.USAGE_MODE = (long)value;
                                break;
                            }
                        case "START_DATE":
                            {
                                this.START_DATE = (DateTime)value;
                                break;
                            }
                        case "END_DATE":
                            {
                                this.END_DATE = (DateTime)value;
                                break;
                            }
                        case "CAUSE_ID":
                            {
                                this.CAUSE_ID = (decimal)value;
                                break;
                            }
                        case "CAUSE":
                            {
                                this.CAUSE = (string)value;
                                break;
                            }
                        case "SEARCH_CODE":
                            {
                                this.SEARCH_CODE = (string)value;
                                break;
                            }
                        case "GE_NAME_FLAG":
                            {
                                this.GE_NAME_FLAG = (bool)value;
                                break;
                            }
                        case "DOSAGE_FORM_NAME":
                            {
                                this.DOSAGE_FORM_NAME = (string)value;
                                break;
                            }
                        case "DRUG_UNIT_NAME":
                            {
                                this.DRUG_UNIT_NAME = (string)value;
                                break;
                            }
                        case "USAGE_MODE_NAME":
                            {
                                this.USAGE_MODE_NAME = (string)value;
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

        public int PERIOD_DAY
        {
            get
            {
                return this._PERIOD_DAY;
            }
            set
            {
                this._PERIOD_DAY = value;
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

        public string SEARCH_CODE
        {
            get
            {
                return this._SEARCH_CODE;
            }
            set
            {
                this._SEARCH_CODE = value;
            }
        }

        public DateTime START_DATE
        {
            get
            {
                return this._START_DATE;
            }
            set
            {
                this._START_DATE = value;
            }
        }

        public int TIMES
        {
            get
            {
                return this._TIMES;
            }
            set
            {
                this._TIMES = value;
            }
        }

        public long USAGE_MODE
        {
            get
            {
                return this._USAGE_MODE;
            }
            set
            {
                this._USAGE_MODE = value;
            }
        }

        public string USAGE_MODE_NAME
        {
            get
            {
                return this._USAGE_MODE_NAME;
            }
            set
            {
                this._USAGE_MODE_NAME = value;
            }
        }

        public ADR_RPT_DOUBT_MERGE()
        {
        }
    }
}