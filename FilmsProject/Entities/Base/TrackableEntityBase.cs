using FilmProject.Entities.Base;

namespace FilmsProject.Entities.Base
{
    public class TrackableEntityBase<TId> : EntityBase<TId>, ITrackableEntityBase
    {
        public TrackableEntityBase()
        {
            CreatedOn = DateTime.Now;
        }

        public bool IsDeleted { get; set; }

        public DateTime CreatedOn { get; set; }
        public long CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }
        public long? UpdatedBy { get; set; }
    }
}
