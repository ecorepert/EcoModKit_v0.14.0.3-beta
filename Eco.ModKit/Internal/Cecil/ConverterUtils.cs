// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Cecil.ConverterUtils
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Mono.Cecil;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

#nullable enable
namespace Eco.ModKit.Internal.Cecil;

/// <summary>Utility and extension methods for converters.</summary>
internal static class ConverterUtils
{
  public static void AddGenericParameters(
    this IGenericParameterProvider target,
    EntityHandle targetHandle,
    GenericParameterHandleCollection genericParams,
    IGenericParameterProvider? genericContext,
    ConverterContext context);

  /// <summary>Checks if <paramref name="attributes" /> are for nested type.</summary>
  public static bool IsNested(this TypeAttributes attributes);

  /// <summary>Returns reference type for metadata retrieval for <paramref name="primitiveTypeCode" />.</summary>
  public static Type GetReferenceType(this PrimitiveTypeCode primitiveTypeCode);

  /// <summary>Tries to get primitive type for <paramref name="typeReference" /> (based on name).</summary>
  public static bool TryGetPrimitiveType(
    TypeReference typeReference,
    out PrimitiveTypeCode primitiveTypeCode,
    [MaybeNullWhen(false)] out Type primitiveType);
}
