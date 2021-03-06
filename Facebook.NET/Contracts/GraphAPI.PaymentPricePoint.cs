﻿using System;
using System.Runtime.Serialization;

namespace Facebook
{
    public static partial class GraphApi
    {
        [DataContract]
        public sealed class PaymentPricePoint
        {
            [DataMember(Name = "mobile")]
            public PricePoint[] Mobile { get; set; }
        }
    }
}