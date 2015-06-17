using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace KidsGEPT.Models
{
    /// <summary>
    /// Schedule Metadata class
    /// </summary>
    [MetadataType(typeof(ScheduleMetadata))] 
    public partial class Schedule
    {
    public class ScheduleMetadata
    {
    /// <summary>
    /// Schedule ID
    /// </summary>        
        [DisplayName("Schedule ID")]
        [Required(ErrorMessage = "Schedule ID 必填")]
    public int ScheduleID { get; set; }
    
    /// <summary>
    /// TLevel
    /// </summary>        
        [DisplayName("TLevel")]
        [Required(ErrorMessage = "TLevel 必填")]
        [MaxLength(20, ErrorMessage = "TLevel cannot be longer than 20 characters")]
    public string TLevel { get; set; }
    
    /// <summary>
    /// Testdt
    /// </summary>        
        [DisplayName("Testdt")]
        [Required(ErrorMessage = "Testdt 必填")]
    public System.DateTime Testdt { get; set; }
    
    /// <summary>
    /// Regsdt
    /// </summary>        
        [DisplayName("Regsdt")]
        [Required(ErrorMessage = "Regsdt 必填")]
    public System.DateTime Regsdt { get; set; }
    
    /// <summary>
    /// Regedt
    /// </summary>        
        [DisplayName("Regedt")]
        [Required(ErrorMessage = "Regedt 必填")]
    public System.DateTime Regedt { get; set; }
    
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
