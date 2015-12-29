using System.Collections.Generic;
using FreshMail.Response;

namespace FreshMail.Models.SubscribersLists.CustomFields
{
    public class CustomFieldsListResponse: EmptyApiResponse
    {
        public List<CustomFieldListItem> Fields { get; set; }
    }
}