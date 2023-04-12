using SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Entities;

namespace SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Proccess.CreateClientSubscription.Base
{
    public abstract class CreateClientSubscriptionProccess : ICreateClientSubscriptionProccess
    {
        public abstract string Execute(Client client);

        protected bool ClientAlreadyHasActiveSubscription(Client client) => client.Subscriptions != null && client.Subscriptions.Any(subscription => subscription.IsActive);

        protected bool ClientAlreadyHasSubscriptions(Client client) => client.Subscriptions != null && client.Subscriptions.Any();
    }
}
