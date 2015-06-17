using System; 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace KidsGEPT.Models
{
    /// <summary>
    /// Member Metadata class
    /// </summary>
    [MetadataType(typeof(MemberMetadata))] 
    public partial class Member
    {
    public class MemberMetadata
    {
    /// <summary>
    /// No
    /// </summary>        
        [DisplayName("No")]
        [Required(ErrorMessage = "No 必填")]
    public int No { get; set; }
    
    /// <summary>
    /// Group Code
    /// </summary>        
        [DisplayName("Group Code")]
        [MaxLength(10, ErrorMessage = "Group Code cannot be longer than 10 characters")]
    public string GroupCode { get; set; }
    
    /// <summary>
    /// PID
    /// </summary>        
        [DisplayName("PID")]
        [Required(ErrorMessage = "PID 必填")]
        [MaxLength(10, ErrorMessage = "PID cannot be longer than 10 characters")]
    public string PID { get; set; }
    
    /// <summary>
    /// Pwd
    /// </summary>        
        [DisplayName("Pwd")]
        [Required(ErrorMessage = "Pwd 必填")]
        [MaxLength(50, ErrorMessage = "Pwd cannot be longer than 50 characters")]
    public string Pwd { get; set; }
    
    /// <summary>
    /// Email
    /// </summary>        
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email 必填")]
    public string Email { get; set; }
    
    /// <summary>
    /// Cname
    /// </summary>        
        [DisplayName("Cname")]
        [Required(ErrorMessage = "Cname 必填")]
        [MaxLength(30, ErrorMessage = "Cname cannot be longer than 30 characters")]
    public string Cname { get; set; }
    
    /// <summary>
    /// Fname
    /// </summary>        
        [DisplayName("Fname")]
        [Required(ErrorMessage = "Fname 必填")]
        [MaxLength(50, ErrorMessage = "Fname cannot be longer than 50 characters")]
    public string Fname { get; set; }
    
    /// <summary>
    /// Lname
    /// </summary>        
        [DisplayName("Lname")]
        [Required(ErrorMessage = "Lname 必填")]
        [MaxLength(50, ErrorMessage = "Lname cannot be longer than 50 characters")]
    public string Lname { get; set; }
    
    /// <summary>
    /// Alias
    /// </summary>        
        [DisplayName("Alias")]
        [Required(ErrorMessage = "Alias 必填")]
        [MaxLength(10, ErrorMessage = "Alias cannot be longer than 10 characters")]
    public string Alias { get; set; }
    
    /// <summary>
    /// Birthday
    /// </summary>        
        [DisplayName("Birthday")]
        [Required(ErrorMessage = "Birthday 必填")]
        [MaxLength(8, ErrorMessage = "Birthday cannot be longer than 8 characters")]
    public string Birthday { get; set; }
    
    /// <summary>
    /// School ID
    /// </summary>        
        [DisplayName("School ID")]
        [Required(ErrorMessage = "School ID 必填")]
        [MaxLength(6, ErrorMessage = "School ID cannot be longer than 6 characters")]
    public string SchoolID { get; set; }
    
    /// <summary>
    /// Grade
    /// </summary>        
        [DisplayName("Grade")]
        [Required(ErrorMessage = "Grade 必填")]
        [MaxLength(2, ErrorMessage = "Grade cannot be longer than 2 characters")]
    public string Grade { get; set; }
    
    /// <summary>
    /// Tel
    /// </summary>        
        [DisplayName("Tel")]
        [Required(ErrorMessage = "Tel 必填")]
        [MaxLength(15, ErrorMessage = "Tel cannot be longer than 15 characters")]
    public string Tel { get; set; }
    
    /// <summary>
    /// Phone
    /// </summary>        
        [DisplayName("Phone")]
        [Required(ErrorMessage = "Phone 必填")]
        [MaxLength(10, ErrorMessage = "Phone cannot be longer than 10 characters")]
    public string Phone { get; set; }
    
    /// <summary>
    /// Address
    /// </summary>        
        [DisplayName("Address")]
        [Required(ErrorMessage = "Address 必填")]
    public string Address { get; set; }
    
    /// <summary>
    /// Sex
    /// </summary>        
        [DisplayName("Sex")]
        [Required(ErrorMessage = "Sex 必填")]
        [MaxLength(1, ErrorMessage = "Sex cannot be longer than 1 characters")]
    public string Sex { get; set; }
    
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
