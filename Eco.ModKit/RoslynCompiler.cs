// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.RoslynCompiler
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Loader;

#nullable enable
namespace Eco.ModKit;

public class RoslynCompiler : ITypesProvider
{
  internal 
  #nullable disable
  Assembly Assembly;

  public RoslynCompiler(string modsDirectory, string modsAssemblyPath);

  public RoslynCompiler(
    AssemblyLoadContext assemblyContext,
    string modsDirectory,
    string modsAssemblyPath);

  /// <summary> Get all class types that are not compiler generated. </summary>
  public IEnumerable<Type> GetTypes();

  public bool HasError { get; }
}
