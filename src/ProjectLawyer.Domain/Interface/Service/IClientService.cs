using ProjectLawyer.Domain.Entity;

namespace ProjectLawyer.Domain.Interface.Service
{
    public interface IClientService
    {
        Task<Client> GetAllClientActive();
    }
}