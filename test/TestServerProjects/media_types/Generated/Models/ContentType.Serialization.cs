// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace media_types.Models
{
    internal static class ContentTypeExtensions
    {
        public static string ToSerialString(this ContentType value) => value switch
        {
            ContentType.ApplicationPdf => "application/pdf",
            ContentType.ImageJpeg => "image/jpeg",
            ContentType.ImagePng => "image/png",
            ContentType.ImageTiff => "image/tiff",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContentType value.")
        };

        public static ContentType ToContentType(this string value)
        {
            if (string.Equals(value, "application/pdf", StringComparison.InvariantCultureIgnoreCase)) return ContentType.ApplicationPdf;
            if (string.Equals(value, "image/jpeg", StringComparison.InvariantCultureIgnoreCase)) return ContentType.ImageJpeg;
            if (string.Equals(value, "image/png", StringComparison.InvariantCultureIgnoreCase)) return ContentType.ImagePng;
            if (string.Equals(value, "image/tiff", StringComparison.InvariantCultureIgnoreCase)) return ContentType.ImageTiff;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContentType value.");
        }
    }
}
