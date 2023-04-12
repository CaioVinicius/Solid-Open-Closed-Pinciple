using SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Entities;

namespace SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Proccess.CreateClientSubscription.Base
{
    public interface ICreateClientSubscriptionProccess
    {
        public string Execute(Client client);
    }
}
