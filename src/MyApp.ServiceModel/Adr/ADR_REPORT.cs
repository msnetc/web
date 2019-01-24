using System;
using System.Reflection;

namespace MyApp.ServiceModel.Adr
{
    [Serializable]
    public class ADR_REPORT
    {
        private string _FD_OBJECTID;

        private string _REPORT_ID;

        private string _FIRST_REPORT;

        private string _ORIGINAL_RPT_ID;

        private string _NEW_FLAG;

        private decimal _HARM_LEVEL;

        private decimal _REPORT_SOURCE_ID;

        private string _REPORT_SOURCE;

        private string _PATIENT_NAME;

        private long _GENDER_ID;

        private DateTime _BIRTH_DATE;

        private long _AGE;

        private string _AGE_UNIT;

        private long _NATION_ID;

        private string _NATION_NAME;

        private decimal _WEIGHT;

        private string _TELPHONE;

        private decimal _OLD_DISEASE_ID;

        private string _OLD_DISEASE_NAME;

        private decimal _HOSPITAL_ID;

        private string _HOSPITAL_NAME;

        private string _MEDICAL_RECORD_NO;

        private string _ONCE_ADR_FALG;

        private string _FAMILY_ADR_FLAG;

        private DateTime _ADR_DATE;

        private object _ADR_DESCRIBE;

        private long _ADR_RESULT;

        private string _SEQUELA_BEHAVE;

        private DateTime _DEATH_DATE;

        private decimal _DEATH_CAUSE_ID;

        private string _DEATH_CAUSE;

        private decimal _CEASE_DRUG_RESULT;

        private decimal _AGAIN_DRUG_RESULT;

        private decimal _REFLECT_OLD_DISEASE;

        private decimal _PICKER_EVALUATE;

        private string _PICKER_EVAL_SIGN;

        private decimal _RPT_UNIT_EVALUATE;

        private string _RPT_UNIT_SIGN;

        private string _PICKER_TEL;

        private decimal _PICKER_VOCATION_ID;

        private string _PICKER_VOCATION_NAME;

        private string _PICKER_EMAIL;

        private decimal _PICKER_ID;

        private string _PICKER_SIGN;

        private decimal _REPORT_UNIT_ID;

        private string _REPORT_UNIT_NAME;

        private string _REPORT_UNIT_LINKMAN;

        private string _REPORT_TEL;

        private DateTime _REPORT_DATE;

        private decimal _INFO_SOURCE_ID;

        private string _INFO_SOURCE;

        private string _NOTES;

        private DateTime _ENTRY_DATE;

        private decimal _APP_USER_ID;

        private string _EVALUATE_STATUS;

        private string _REPLACE_FLAG;

        private string _UNIT_ZONE;

        private string _FALSE_FLAG;

        private string _REPEAT_FLAG;

        private decimal _REPEAT_CAUSE;

        private string _TEMP_FLAG;

        private string _DEL_FLAG;

        private string _DATA_SOURCE;

        private decimal _MODIFY_USER_ID;

        private DateTime _MODIFY_TIME;

        private string _EVENT_FLAG;

        private string _MONITOR_FLAG;

        private string _COMPATIBILITY_FLAG;

        private string _COLOR_FLAG;

        private string _EXT_FIELD1;

        private string _EXT_FIELD2;

        private string _EXT_FIELD3;

        private string _EXT_FIELD4;

        private string _export_state;

        private string _trans_state;

        private string _upload;

        private static ADR_REPORT _adr_report;

        public DateTime ADR_DATE
        {
            get
            {
                return this._ADR_DATE;
            }
            set
            {
                this._ADR_DATE = value;
            }
        }

        public object ADR_DESCRIBE
        {
            get
            {
                return this._ADR_DESCRIBE;
            }
            set
            {
                this._ADR_DESCRIBE = value;
            }
        }

        public long ADR_RESULT
        {
            get
            {
                return this._ADR_RESULT;
            }
            set
            {
                this._ADR_RESULT = value;
            }
        }

        public decimal AGAIN_DRUG_RESULT
        {
            get
            {
                return this._AGAIN_DRUG_RESULT;
            }
            set
            {
                this._AGAIN_DRUG_RESULT = value;
            }
        }

        public long AGE
        {
            get
            {
                return this._AGE;
            }
            set
            {
                this._AGE = value;
            }
        }

