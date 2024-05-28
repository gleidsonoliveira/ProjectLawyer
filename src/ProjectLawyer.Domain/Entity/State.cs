using ProjectLawyer.Domain.Entity.Base;

namespace ProjectLawyer.Domain.Entity
{
    public class State : EntityBase
    {
        public string Name { get; set; }
        public string Uf { get; set; }
        /// <summary>
        /// Código do IBGE
        /// </summary>
        public string StateCode { get; set; }

        public virtual ICollection<City> Citys { get; set; }
    }
}