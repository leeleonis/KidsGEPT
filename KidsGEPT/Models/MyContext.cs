using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KidsGEPT.Models
{

    public partial class KidsGEPTEntities : DbContext
    {
        //不更新的欄位
        protected string[] Updateexcluded = { "CreateID", "Createdt", "DisableID", "Disabledt", "Disable" };
        public override int SaveChanges()
        {         
            OnSavingChanges();
            return base.SaveChanges();
        }

        public class EntityInformation
        {
            public DateTime ModifiedDate { get; set; }
            public string ModifiedUserName { get; set; }
        }
        private void OnSavingChanges()
        {    
            DateTime dbtime =getdbtime();
            foreach (var item in this.ChangeTracker.Entries())
            {
                if (item.State == EntityState.Added)
                {
                  
                }
                else if (item.State == EntityState.Modified)
                {
                    dynamic s = item.Entity;
                    s.Updatedt = dbtime;
                    foreach (var name in Updateexcluded)
                    {                    
                        item.Property(name).IsModified = false;
                    }
                   // item.Property("Updatedt").CurrentValue = DateTime.Now;                
                }
            }
        }

        private DateTime getdbtime()
        {
            DateTime dbtime = DateTime.Now;
            using (var db = new KidsGEPTEntities())
            {
                dbtime = db.Database.SqlQuery<DateTime>("SELECT getdate()").First();
            }
            return dbtime;
        }
    }
}

