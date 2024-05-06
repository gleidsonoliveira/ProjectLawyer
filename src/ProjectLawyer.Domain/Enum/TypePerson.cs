using System.ComponentModel;

namespace ProjectLawyer.Domain.Enum
{
    public enum TypePerson
    {
        [Description("--- Selecione ---")]
        Selected,
        [Description("Pessoa Fisica")]
        Active,
        [Description("Pessoa Juridica")]
        Inactive
    }
}
