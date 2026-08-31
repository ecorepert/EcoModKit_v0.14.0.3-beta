// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Cecil.ConverterContext
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Mono.Cecil;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection.Metadata;

#nullable enable
namespace Eco.ModKit.Internal.Cecil;

/// <summary><see cref="T:Eco.ModKit.Internal.Cecil.ConverterContext" /> contains all defined types and type references for lookups. It also implements <see cref="T:System.Reflection.Metadata.ISignatureTypeProvider`2" /> for signature parsing by <see cref="T:System.Reflection.Metadata.MetadataReader" />.</summary>
/// <inheritdoc cref="T:System.Reflection.Metadata.ISignatureTypeProvider`2" />
internal class ConverterContext : 
  ISignatureTypeProvider<TypeReference, IGenericParameterProvider?>,
  IConstructedTypeProvider<TypeReference>,
  ISZArrayTypeProvider<TypeReference>,
  ISimpleTypeProvider<TypeReference>
{
  public MetadataReader Reader { get; }

  public ConverterContext(
    MetadataReader reader,
    ModuleDefinition module,
    Dictionary<TypeDefinitionHandle, TypeDefinition> definitions,
    Dictionary<TypeReferenceHandle, TypeReference> references);

  /// <summary>Returns <see cref="T:Mono.Cecil.TypeDefinition" /> for <paramref name="handle" />. Fails if type definition doesn't exists.</summary>
  public TypeDefinition GetTypeDefinition(TypeDefinitionHandle handle);

  public TypeReference GetOrCreateTypeReference(
    EntityHandle handle,
    IGenericParameterProvider? genericContext);

  public TypeReference GetSZArrayType(TypeReference elementType);

  public TypeReference GetArrayType(TypeReference elementType, ArrayShape shape);

  public TypeReference GetByReferenceType(TypeReference elementType);

  public TypeReference GetGenericInstantiation(
    TypeReference genericType,
    ImmutableArray<TypeReference> typeArguments);

  public TypeReference GetPointerType(TypeReference elementType);

  public TypeReference GetPrimitiveType(PrimitiveTypeCode typeCode);

  public TypeReference GetTypeFromDefinition(
    MetadataReader reader,
    TypeDefinitionHandle handle,
    byte rawTypeKind);

  public TypeReference GetTypeFromReference(
    MetadataReader reader,
    TypeReferenceHandle handle,
    byte rawTypeKind);

  public TypeReference GetFunctionPointerType(MethodSignature<TypeReference> signature);

  public TypeReference GetGenericMethodParameter(
    IGenericParameterProvider? genericContext,
    int index);

  public TypeReference GetGenericTypeParameter(IGenericParameterProvider? genericContext, int index);

  public TypeReference GetModifiedType(
    TypeReference modifier,
    TypeReference unmodifiedType,
    bool isRequired);

  public TypeReference GetPinnedType(TypeReference elementType);

  public TypeReference GetTypeFromSpecification(
    MetadataReader reader,
    IGenericParameterProvider? genericContext,
    TypeSpecificationHandle handle,
    byte rawTypeKind);
}
