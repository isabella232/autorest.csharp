// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Inheritance.Models
{
    public partial class ClassThatInheritsFromBaseClassWithDiscriminatorAndSomeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SomeProperty))
            {
                writer.WritePropertyName("SomeProperty");
                writer.WriteStringValue(SomeProperty);
            }
            if (Optional.IsDefined(SomeOtherProperty))
            {
                writer.WritePropertyName("SomeOtherProperty");
                writer.WriteStringValue(SomeOtherProperty);
            }
            writer.WritePropertyName("DiscriminatorProperty");
            writer.WriteStringValue(DiscriminatorProperty);
            if (Optional.IsDefined(BaseClassProperty))
            {
                writer.WritePropertyName("BaseClassProperty");
                writer.WriteStringValue(BaseClassProperty);
            }
            writer.WriteEndObject();
        }

        internal static ClassThatInheritsFromBaseClassWithDiscriminatorAndSomeProperties DeserializeClassThatInheritsFromBaseClassWithDiscriminatorAndSomeProperties(JsonElement element)
        {
            Optional<string> someProperty = default;
            Optional<string> someOtherProperty = default;
            string discriminatorProperty = default;
            Optional<string> baseClassProperty = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("SomeProperty"))
                {
                    someProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("SomeOtherProperty"))
                {
                    someOtherProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DiscriminatorProperty"))
                {
                    discriminatorProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("BaseClassProperty"))
                {
                    baseClassProperty = property.Value.GetString();
                    continue;
                }
            }
            return new ClassThatInheritsFromBaseClassWithDiscriminatorAndSomeProperties(baseClassProperty.Value, discriminatorProperty, someProperty.Value, someOtherProperty.Value);
        }
    }
}
