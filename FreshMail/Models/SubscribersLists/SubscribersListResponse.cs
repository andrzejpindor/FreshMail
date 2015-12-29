using System.Collections.Generic;
using FreshMail.Response;

namespace FreshMail.Models.SubscribersLists
{
    public class SubscribersListResponse : EmptyApiResponse
    {
        public List<SubscriberList> Lists { get; set; }
    }
}