using SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Entities;
using SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Proccess.CreateClientSubscription.Base;

namespace SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Proccess.CreateClientSubscription
{
    public class CreateClientFreeSubscription : CreateClientSubscriptionProccess, ICreateClientSubscriptionProccess
    {
        public override string Execute(Client client)
        {
            if (base.ClientAlreadyHasSubscriptions(client))
            {
                throw new Exception("This client already has subscriptions. Free subscriptions are for first timers only.");
            }

            var expirationDate = DateTime.UtcNow.AddDays(15);
            client.CreateSubscription(expirationDate, SubscriptionTypeEnum.Free);

            return "Free Subscription created!";
        }
    }
}
