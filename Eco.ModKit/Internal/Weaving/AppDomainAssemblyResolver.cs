// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Weaving.AppDomainAssemblyResolver
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Mono.Cecil;
using System;

#nullable enable
namespace Eco.ModKit.Internal.Weaving;

/// <summary><see cref="T:Eco.ModKit.Internal.Weaving.AppDomainAssemblyResolver" /> implements Fody <see cref="T:Mono.Cecil.IAssemblyResolver" /> interface for already loaded assemblies in app domain.</summary>
/// <inheritdoc />
internal class AppDomainAssemblyResolver : IAssemblyResolver, IDisposable
{
  /// <summary>Resolves <see cref="T:Mono.Cecil.AssemblyDefinition" /> for <paramref name="name" />.</summary>
  public AssemblyDefinition? Resolve(AssemblyNameReference name);

  /// <summary>Resolves <see cref="T:Mono.Cecil.AssemblyDefinition" /> for <paramref name="name" />.</summary>
  public AssemblyDefinition? Resolve(AssemblyNameReference name, ReaderParameters parameters);

  public void Dispose();
}