        public string AGE_UNIT
        {
            get
            {
                return this._AGE_UNIT;
            }
            set
            {
                this._AGE_UNIT = value;
            }
        }

        public decimal APP_USER_ID
        {
            get
            {
                return this._APP_USER_ID;
            }
            set
            {
                this._APP_USER_ID = value;
            }
        }

        public DateTime BIRTH_DATE
        {
            get
            {
                return this._BIRTH_DATE;
            }
            set
            {
                this._BIRTH_DATE = value;
            }
        }

        public decimal CEASE_DRUG_RESULT
        {
            get
            {
                return this._CEASE_DRUG_RESULT;
            }
            set
            {
                this._CEASE_DRUG_RESULT = value;
            }
        }

        public string COLOR_FLAG
        {
            get
            {
                return this._COLOR_FLAG;
            }
            set
            {
                this._COLOR_FLAG = value;
            }
        }

        public string COMPATIBILITY_FLAG
        {
            get
            {
                return this._COMPATIBILITY_FLAG;
            }
            set
            {
                this._COMPATIBILITY_FLAG = value;
            }
        }

        public string DATA_SOURCE
        {
            get
            {
                return this._DATA_SOURCE;
            }
            set
            {
                this._DATA_SOURCE = value;
            }
        }

        public string DEATH_CAUSE
        {
            get
            {
                return this._DEATH_CAUSE;
            }
            set
            {
                this._DEATH_CAUSE = value;
            }
        }

        public decimal DEATH_CAUSE_ID
        {
            get
            {
                return this._DEATH_CAUSE_ID;
            }
            set
            {
                this._DEATH_CAUSE_ID = value;
            }
        }

        public DateTime DEATH_DATE
        {
            get
            {
                return this._DEATH_DATE;
            }
            set
            {
                this._DEATH_DATE = value;
            }
        }

        public string DEL_FLAG
        {
            get
            {
                return this._DEL_FLAG;
            }
            set
            {
                this._DEL_FLAG = value;
            }
        }

        public DateTime ENTRY_DATE
        {
            get
            {
                return this._ENTRY_DATE;
            }
            set
            {
                this._ENTRY_DATE = value;
            }
        }

        public string EVALUATE_STATUS
        {
            get
            {
                return this._EVALUATE_STATUS;
            }
            set
            {
                this._EVALUATE_STATUS = value;
            }
        }

        public string EVENT_FLAG
        {
            get
            {
                return this._EVENT_FLAG;
            }
            set
            {
                this._EVENT_FLAG = value;
            }
        }

        public string export_state
        {
            get
            {
                return this._export_state;
            }
            set
            {
                this._export_state = value;
            }
        }

        public string EXT_FIELD1
        {
            get
            {
                return this._EXT_FIELD1;
            }
            set
            {
                this._EXT_FIELD1 = value;
            }
        }

        public string EXT_FIELD2
        {
            get
            {
                return this._EXT_FIELD2;
            }
            set
            {
                this._EXT_FIELD2 = value;
            }
        }

        public string EXT_FIELD3
        {
            get
            {
                return this._EXT_FIELD3;
            }
            set
            {
                this._EXT_FIELD3 = value;
            }
        }

        public string EXT_FIELD4
        {
            get
            {
                return this._EXT_FIELD4;
            }
            set
            {
                this._EXT_FIELD4 = value;
            }
        }

        public string FALSE_FLAG
        {
            get
            {
                return this._FALSE_FLAG;
            }
            set
            {
                this._FALSE_FLAG = value;
            }
        }

