﻿using System;
using System.Runtime.Serialization;

using DigitalRuby.IPBanCore;

namespace DigitalRuby.IPBanProSDK
{
    /// <summary>
    /// Model for license keys
    /// </summary>
    [Serializable]
    [DataContract]
    public class LicensesModel : BaseModel
    {
        /// <summary>
        /// License key info, newline (\n) delimited.
        /// </summary>
        [DataMember(Order = 1)]
        [LocalizedDisplayName(nameof(IPBanResources.Licenses))]
        public string Licenses { get; set; }
    }
}
