using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidsGEPT.Areas.backend.Models
{
    public class SelectListModelcs
    {
        [Display(Name = "名稱")]
        public string Name { get; set; }

        [Display(Name = "數值")]
        public string Val { get; set; }
    }
}