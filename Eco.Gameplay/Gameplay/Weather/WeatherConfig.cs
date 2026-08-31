// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Weather.WeatherConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Weather;

/// <summary>
/// Configuration model for the <see cref="T:Eco.Gameplay.Weather.WeatherPlugin" />.
/// </summary>
public sealed class WeatherConfig
{
  [LocDescription("The minimum time a weather system can last in minutes.")]
  public int MinWeatherSystemLifespan { get; set; }

  [LocDescription("The maximum time a weather system can last in minutes.")]
  public int MaxWeatherSystemLifespan { get; set; }

  [LocDescription("The minimum time of clear weather between weather events in minutes.")]
  public int MinClearWeatherDuration { get; set; }

  [LocDescription("The maximum time of clear weather between weather events in minutes.")]
  public int MaxClearWeatherDuration { get; set; }

  [LocDescription("Weather event chances. Bigger weight = more chance to happen.")]
  public List<WeightedWeather> WeatherWeights { get; set; }
}
