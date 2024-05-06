using ProjectLawyer.Domain.Entity.Base;
using ProjectLawyer.Domain.Enum;

namespace ProjectLawyer.Domain.Entity
{
    public class Client : EntityBase
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Cpf_Cnpj { get; set; }
        public string? Rg_Ie { get; set; }
        public string? Notes { get; set; }
        public TypePerson TypePerson { get; set; }
    }
}
