using System.Threading.Tasks;
using FreshMail.Models.SubscribersLists;
using FreshMail.Models.SubscribersLists.CustomFields;
using FreshMail.Response;

namespace FreshMail.Wrappers
{
    public class SubscribersListsWrapper : BaseWrapper
    {
        public SubscribersListsWrapper(RequestHandler requestHandler) : base(requestHandler)
        {
        }

        public async Task<SubscribersListResponse> Get()
        {
            return await Handler.Execute<SubscribersListResponse>("subscribers_list/lists");
        }
        public async Task<CreateSubscriberListResponse> Create(CreateSubscriberList data)
        {
            return await Handler.Execute<CreateSubscriberListResponse>("subscribers_list/create", data);
        }
        public async Task<ApiResponse<string>> Update(UpdateSubscriberList data)
        {
            return await Handler.Execute<ApiResponse<string>>("subscribers_list/update", data);
        }

        public async Task<CustomFieldResponse> AddCustomField(CustomFieldRequest data)
        {
            return await Handler.Execute<CustomFieldResponse>("subscribers_list/addField", data);
        }

        public async Task<CustomFieldsListResponse> GetCustomFields(string listHash)
        {
            return await Handler.Execute<CustomFieldsListResponse>("subscribers_list/getFields", new {hash = listHash});
        }

        public async Task<ApiResponse<string>> Delete(string hash)
        {
            return await Handler.Execute<ApiResponse<string>>("subscribers_list/delete", new {hash = hash});
        }
    }
}
