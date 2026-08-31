// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Cecil.ModuleConverter
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Mono.Cecil;
using System.Reflection;
using System.Reflection.Metadata;

#nullable enable
namespace Eco.ModKit.Internal.Cecil;

/// <summary>Converts metadata obtained wirth <see cref="F:Eco.ModKit.Internal.Cecil.ModuleConverter.reader" /> to <see cref="T:Mono.Cecil.ModuleDefinition" />.</summary>
public readonly struct ModuleConverter
{
  private readonly MetadataReader reader;

  public ModuleConverter(MetadataReader reader);

  /// <summary>Converts metadata obtained with <see cref="F:Eco.ModKit.Internal.Cecil.ModuleConverter.reader" /> (set in constructor) to <see cref="T:Mono.Cecil.ModuleDefinition" />.</summary>
  public ModuleDefinition Convert(AssemblyName assemblyName);
}
