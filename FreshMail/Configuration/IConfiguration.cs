using System;

namespace FreshMail.Configuration
{
    public interface IFreshMailConfiguration
    {
        Uri BaseAddress { get;  }
        string ApiKey { get;  }
        string ApiSecret { get;  }
    }
}
