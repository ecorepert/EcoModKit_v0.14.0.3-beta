// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Weather.WeightedWeather
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.Weather;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Weather;

[Serialized]
[TypeConverter(typeof (ExpandableObjectConverter))]
public class WeightedWeather : WeightedKVP<WeatherEventType>
{
  public WeightedWeather();

  public WeightedWeather(WeatherEventType i, int w);
}
