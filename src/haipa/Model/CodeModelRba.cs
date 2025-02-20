﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using AutoRest.Ruby.Model;

namespace AutoRest.Ruby.Haipa.Model
{
    /// <summary>
    /// The model for the Azure service client.
    /// </summary>
    public class CodeModelRba : CodeModelRb
    {
        // List of models with paging extensions.
        internal IList<PageRba> pageModels = new List<PageRba>();

        /// <summary>
        /// Initializes a new instance of the AzureServiceClientTemplateModel class.
        /// </summary>
        public CodeModelRba()
        {
        }

        /// <summary>
        /// Gets the list of modules/classes which need to be included.
        /// </summary>
        public override IEnumerable<string> Includes
        {
            get { yield return "Haipa::Client"; }
        }

        /// <summary>
        /// Gets the base type of the service client.
        /// </summary>
        public override string BaseType => "Haipa::Client::HaipaServiceClient";

        /// <summary>
        /// Gets the serializer type of the client.
        /// </summary>
        public override string IncludeSerializer => "include Haipa::Client::Serialization";

        /// <summary>
        /// Gets the operation response type to instantiate.
        /// </summary>
        public override string OperationResponseString => "Haipa::Client::HaipaOperationResponse";

        public override string MergeClientDefaultHeaders => "request_headers.merge!({'accept-language' => @accept_language}) unless @accept_language.nil?";
    }
}