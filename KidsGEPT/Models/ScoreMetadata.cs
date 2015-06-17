using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace KidsGEPT.Models
{
    /// <summary>
    /// Score Metadata class
    /// </summary>
    [MetadataType(typeof(ScoreMetadata))] 
    public partial class Score
    {
    public class ScoreMetadata
    {
    /// <summary>
    /// Score ID
    /// </summary>        
        [DisplayName("Score ID")]
        [Required(ErrorMessage = "Score ID 必填")]
    public int ScoreID { get; set; }
    
    /// <summary>
    /// Test ID
    /// </summary>        
        [DisplayName("Test ID")]
        [Required(ErrorMessage = "Test ID 必填")]
    public int TestID { get; set; }
    
    /// <summary>
    /// Listen Score
    /// </summary>        
        [DisplayName("Listen Score")]
    public Nullable<int> ListenScore { get; set; }
    
    /// <summary>
    /// Read Score
    /// </summary>        
        [DisplayName("Read Score")]
    public Nullable<int> ReadScore { get; set; }
    
    /// <summary>
    /// Say Score
    /// </summary>        
        [DisplayName("Say Score")]
    public Nullable<int> SayScore { get; set; }
    
    /// <summary>
    /// Write Score
    /// </summary>        
        [DisplayName("Write Score")]
    public Nullable<int> WriteScore { get; set; }
    
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
