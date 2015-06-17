using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace KidsGEPT.Models
{
    /// <summary>
    /// Test Metadata class
    /// </summary>
    [MetadataType(typeof(TestMetadata))] 
    public partial class Test
    {
    public class TestMetadata
    {
    /// <summary>
    /// Test ID
    /// </summary>        
        [DisplayName("Test ID")]
        [Required(ErrorMessage = "Test ID 必填")]
    public int TestID { get; set; }
    
    /// <summary>
    /// PID
    /// </summary>        
        [DisplayName("PID")]
        [Required(ErrorMessage = "PID 必填")]
        [MaxLength(10, ErrorMessage = "PID cannot be longer than 10 characters")]
    public string PID { get; set; }
    
    /// <summary>
    /// Schedule ID
    /// </summary>        
        [DisplayName("Schedule ID")]
        [Required(ErrorMessage = "Schedule ID 必填")]
    public int ScheduleID { get; set; }
    
    /// <summary>
    /// Test Area
    /// </summary>        
        [DisplayName("Test Area")]
        [Required(ErrorMessage = "Test Area 必填")]
        [MaxLength(10, ErrorMessage = "Test Area cannot be longer than 10 characters")]
    public string TestArea { get; set; }
    
    /// <summary>
    /// Test Identity
    /// </summary>        
        [DisplayName("Test Identity")]
        [MaxLength(10, ErrorMessage = "Test Identity cannot be longer than 10 characters")]
    public string TestIdentity { get; set; }
    
    /// <summary>
    /// Test State
    /// </summary>        
        [DisplayName("Test State")]
        [MaxLength(10, ErrorMessage = "Test State cannot be longer than 10 characters")]
    public string TestState { get; set; }
    
    /// <summary>
    /// Ticket
    /// </summary>        
        [DisplayName("Ticket")]
        [MaxLength(10, ErrorMessage = "Ticket cannot be longer than 10 characters")]
    public string Ticket { get; set; }
    
    /// <summary>
    /// SMS
    /// </summary>        
        [DisplayName("SMS")]
        [MaxLength(1, ErrorMessage = "SMS cannot be longer than 1 characters")]
    public string SMS { get; set; }
    
    /// <summary>
    /// EDM
    /// </summary>        
        [DisplayName("EDM")]
        [MaxLength(1, ErrorMessage = "EDM cannot be longer than 1 characters")]
    public string EDM { get; set; }
    
    /// <summary>
    /// Group Code
    /// </summary>        
        [DisplayName("Group Code")]
        [MaxLength(10, ErrorMessage = "Group Code cannot be longer than 10 characters")]
    public string GroupCode { get; set; }
    
    /// <summary>
    /// family
    /// </summary>        
        [DisplayName("family")]
    public string family { get; set; }
    
    /// <summary>
    /// Photo
    /// </summary>        
        [DisplayName("Photo")]
    public string Photo { get; set; }
    
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
