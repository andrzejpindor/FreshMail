namespace FreshMail.Models.Subscribers
{
    public enum SubscriberStatus
    {
        Active = 1,
        PendingActivation = 2,
        Inactive = 3,
        SignedOut = 4,
        SoftBounced = 5,
        //6 - not documented
        //7 - not documented
        HardBounced = 8
    }
}
