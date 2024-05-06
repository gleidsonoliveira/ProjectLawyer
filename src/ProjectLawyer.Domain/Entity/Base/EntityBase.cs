using ProjectLawyer.Domain.Enum;

namespace ProjectLawyer.Domain.Entity.Base
{
    public class EntityBase
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Situation Situation { get; set; }
        public int CreatedUserId { get; set; }
        public int? ModifiedUserId { get; set; }
        public int? DeletedUserId { get; set; }
        public string? Observation { get; set; }
    }
}