using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace KidsGEPT.Models
{
    /// <summary>
    /// School Metadata class
    /// </summary>
    [MetadataType(typeof(SchoolMetadata))] 
    public partial class School
    {
    public class SchoolMetadata
    {
    /// <summary>
    /// School ID
    /// </summary>        
        [DisplayName("School ID")]
        [Required(ErrorMessage = "School ID 必填")]
        [MaxLength(6, ErrorMessage = "School ID cannot be longer than 6 characters")]
    public string SchoolID { get; set; }
    
    /// <summary>
    /// School Name
    /// </summary>        
        [DisplayName("School Name")]
    public string SchoolName { get; set; }
    
    /// <summary>
    /// city
    /// </summary>        
        [DisplayName("city")]
        [MaxLength(10, ErrorMessage = "city cannot be longer than 10 characters")]
    public string city { get; set; }
    
    /// <summary>
    /// Address
    /// </summary>        
        [DisplayName("Address")]
    public string Address { get; set; }
    
    /// <summary>
    /// Tel
    /// </summary>        
        [DisplayName("Tel")]
        [MaxLength(15, ErrorMessage = "Tel cannot be longer than 15 characters")]
    public string Tel { get; set; }
    
    /// <summary>
    /// Url
    /// </summary>        
        [DisplayName("Url")]
    public string Url { get; set; }
    
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
