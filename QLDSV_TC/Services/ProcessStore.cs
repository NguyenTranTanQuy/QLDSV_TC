
namespace QLDSV_TC.Services
{
    public class ProcessStore
    {
        public string flagMode { get; set; }
        
        public string primaryKey { get; set; }
        
        public object dataRow { get; set; }
        
        public ProcessStore() { }

        public ProcessStore(string flagMode)
        {
            this.flagMode = flagMode;
        }

        public ProcessStore(string flagMode, string primaryKey)
        {
            this.flagMode = flagMode;
            this.primaryKey = primaryKey;
        }

        public ProcessStore(string flagMode, string primaryKey, object dataRow)
        {
            this.flagMode = flagMode;
            this.primaryKey = primaryKey;
            this.dataRow = dataRow;
        }
    }
}
