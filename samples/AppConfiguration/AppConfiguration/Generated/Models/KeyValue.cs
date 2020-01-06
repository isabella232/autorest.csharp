// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace AppConfiguration.Models.V10
{
    public partial class KeyValue
    {
        public string? Key { get; set; }
        public string? Label { get; set; }
        public string? ContentType { get; set; }
        public string? Value { get; set; }
        public DateTimeOffset? LastModified { get; set; }
        public IDictionary<string, string>? Tags { get; set; }
        public bool? Locked { get; set; }
        public string? Etag { get; set; }
    }
}