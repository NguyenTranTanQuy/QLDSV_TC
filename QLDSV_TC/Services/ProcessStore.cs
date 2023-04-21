using System;

namespace QLDSV_TC.Services
{
    public class ProcessStore
    {
        public String flagMode { get; set; }
        public String primaryKey { get; set; }
        public Object dataRow { get; set; }
        
        public ProcessStore() { }

        public ProcessStore(String flagMode)
        {
            this.flagMode = flagMode;
        }

        public ProcessStore(String flagMode, String primaryKey)
        {
            this.flagMode = flagMode;
            this.primaryKey = primaryKey;
        }

        public ProcessStore(String flagMode, String primaryKey, Object dataRow)
        {
            this.flagMode = flagMode;
            this.primaryKey = primaryKey;
            this.dataRow = dataRow;
        }
    }
}
