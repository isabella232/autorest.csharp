// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using NamespaceForEnums;

namespace TypeSchemaMapping.Models
{
    /// <summary> The ModelWithArrayOfEnum. </summary>
    internal partial class ModelWithArrayOfEnum
    {
        public IReadOnlyList<EnumForModelWithArrayOfEnum> ArrayOfEnum { get; }
        public IReadOnlyList<EnumForModelWithArrayOfEnum?> ArrayOfEnumCustomizedToNullable { get; }
    }
}