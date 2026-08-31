// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Weaving.RuntimeWeaver
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using System;
using System.IO;

#nullable enable
namespace Eco.ModKit.Internal.Weaving;

/// <summary><see cref="T:Eco.ModKit.Internal.Weaving.RuntimeWeaver" /> adds support for Fody weaving in runtime.</summary>
public sealed class RuntimeWeaver : IDisposable
{
  /// <summary>Weaves assembly defined by <paramref name="assemblyStream" /> and <paramref name="symbolsStream" />. It applies all weavers from provided config file.</summary>
  public static bool Weave(Stream assemblyStream, Stream symbolsStream, string configPath);

  public void Dispose();
}
