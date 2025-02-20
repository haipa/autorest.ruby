﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 

using AutoRest.Core.Extensibility;
using AutoRest.Core.Model;
using AutoRest.Core.Utilities;
using AutoRest.Ruby.Haipa.Model;
using AutoRest.Ruby.Model;

namespace AutoRest.Ruby.Haipa
{
    public sealed class PluginRba : Plugin<GeneratorSettingsRb, TransformerRba, CodeGeneratorRba, CodeNamerRb, CodeModelRba>
    {
        public PluginRba()
        {
            Context = new DependencyInjection.Context
            {
                // inherit base settings
                Context,

                // set code model implementations our own implementations 
                new Factory<CodeModel, CodeModelRba>(),
                new Factory<Method, MethodRba>(),
                new Factory<CompositeType, CompositeTypeRba>(),
                new Factory<Property, PropertyRb>(),
                new Factory<Parameter, ParameterRb>(),
                new Factory<DictionaryType, DictionaryTypeRb>(),
                new Factory<SequenceType, SequenceTypeRb>(),
                new Factory<MethodGroup, MethodGroupRba>(),
                new Factory<EnumType, EnumTypeRb>(),
                new Factory<PrimaryType, PrimaryTypeRb>()
            };
        }
    }
}