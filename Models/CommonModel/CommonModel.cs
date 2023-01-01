namespace Apex.GameZone.UI.Models.CommonModel;

public class CommonModel
{
    public int Id { get; set; }
    public DateTime? AddedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool IsDeleted { get; set; } = false;
}