﻿using Bitbucket.Net.Models.Projects;

namespace Bitbucket.Net.Common.Converters
{
    public class WebHookOutcomesConverter : JsonEnumConverter<WebHookOutcomes>
    {
        protected override string ConvertToString(WebHookOutcomes value)
        {
            return BitbucketHelpers.WebHookOutcomeToString(value);
        }

        protected override WebHookOutcomes ConvertFromString(string s)
        {
            return BitbucketHelpers.StringToWebHookOutcome(s);
        }
    }
}
