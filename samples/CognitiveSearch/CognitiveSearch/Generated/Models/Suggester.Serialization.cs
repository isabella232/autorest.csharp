// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class Suggester : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("searchMode");
            writer.WriteStringValue(SearchMode.ToSerialString());
            writer.WritePropertyName("sourceFields");
            writer.WriteStartArray();
            foreach (var item in SourceFields)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static Suggester DeserializeSuggester(JsonElement element)
        {
            string name = default;
            SearchMode searchMode = default;
            IList<string> sourceFields = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchMode"))
                {
                    searchMode = property.Value.GetString().ToSearchMode();
                    continue;
                }
                if (property.NameEquals("sourceFields"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sourceFields = array;
                    continue;
                }
            }
            return new Suggester(name, searchMode, sourceFields);
        }
    }
}
