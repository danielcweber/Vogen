﻿using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Vogen;

public class VoWorkItem
{
    public MethodDeclarationSyntax? ValidateMethod { get; set; }

//    public INamedTypeSymbol UnderlyingType { get; set; } = null!;
    public Type UnderlyingType { get; set; } = null!;

    public TypeDeclarationSyntax TypeToAugment { get; set; } = null!;
    
    public bool IsValueType { get; set; }

    public List<InstanceProperties> InstanceProperties { get; set; } = new();

    public string FullNamespace { get; set; } = string.Empty;

    public Conversions Conversions { get; set; }

    public Type TypeForValidationExceptions { get; set; } = null!;

    public string VoTypeName => TypeToAugment.Identifier.ToString();
    
    public string UnderlyingTypeFullName => UnderlyingType.FullName ?? UnderlyingType.Name;
    //public string UnderlyingTypeFullName => UnderlyingType.FullName() ?? UnderlyingType.Name;
}