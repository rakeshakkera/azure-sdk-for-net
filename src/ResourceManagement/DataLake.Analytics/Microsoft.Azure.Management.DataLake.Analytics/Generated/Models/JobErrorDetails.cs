// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The Data Lake Analytics job error details.
    /// </summary>
    public partial class JobErrorDetails
    {
        /// <summary>
        /// Initializes a new instance of the JobErrorDetails class.
        /// </summary>
        public JobErrorDetails() { }

        /// <summary>
        /// Initializes a new instance of the JobErrorDetails class.
        /// </summary>
        public JobErrorDetails(string description = default(string), string details = default(string), int? endOffset = default(int?), string errorId = default(string), string filePath = default(string), string helpLink = default(string), string internalDiagnostics = default(string), int? lineNumber = default(int?), string message = default(string), string resolution = default(string), JobInnerError innerError = default(JobInnerError), string severity = default(string), string source = default(string), string startOffset = default(string))
        {
            Description = description;
            Details = details;
            EndOffset = endOffset;
            ErrorId = errorId;
            FilePath = filePath;
            HelpLink = helpLink;
            InternalDiagnostics = internalDiagnostics;
            LineNumber = lineNumber;
            Message = message;
            Resolution = resolution;
            InnerError = innerError;
            Severity = severity;
            Source = source;
            StartOffset = startOffset;
        }

        /// <summary>
        /// Gets or sets the error message description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the details of the error message.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the end offset in the job where the error was found.
        /// </summary>
        [JsonProperty(PropertyName = "endOffset")]
        public int? EndOffset { get; set; }

        /// <summary>
        /// Gets or sets the specific identifier for the type of error
        /// encountered in the job.
        /// </summary>
        [JsonProperty(PropertyName = "errorId")]
        public string ErrorId { get; set; }

        /// <summary>
        /// Gets or sets the path to any supplemental error files, if any.
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the link to MSDN or Azure help for this type of
        /// error, if any.
        /// </summary>
        [JsonProperty(PropertyName = "helpLink")]
        public string HelpLink { get; set; }

        /// <summary>
        /// Gets or sets the internal diagnostic stack trace if the user
        /// requesting the job error details has sufficient permissions it
        /// will be retrieved, otherwise it will be empty.
        /// </summary>
        [JsonProperty(PropertyName = "internalDiagnostics")]
        public string InternalDiagnostics { get; set; }

        /// <summary>
        /// Gets or sets the specific line number in the job where the error
        /// occured.
        /// </summary>
        [JsonProperty(PropertyName = "lineNumber")]
        public int? LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the user friendly error message for the failure.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the recommended resolution for the failure, if any.
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public string Resolution { get; set; }

        /// <summary>
        /// Gets or sets the inner error of this specific job error message,
        /// if any.
        /// </summary>
        [JsonProperty(PropertyName = "InnerError")]
        public JobInnerError InnerError { get; set; }

        /// <summary>
        /// Gets or sets the severity level of the failure. Possible values
        /// for this property include: 'Warning', 'Error'.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets or sets the ultimate source of the failure (usually either
        /// SYSTEM or USER).
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the end offset in the job where the error was found
        /// </summary>
        [JsonProperty(PropertyName = "startOffset")]
        public string StartOffset { get; set; }

    }
}
