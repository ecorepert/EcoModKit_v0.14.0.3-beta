// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Cecil.TypeConverter
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Mono.Cecil;
using System.Collections.Generic;
using System.Reflection.Metadata;

#nullable enable
namespace Eco.ModKit.Internal.Cecil;

/// <summary>Converter from <see cref="T:System.Reflection.Metadata.TypeDefinitionHandle" /> to <see cref="T:Mono.Cecil.TypeDefinition" /> and from <see cref="T:System.Reflection.Metadata.TypeReferenceHandle" /> to <see cref="T:Mono.Cecil.TypeReference" />.</summary>
internal readonly struct TypeConverter
{
  private readonly ConverterContext context;

  public TypeConverter(ConverterContext context);

  /// <summary>Converts <paramref name="handle" /> to <see cref="T:Mono.Cecil.TypeReference" />. Uses <paramref name="assemblyReferences" /> for scope lookup.</summary>
  public static TypeReference ConvertAsReference(
    MetadataReader reader,
    TypeReferenceHandle handle,
    IDictionary<AssemblyReferenceHandle, AssemblyNameReference> assemblyReferences);

  /// <summary>Converts <paramref name="handle" /> to <see cref="T:Mono.Cecil.TypeDefinition" />. This doesn't make full conversion (should be done with <see cref="M:Eco.ModKit.Internal.Cecil.TypeConverter.ConvertAsDefinition(System.Reflection.Metadata.TypeDefinitionHandle)" />) later, but instead creates it as a type reference for type lookups.</summary>
  public static TypeDefinition ConvertAsReference(
    MetadataReader reader,
    TypeDefinitionHandle handle);

  /// <summary>Converts <paramref name="handle" /> to <see cref="T:Mono.Cecil.TypeDefinition" />. Makes full conversion. Initial conversion with <see cref="M:Eco.ModKit.Internal.Cecil.TypeConverter.ConvertAsReference(System.Reflection.Metadata.MetadataReader,System.Reflection.Metadata.TypeReferenceHandle,System.Collections.Generic.IDictionary{System.Reflection.Metadata.AssemblyReferenceHandle,Mono.Cecil.AssemblyNameReference})" /> should be done before that and converted type added to <see cref="F:Eco.ModKit.Internal.Cecil.TypeConverter.context" />. Converts base type, generic parameters, interfaces and members.</summary>
  public TypeDefinition ConvertAsDefinition(TypeDefinitionHandle handle);
}
