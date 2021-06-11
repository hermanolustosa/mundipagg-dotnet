using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Mundipagg.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetWebhookSettingsResponse
    {
        public string Id { get; set; }

        public string Url { get; set; }

        public string Status { get; set; }

        public string[] Events { get; set; }

        public int Interval { get; set; }

        public int Max_Attempts { get; set; }

        public string Authentication_Type { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public string AppId { get; set; }

        public string Version { get; set; }
    }
}
