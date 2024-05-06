using System.ComponentModel;

namespace ProjectLawyer.Domain.Enum
{
    public enum Situation
    {
        [Description("--- Selecione ---")]
        Selected,
        [Description("Ativo")]
        Active,
        [Description("Inativo")]
        Inactive,
        [Description("Deletado")]
        Deleted
    }
}
