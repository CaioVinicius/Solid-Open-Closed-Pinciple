namespace SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Entities
{
    public class Client
    {
        public Client(string name)
        {
            Name = name;

            Id = Guid.NewGuid();
            Subscriptions = new List<Subscription>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(DateTime expirationDate, SubscriptionTypeEnum subscriptionType)
        {
            var subscription = new Subscription(expirationDate, subscriptionType);
            Subscriptions.Add(subscription);
        }
    }
}
