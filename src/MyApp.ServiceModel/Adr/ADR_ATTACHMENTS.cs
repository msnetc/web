using System;
using System.Reflection;

namespace MyApp.ServiceModel.Adr
{
    [Serializable]
    public class ADR_ATTACHMENTS
    {
        private string _FD_OBJECTID;

        private string _DIR_FD_OBJECTID;

        private string _FILE_NAME;

        private string _ORIGINAL_FILE_NAME;

        private string _FILE_CATEGORY;

        private string _FILE_TYPE;

        private long _ATTACH_TYPE;

        private string _PROFILE;

        private DateTime _UPLOAD_DATE;

        private decimal _UPLOAD_USER_ID;

        private string _FILE_PATH;

        private string _FILE_STATUS;

        private string _ORIGINAL_FILE_ID;

        private string _NOTES;

        private decimal _FILE_SIZE;

        public long ATTACH_TYPE
        {
            get
            {
                return this._ATTACH_TYPE;
            }
            set
            {
                this._ATTACH_TYPE = value;
            }
        }

        public string DIR_FD_OBJECTID
        {
            get
            {
                return this._DIR_FD_OBJECTID;
            }
            set
            {
                this._DIR_FD_OBJECTID = value;
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

        public string FILE_CATEGORY
        {
            get
            {
                return this._FILE_CATEGORY;
            }
            set
            {
                this._FILE_CATEGORY = value;
            }
        }

        public string FILE_NAME
        {
            get
            {
                return this._FILE_NAME;
            }
            set
            {
                this._FILE_NAME = value;
            }
        }

        public string FILE_PATH
        {
            get
            {
                return this._FILE_PATH;
            }
            set
            {
                this._FILE_PATH = value;
            }
        }

        public decimal FILE_SIZE
        {
            get
            {
                return this._FILE_SIZE;
            }
            set
            {
                this._FILE_SIZE = value;
            }
        }

        public string FILE_STATUS
        {
            get
            {
                return this._FILE_STATUS;
            }
            set
            {
                this._FILE_STATUS = value;
            }
        }

        public string FILE_TYPE
        {
            get
            {
                return this._FILE_TYPE;
            }
            set
            {
                this._FILE_TYPE = value;
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
                        case "DIR_FD_OBJECTID":
                            {
                                this.DIR_FD_OBJECTID = (string)value;
                                break;
                            }
                        case "FILE_NAME":
                            {
                                this.FILE_NAME = (string)value;
                                break;
                            }
                        case "ORIGINAL_FILE_NAME":
                            {
                                this.ORIGINAL_FILE_NAME = (string)value;
                                break;
                            }
                        case "FILE_CATEGORY":
                            {
                                this.FILE_CATEGORY = (string)value;
                                break;
                            }
                        case "FILE_TYPE":
                            {
                                this.FILE_TYPE = (string)value;
                                break;
                            }
                        case "ATTACH_TYPE":
                            {
                                this.ATTACH_TYPE = (long)value;
                                break;
                            }
                        case "PROFILE":
                            {
                                this.PROFILE = (string)value;
                                break;
                            }
                        case "UPLOAD_DATE":
                            {
                                this.UPLOAD_DATE = (DateTime)value;
                                break;
                            }
                        case "UPLOAD_USER_ID":
                            {
                                this.UPLOAD_USER_ID = (decimal)value;
                                break;
                            }
                        case "FILE_PATH":
                            {
                                this.FILE_PATH = (string)value;
                                break;
                            }
                        case "FILE_STATUS":
                            {
                                this.FILE_STATUS = (string)value;
                                break;
                            }
                        case "ORIGINAL_FILE_ID":
                            {
                                this.ORIGINAL_FILE_ID = (string)value;
                                break;
                            }
                        case "NOTES":
                            {
                                this.NOTES = (string)value;
                                break;
                            }
                        case "FILE_SIZE":
                            {
                                this.FILE_SIZE = (decimal)value;
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

        public string ORIGINAL_FILE_ID
        {
            get
            {
                return this._ORIGINAL_FILE_ID;
            }
            set
            {
                this._ORIGINAL_FILE_ID = value;
            }
        }

        public string ORIGINAL_FILE_NAME
        {
            get
            {
                return this._ORIGINAL_FILE_NAME;
            }
            set
            {
                this._ORIGINAL_FILE_NAME = value;
            }
        }

        public string PROFILE
        {
            get
            {
                return this._PROFILE;
            }
            set
            {
                this._PROFILE = value;
            }
        }

        public DateTime UPLOAD_DATE
        {
            get
            {
                return this._UPLOAD_DATE;
            }
            set
            {
                this._UPLOAD_DATE = value;
            }
        }

        public decimal UPLOAD_USER_ID
        {
            get
            {
                return this._UPLOAD_USER_ID;
            }
            set
            {
                this._UPLOAD_USER_ID = value;
            }
        }

        public ADR_ATTACHMENTS()
        {
        }
    }
}