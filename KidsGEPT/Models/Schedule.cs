//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace KidsGEPT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public Schedule()
        {
            this.Test = new HashSet<Test>();
        }
    
        public int ScheduleID { get; set; }
        public string TLevel { get; set; }
        public System.DateTime Testdt { get; set; }
        public System.DateTime Regsdt { get; set; }
        public System.DateTime Regedt { get; set; }
        public string memo { get; set; }
        public string CreateID { get; set; }
        public Nullable<System.DateTime> Createdt { get; set; }
        public string UpdateID { get; set; }
        public Nullable<System.DateTime> Updatedt { get; set; }
        public string DisableID { get; set; }
        public Nullable<System.DateTime> Disabledt { get; set; }
        public string Disable { get; set; }
    
        public virtual ICollection<Test> Test { get; set; }
    }
}
