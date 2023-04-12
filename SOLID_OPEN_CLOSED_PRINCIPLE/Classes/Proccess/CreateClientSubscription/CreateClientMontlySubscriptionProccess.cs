using SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Entities;
using SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Proccess.CreateClientSubscription.Base;

namespace SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Proccess.CreateClientSubscription
{
    public class CreateClientMontlySubscriptionProccess : CreateClientSubscriptionProccess, ICreateClientSubscriptionProccess
    {
        public override string Execute(Client client)
        {
            if (base.ClientAlreadyHasActiveSubscription(client))
            {
                throw new Exception("This client already has active subscriptions. Should pass through validate subscriptions proccess, " +
                                    "wich is going to renew expiration date for more or cancell");
            }

            var expirationDate = DateTime.UtcNow.AddDays(30);
            client.CreateSubscription(expirationDate, SubscriptionTypeEnum.Montly);

            return "Montly Subscription created!";
        }
    }
}
