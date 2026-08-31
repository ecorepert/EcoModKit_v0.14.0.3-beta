// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.TickSamples.TotalTimeTickSample
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Core.Plugins.TickSamples;

/// <summary> Tick Sampler to use for tick analysis. </summary>
[Localized(true, false, "", false)]
public struct TotalTimeTickSample : ITickSample
{
  public double TimeTotal { get; set; }

  public static implicit operator TotalTimeTickSample(double value);
}
