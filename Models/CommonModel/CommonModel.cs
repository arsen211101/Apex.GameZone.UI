namespace Apex.GameZone.UI.Models
{
    public class CommonModel
    {
        public int Id { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
