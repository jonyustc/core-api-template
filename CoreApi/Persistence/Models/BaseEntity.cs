namespace QMS_API.Persistence.Models
{
    public class BaseEntity
    {
        
        public string Remarks { get; set; }
        public long CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreationDate { get; set; }
        public long? LastUpdateBy { get; set; }
        public string LastUpdateByName { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
