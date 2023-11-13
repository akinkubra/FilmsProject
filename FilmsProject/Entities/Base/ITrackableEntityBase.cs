namespace FilmsProject.Entities.Base
{
    public interface ITrackableEntityBase
    {
        bool IsDeleted { get; set; }
        DateTime CreatedOn { get; set; }
        long CreatedBy { get; set; }
        DateTime? UpdatedOn { get; set; }
        long? UpdatedBy { get; set; }
    }
}
