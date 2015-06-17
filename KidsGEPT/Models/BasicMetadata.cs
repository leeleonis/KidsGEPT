using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace KidsGEPT.Models
{
    /// <summary>
    /// Basic Metadata class
    /// </summary>
    [MetadataType(typeof(BasicMetadata))]
    public partial class Basic
    {
        public class BasicMetadata
        {
            /// <summary>
            /// Basic ID
            /// </summary>  
            [Key]
            [DisplayName("Basic ID")]
            [Required(ErrorMessage = "Basic ID 必填")]
            public int BasicID { get; set; }

            /// <summary>
            /// Basic Type
            /// </summary>        
            [DisplayName("Basic Type")]
            [Required(ErrorMessage = "Basic Type 必填")]
            [MaxLength(50, ErrorMessage = "Basic Type cannot be longer than 50 characters")]
            public string BasicType { get; set; }

            /// <summary>
            /// Name
            /// </summary>        
            [DisplayName("Name")]
            [Required(ErrorMessage = "Name 必填")]
            [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
            public string Name { get; set; }

            /// <summary>
            /// val
            /// </summary>        
            [DisplayName("val")]
            [Required(ErrorMessage = "val 必填")]
            [MaxLength(20, ErrorMessage = "val cannot be longer than 20 characters")]
            public string val { get; set; }

            /// <summary>
            /// memo
            /// </summary>        
            [DisplayName("memo")]
            public string memo { get; set; }

            /// <summary>
            /// Create ID
            /// </summary>        
            [DisplayName("Create ID")]
            [MaxLength(10, ErrorMessage = "Create ID cannot be longer than 10 characters")]
            public string CreateID { get; set; }

            /// <summary>
            /// Createdt
            /// </summary>        
            [DisplayName("Createdt")]
            public Nullable<System.DateTime> Createdt { get; set; }

            /// <summary>
            /// Update ID
            /// </summary>        
            [DisplayName("Update ID")]
            [MaxLength(50, ErrorMessage = "Update ID cannot be longer than 50 characters")]
            public string UpdateID { get; set; }

            /// <summary>
            /// Updatedt
            /// </summary>        
            [DisplayName("Updatedt")]
            public Nullable<System.DateTime> Updatedt { get; set; }

            /// <summary>
            /// Disable ID
            /// </summary>        
            [DisplayName("Disable ID")]
            [MaxLength(50, ErrorMessage = "Disable ID cannot be longer than 50 characters")]
            public string DisableID { get; set; }

            /// <summary>
            /// Disabledt
            /// </summary>        
            [DisplayName("Disabledt")]
            public Nullable<System.DateTime> Disabledt { get; set; }

            /// <summary>
            /// Disable
            /// </summary>        
            [DisplayName("Disable")]
            [MaxLength(1, ErrorMessage = "Disable cannot be longer than 1 characters")]
            public string Disable { get; set; }
        }
    }
}