        public string FAMILY_ADR_FLAG
        {
            get
            {
                return this._FAMILY_ADR_FLAG;
            }
            set
            {
                this._FAMILY_ADR_FLAG = value;
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

        public string FIRST_REPORT
        {
            get
            {
                return this._FIRST_REPORT;
            }
            set
            {
                this._FIRST_REPORT = value;
            }
        }

        public long GENDER_ID
        {
            get
            {
                return this._GENDER_ID;
            }
            set
            {
                this._GENDER_ID = value;
            }
        }

        public decimal HARM_LEVEL
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

        public decimal HOSPITAL_ID
        {
            get
            {
                return this._HOSPITAL_ID;
            }
            set
            {
                this._HOSPITAL_ID = value;
            }
        }

        public string HOSPITAL_NAME
        {
            get
            {
                return this._HOSPITAL_NAME;
            }
            set
            {
                this._HOSPITAL_NAME = value;
            }
        }

        public string INFO_SOURCE
        {
            get
            {
                return this._INFO_SOURCE;
            }
            set
            {
                this._INFO_SOURCE = value;
            }
        }

        public decimal INFO_SOURCE_ID
        {
            get
            {
                return this._INFO_SOURCE_ID;
            }
            set
            {
                this._INFO_SOURCE_ID = value;
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
                        case "REPORT_ID":
                            {
                                this.REPORT_ID = (string)value;
                                break;
                            }
                        case "FIRST_REPORT":
                            {
                                this.FIRST_REPORT = (string)value;
                                break;
                            }
                        case "ORIGINAL_RPT_ID":
                            {
                                this.ORIGINAL_RPT_ID = (string)value;
                                break;
                            }
                        case "NEW_FLAG":
                            {
                                this.NEW_FLAG = (string)value;
                                break;
                            }
                        case "HARM_LEVEL":
                            {
                                this.HARM_LEVEL = (decimal)value;
                                break;
                            }
                        case "REPORT_SOURCE_ID":
                            {
                                this.REPORT_SOURCE_ID = (decimal)value;
                                break;
                            }
                        case "REPORT_SOURCE":
                            {
                                this.REPORT_SOURCE = (string)value;
                                break;
                            }
                        case "PATIENT_NAME":
                            {
                                this.PATIENT_NAME = (string)value;
                                break;
                            }
                        case "GENDER_ID":
                            {
                                this.GENDER_ID = (long)value;
                                break;
                            }
                        case "BIRTH_DATE":
                            {
                                this.BIRTH_DATE = (DateTime)value;
                                break;
                            }
                        case "AGE":
                            {
                                this.AGE = (long)value;
                                break;
                            }
                        case "AGE_UNIT":
                            {
                                this.AGE_UNIT = (string)value;
                                break;
                            }
                        case "NATION_ID":
                            {
                                this.NATION_ID = (long)value;
                                break;
                            }
                        case "NATION_NAME":
                            {
                                this.NATION_NAME = (string)value;
                                break;
                            }
                        case "WEIGHT":
                            {
                                this.WEIGHT = (decimal)value;
                                break;
                            }
                        case "TELPHONE":
                            {
                                this.TELPHONE = (string)value;
                                break;
                            }
                        case "OLD_DISEASE_ID":
                            {
                                this.OLD_DISEASE_ID = (decimal)value;
                                break;
                            }
                        case "OLD_DISEASE_NAME":
                            {
                                this.OLD_DISEASE_NAME = (string)value;
                                break;
                            }
                        case "HOSPITAL_ID":
                            {
                                this.HOSPITAL_ID = (decimal)value;
                                break;
                            }
                        case "HOSPITAL_NAME":
                            {
                                this.HOSPITAL_NAME = (string)value;
                                break;
                            }
                        case "MEDICAL_RECORD_NO":
                            {
                                this.MEDICAL_RECORD_NO = (string)value;
                                break;
                            }
                        case "ONCE_ADR_FALG":
                            {
                                this.ONCE_ADR_FALG = (string)value;
                                break;
                            }
                        case "FAMILY_ADR_FLAG":
                            {
                                this.FAMILY_ADR_FLAG = (string)value;
                                break;
                            }
                        case "ADR_DATE":
                            {
                                this.ADR_DATE = (DateTime)value;
                                break;
                            }
                        case "ADR_DESCRIBE":
                            {
                                this.ADR_DESCRIBE = value;
                                break;
                            }
                        case "ADR_RESULT":
                            {
                                this.ADR_RESULT = (long)value;
                                break;
                            }
                        case "SEQUELA_BEHAVE":
                            {
                                this.SEQUELA_BEHAVE = (string)value;
                                break;
                            }
                        case "DEATH_DATE":
                            {
                                this.DEATH_DATE = (DateTime)value;
                                break;
                            }
                        case "DEATH_CAUSE_ID":
                            {
                                this.DEATH_CAUSE_ID = (decimal)value;
                                break;
                            }
                        case "DEATH_CAUSE":
                            {
                                this.DEATH_CAUSE = (string)value;
                                break;
                            }
                        case "CEASE_DRUG_RESULT":
                            {
                                this.CEASE_DRUG_RESULT = (decimal)value;
                                break;
                            }
                        case "AGAIN_DRUG_RESULT":
                            {
                                this.AGAIN_DRUG_RESULT = (decimal)value;
                                break;
                            }
                        case "REFLECT_OLD_DISEASE":
                            {
                                this.REFLECT_OLD_DISEASE = (decimal)value;
                                break;
                            }
                        case "PICKER_EVALUATE":
                            {
                                this.PICKER_EVALUATE = (decimal)value;
                                break;
                            }
                        case "PICKER_EVAL_SIGN":
                            {
                                this.PICKER_EVAL_SIGN = (string)value;
                                break;
                            }
                        case "RPT_UNIT_EVALUATE":
                            {
                                this.RPT_UNIT_EVALUATE = (decimal)value;
                                break;
                            }
                        case "RPT_UNIT_SIGN":
                            {
                                this.RPT_UNIT_SIGN = (string)value;
                                break;
                            }
                        case "PICKER_TEL":
                            {
                                this.PICKER_TEL = (string)value;
                                break;
                            }
                        case "PICKER_VOCATION_ID":
                            {
                                this.PICKER_VOCATION_ID = (decimal)value;
                                break;
                            }
                        case "PICKER_VOCATION_NAME":
                            {
                                this.PICKER_VOCATION_NAME = (string)value;
                                break;
                            }
                        case "PICKER_EMAIL":
                            {
                                this.PICKER_EMAIL = (string)value;
                                break;
                            }
                        case "PICKER_ID":
                            {
                                this.PICKER_ID = (decimal)value;
                                break;
                            }
                        case "PICKER_SIGN":
                            {
                                this.PICKER_SIGN = (string)value;
                                break;
                            }
                        case "REPORT_UNIT_ID":
                            {
                                this.REPORT_UNIT_ID = (decimal)value;
                                break;
                            }
                        case "REPORT_UNIT_NAME":
                            {
                                this.REPORT_UNIT_NAME = (string)value;
                                break;
                            }
                        case "REPORT_UNIT_LINKMAN":
                            {
                                this.REPORT_UNIT_LINKMAN = (string)value;
                                break;
                            }
                        case "REPORT_TEL":
                            {
                                this.REPORT_TEL = (string)value;
                                break;
                            }
                        case "REPORT_DATE":
                            {
                                this.REPORT_DATE = (DateTime)value;
                                break;
                            }
                        case "INFO_SOURCE_ID":
                            {
                                this.INFO_SOURCE_ID = (decimal)value;
                                break;
                            }
                        case "INFO_SOURCE":
                            {
                                this.INFO_SOURCE = (string)value;
                                break;
                            }
                        case "NOTES":
                            {
                                this.NOTES = (string)value;
                                break;
                            }
                        case "ENTRY_DATE":
                            {
                                this.ENTRY_DATE = (DateTime)value;
                                break;
                            }
                        case "APP_USER_ID":
                            {
                                this.APP_USER_ID = (decimal)value;
                                break;
                            }
                        case "EVALUATE_STATUS":
                            {
                                this.EVALUATE_STATUS = (string)value;
                                break;
                            }
                        case "REPLACE_FLAG":
                            {
                                this.REPLACE_FLAG = (string)value;
                                break;
                            }
                        case "UNIT_ZONE":
                            {
                                this.UNIT_ZONE = (string)value;
                                break;
                            }
                        case "FALSE_FLAG":
                            {
                                this.FALSE_FLAG = (string)value;
                                break;
                            }
                        case "REPEAT_FLAG":
                            {
                                this.REPEAT_FLAG = (string)value;
                                break;
                            }
                        case "REPEAT_CAUSE":
                            {
                                this.REPEAT_CAUSE = (decimal)value;
                                break;
                            }
                        case "TEMP_FLAG":
                            {
                                this.TEMP_FLAG = (string)value;
                                break;
                            }
                        case "DEL_FLAG":
                            {
                                this.DEL_FLAG = (string)value;
                                break;
                            }
                        case "DATA_SOURCE":
                            {
                                this.DATA_SOURCE = (string)value;
                                break;
                            }
                        case "MODIFY_USER_ID":
                            {
                                this.MODIFY_USER_ID = (decimal)value;
                                break;
                            }
                        case "MODIFY_TIME":
                            {
                                this.MODIFY_TIME = (DateTime)value;
                                break;
                            }
                        case "EVENT_FLAG":
                            {
                                this.EVENT_FLAG = (string)value;
                                break;
                            }
                        case "MONITOR_FLAG":
                            {
                                this.MONITOR_FLAG = (string)value;
                                break;
                            }
                        case "COMPATIBILITY_FLAG":
                            {
                                this.COMPATIBILITY_FLAG = (string)value;
                                break;
                            }
                        case "COLOR_FLAG":
                            {
                                this.COLOR_FLAG = (string)value;
                                break;
                            }
                        case "EXT_FIELD1":
                            {
                                this.EXT_FIELD1 = (string)value;
                                break;
                            }
                        case "EXT_FIELD2":
                            {
                                this.EXT_FIELD2 = (string)value;
                                break;
                            }
                        case "EXT_FIELD3":
                            {
                                this.EXT_FIELD3 = (string)value;
                                break;
                            }
                        case "EXT_FIELD4":
                            {
                                this.EXT_FIELD4 = (string)value;
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

        public string MEDICAL_RECORD_NO
        {
            get
            {
                return this._MEDICAL_RECORD_NO;
            }
            set
            {
                this._MEDICAL_RECORD_NO = value;
            }
        }

        public DateTime MODIFY_TIME
        {
            get
            {
                return this._MODIFY_TIME;
            }
            set
            {
                this._MODIFY_TIME = value;
            }
        }

        public decimal MODIFY_USER_ID
        {
            get
            {
                return this._MODIFY_USER_ID;
            }
            set
            {
                this._MODIFY_USER_ID = value;
            }
        }

        public string MONITOR_FLAG
        {
            get
            {
                return this._MONITOR_FLAG;
            }
            set
            {
                this._MONITOR_FLAG = value;
            }
        }

        public long NATION_ID
        {
            get
            {
                return this._NATION_ID;
            }
            set
            {
                this._NATION_ID = value;
            }
        }

        public string NATION_NAME
        {
            get
            {
                return this._NATION_NAME;
            }
            set
            {
                this._NATION_NAME = value;
            }
        }

        public string NEW_FLAG
        {
            get
            {
                return this._NEW_FLAG;
            }
            set
            {
                this._NEW_FLAG = value;
            }
        }

        public string NOTES
        {
            get
            {
                return this._NOTES;
            }
            set
            {
                this._NOTES = value;
            }
        }

        public decimal OLD_DISEASE_ID
        {
            get
            {
                return this._OLD_DISEASE_ID;
            }
            set
            {
                this._OLD_DISEASE_ID = value;
            }
        }

        public string OLD_DISEASE_NAME
        {
            get
            {
                return this._OLD_DISEASE_NAME;
            }
            set
            {
                this._OLD_DISEASE_NAME = value;
            }
        }

        public string ONCE_ADR_FALG
        {
            get
            {
                return this._ONCE_ADR_FALG;
            }
            set
            {
                this._ONCE_ADR_FALG = value;
            }
        }

        public string ORIGINAL_RPT_ID
        {
            get
            {
                return this._ORIGINAL_RPT_ID;
            }
            set
            {
                this._ORIGINAL_RPT_ID = value;
            }
        }

        public string PATIENT_NAME
        {
            get
            {
                return this._PATIENT_NAME;
            }
            set
            {
                this._PATIENT_NAME = value;
            }
        }

        public string PICKER_EMAIL
        {
            get
            {
                return this._PICKER_EMAIL;
            }
            set
            {
                this._PICKER_EMAIL = value;
            }
        }

        public string PICKER_EVAL_SIGN
        {
            get
            {
                return this._PICKER_EVAL_SIGN;
            }
            set
            {
                this._PICKER_EVAL_SIGN = value;
            }
        }

        public decimal PICKER_EVALUATE
        {
            get
            {
                return this._PICKER_EVALUATE;
            }
            set
            {
                this._PICKER_EVALUATE = value;
            }
        }

        public decimal PICKER_ID
        {
            get
            {
                return this._PICKER_ID;
            }
            set
            {
                this._PICKER_ID = value;
            }
        }

        public string PICKER_SIGN
        {
            get
            {
                return this._PICKER_SIGN;
            }
            set
            {
                this._PICKER_SIGN = value;
            }
        }

        public string PICKER_TEL
        {
            get
            {
                return this._PICKER_TEL;
            }
            set
            {
                this._PICKER_TEL = value;
            }
        }

        public decimal PICKER_VOCATION_ID
        {
            get
            {
                return this._PICKER_VOCATION_ID;
            }
            set
            {
                this._PICKER_VOCATION_ID = value;
            }
        }

        public string PICKER_VOCATION_NAME
        {
            get
            {
                return this._PICKER_VOCATION_NAME;
            }
            set
            {
                this._PICKER_VOCATION_NAME = value;
            }
        }

        public decimal REFLECT_OLD_DISEASE
        {
            get
            {
                return this._REFLECT_OLD_DISEASE;
            }
            set
            {
                this._REFLECT_OLD_DISEASE = value;
            }
        }

        public decimal REPEAT_CAUSE
        {
            get
            {
                return this._REPEAT_CAUSE;
            }
            set
            {
                this._REPEAT_CAUSE = value;
            }
        }

        public string REPEAT_FLAG
        {
            get
            {
                return this._REPEAT_FLAG;
            }
            set
            {
                this._REPEAT_FLAG = value;
            }
        }

        public string REPLACE_FLAG
        {
            get
            {
                return this._REPLACE_FLAG;
            }
            set
            {
                this._REPLACE_FLAG = value;
            }
        }

        public DateTime REPORT_DATE
        {
            get
            {
                return this._REPORT_DATE;
            }
            set
            {
                this._REPORT_DATE = value;
            }
        }

        public string REPORT_ID
        {
            get
            {
                return this._REPORT_ID;
            }
            set
            {
                this._REPORT_ID = value;
            }
        }

        public string REPORT_SOURCE
        {
            get
            {
                return this._REPORT_SOURCE;
            }
            set
            {
                this._REPORT_SOURCE = value;
            }
        }

        public decimal REPORT_SOURCE_ID
        {
            get
            {
                return this._REPORT_SOURCE_ID;
            }
            set
            {
                this._REPORT_SOURCE_ID = value;
            }
        }

        public string REPORT_TEL
        {
            get
            {
                return this._REPORT_TEL;
            }
            set
            {
                this._REPORT_TEL = value;
            }
        }

        public decimal REPORT_UNIT_ID
        {
            get
            {
                return this._REPORT_UNIT_ID;
            }
            set
            {
                this._REPORT_UNIT_ID = value;
            }
        }

        public string REPORT_UNIT_LINKMAN
        {
            get
            {
                return this._REPORT_UNIT_LINKMAN;
            }
            set
            {
                this._REPORT_UNIT_LINKMAN = value;
            }
        }

        public string REPORT_UNIT_NAME
        {
            get
            {
                return this._REPORT_UNIT_NAME;
            }
            set
            {
                this._REPORT_UNIT_NAME = value;
            }
        }

        public decimal RPT_UNIT_EVALUATE
        {
            get
            {
                return this._RPT_UNIT_EVALUATE;
            }
            set
            {
                this._RPT_UNIT_EVALUATE = value;
            }
        }

        public string RPT_UNIT_SIGN
        {
            get
            {
                return this._RPT_UNIT_SIGN;
            }
            set
            {
                this._RPT_UNIT_SIGN = value;
            }
        }

        public string SEQUELA_BEHAVE
        {
            get
            {
                return this._SEQUELA_BEHAVE;
            }
            set
            {
                this._SEQUELA_BEHAVE = value;
            }
        }

        public string TELPHONE
        {
            get
            {
                return this._TELPHONE;
            }
            set
            {
                this._TELPHONE = value;
            }
        }

        public string TEMP_FLAG
        {
            get
            {
                return this._TEMP_FLAG;
            }
            set
            {
                this._TEMP_FLAG = value;
            }
        }

        public string trans_state
        {
            get
            {
                return this._trans_state;
            }
            set
            {
                this._trans_state = value;
            }
        }

        public string UNIT_ZONE
        {
            get
            {
                return this._UNIT_ZONE;
            }
            set
            {
                this._UNIT_ZONE = value;
            }
        }

        public string upload
        {
            get
            {
                return this._upload;
            }
            set
            {
                this._upload = value;
            }
        }

        public decimal WEIGHT
        {
            get
            {
                return this._WEIGHT;
            }
            set
            {
                this._WEIGHT = value;
            }
        }

        public ADR_REPORT()
        {
        }

        public static ADR_REPORT GetSingleADR_REPORT()
        {
            if (ADR_REPORT._adr_report == null)
            {
                ADR_REPORT._adr_report = new ADR_REPORT();
            }
            return ADR_REPORT._adr_report;
        }
    }
}