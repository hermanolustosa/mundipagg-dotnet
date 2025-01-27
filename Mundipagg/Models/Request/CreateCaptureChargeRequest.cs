using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCaptureChargeRequest
    {
        public int? Amount { get; set; }

        public string Code { get; set; }

        public List<CreateSplitRequest> Split { get; set; }

        public DateTime? InitiatorDate { get; set; }

        public string InitiatorReference { get; set; }
    }
}