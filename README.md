# FreshMail
## Usage example

First create configuration class:

```
var configuration = new FreshMailConfiguration(new Uri("https://api.freshmail.com/rest/"), "API_KEY", "API_SIGN");
```

Next - create FreshMailApiClient instance (of course register all types shown below in your IoC container):

```
FreshMailApiClient client =
                new FreshMailApiClient(new RequestHandler(new HttpClientFactory(configuration),
                    new SignProvider(configuration, new Sha1Provider()),
                    new FreshmailJsonConverter()));
```

And use as simple as:

```
Task<EmptyApiResponse> response = wrapper.Sms.Send(new SmsRequest("48123456789", "Visit our page", "example.com", SingleSettings.On));

AddSubscriberRequest request = new AddSubscriberRequest("abcdefgh", "some@example.com", SubscriberStatus.PendingActivation);
request.AddCustomField("extra_field", "some value");
Task<EmptyApiResponse> response = wrapper.Subscribers.Add(request);
```

##Missing methods implementation
* [Spam tests](http://freshmail.pl/developer-api/spamtesty/)
* [Manage users](http://freshmail.pl/developer-api/tworzenie-kont/)
* [Multiple subscribers operations](http://freshmail.pl/developer-api/subskrybenci-zarzadzanie-wieloma-subskrybentami-w-pojedynczym-zadaniu/)