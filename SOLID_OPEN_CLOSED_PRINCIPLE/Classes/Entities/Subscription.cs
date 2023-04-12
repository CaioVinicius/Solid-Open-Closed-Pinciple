namespace SOLID_OPEN_CLOSED_PRINCIPLE.Classes.Entities
{
    public class Subscription
    {
        public Subscription(DateTime expirationDate, SubscriptionTypeEnum subscriptionType)
        {
            ExpirationDate = expirationDate;
            SubscriptionType = subscriptionType;
            
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public DateTime ExpirationDate { get; set; }
        public SubscriptionTypeEnum SubscriptionType { get; set; }

        public bool IsActive => ExpirationDate >= DateTime.UtcNow;
    }
}
