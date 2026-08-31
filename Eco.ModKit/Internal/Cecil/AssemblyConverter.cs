// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Cecil.AssemblyConverter
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Mono.Cecil;
using System.Reflection;

#nullable enable
namespace Eco.ModKit.Internal.Cecil;

/// <summary>
/// Converter from runtime <see cref="T:System.Reflection.Assembly" /> to <see cref="T:Mono.Cecil.AssemblyDefinition" />. We need this converter because for single-file executable there only in-memory assembly, but <see cref="M:Mono.Cecil.AssemblyDefinition.ReadAssembly(System.String)" /> requires a file on disk.
/// So instead of reading it with standard reader we generate new assembly using meta info of in-memory assembly.
/// </summary>
internal static class AssemblyConverter
{
  /// <summary>Converts runtime <paramref name="assembly" /> to <see cref="T:Mono.Cecil.AssemblyDefinition" />.</summary>
  public static AssemblyDefinition Convert(Assembly assembly);
}
