using ProjectLawyer.Domain.Entity.Base;

namespace ProjectLawyer.Domain.Entity
{
    public class City : EntityBase
    {
        public string Name { get; set; }
        /// <summary>
        /// Código do IBGE
        /// </summary>
        public string CityCode { get; set; } = string.Empty;

        //Relacionamento
        public long StateId { get; set; }
        public virtual State State { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}
