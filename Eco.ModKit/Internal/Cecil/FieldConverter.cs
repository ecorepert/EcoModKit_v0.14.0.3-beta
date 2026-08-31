// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Cecil.FieldConverter
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Mono.Cecil;
using System.Reflection.Metadata;

#nullable enable
namespace Eco.ModKit.Internal.Cecil;

/// <summary>Converter from <see cref="T:System.Reflection.Metadata.FieldDefinitionHandle" /> to <see cref="T:Mono.Cecil.FieldDefinition" />.</summary>
internal readonly struct FieldConverter
{
  private readonly ConverterContext context;

  public FieldConverter(ConverterContext context);

  /// <summary>Converts <paramref name="handle" /> to <see cref="T:Mono.Cecil.FieldDefinition" />.  Uses <paramref name="owner" /> as generic context.</summary>
  public FieldDefinition Convert(FieldDefinitionHandle handle, TypeDefinition owner);
}
