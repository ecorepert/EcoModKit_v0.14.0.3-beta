// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.Internal.SampleCollection`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.Plugins.Internal;

/// <summary>Collection of samples with sum, count and last sample. Used by <see cref="T:Eco.Core.Plugins.PluginTickTimer`1" />.</summary>
internal class SampleCollection<T> where T : ITickSample
{
  public T? LastSample { get; }

  public double Average { get; }

  public double Sum { get; }

  public ReadOnlySpan<T> UnorderedSamples { get; }

  public int Count { get; }

  public SampleCollection(int samplesCount);

  public void AddSample(T sample);

  public void Clear();
}
