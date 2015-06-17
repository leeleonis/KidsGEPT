using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace KidsGEPT.Models
{
    /// <summary>
    /// Special Metadata class
    /// </summary>
    [MetadataType(typeof(SpecialMetadata))] 
    public partial class Special
    {
    public class SpecialMetadata
    {
    /// <summary>
    /// No
    /// </summary>        
        [DisplayName("No")]
        [Required(ErrorMessage = "No 必填")]
    public int No { get; set; }
    
    /// <summary>
    /// Test ID
    /// </summary>        
        [DisplayName("Test ID")]
        [Required(ErrorMessage = "Test ID 必填")]
    public int TestID { get; set; }
    
    /// <summary>
    /// Basic ID
    /// </summary>        
        [DisplayName("Basic ID")]
        [Required(ErrorMessage = "Basic ID 必填")]
    public int BasicID { get; set; }
    
    /// <summary>
    /// Special Check
    /// </summary>        
        [DisplayName("Special Check")]
        [Required(ErrorMessage = "Special Check 必填")]
        [MaxLength(1, ErrorMessage = "Special Check cannot be longer than 1 characters")]
    public string SpecialCheck { get; set; }
    
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
