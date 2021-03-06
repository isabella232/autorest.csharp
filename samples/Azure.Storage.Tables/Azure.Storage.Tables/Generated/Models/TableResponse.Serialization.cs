// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Tables.Models
{
    public partial class TableResponse
    {
        internal static TableResponse DeserializeTableResponse(JsonElement element)
        {
            Optional<string> odataMetadata = default;
            Optional<string> tableName = default;
            Optional<string> odataType = default;
            Optional<string> odataId = default;
            Optional<string> odataEditLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("odata.metadata"))
                {
                    odataMetadata = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("TableName"))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.id"))
                {
                    odataId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("odata.editLink"))
                {
                    odataEditLink = property.Value.GetString();
                    continue;
                }
            }
            return new TableResponse(tableName.Value, odataType.Value, odataId.Value, odataEditLink.Value, odataMetadata.Value);
        }
    }
}
