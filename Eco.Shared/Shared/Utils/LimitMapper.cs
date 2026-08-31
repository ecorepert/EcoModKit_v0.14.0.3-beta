// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.LimitMapper
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Shared.Utils;

public static class LimitMapper
{
  /// <summary>Maps an input to an output, such that as the input reaches infinity, the output will approach (but never reach) a hard cap.</summary>
  public static float Map(float val, LimitMapper.Config values);

  /// <summary>Maps the given input value to an output value, using the limits defined in 'values'.</summary>
  /// <param name="val">The value to map to an output</param>
  /// <param name="config">The config values for how the mapping occurs</param>
  /// <param name="outputName">What is the name of the resulting value type.</param>
  /// <param name="inputValDescription">A function that renders an input value (incase you want special colors/icons)</param>
  /// <param name="outputValDescription">A function that renders an output value (incase you want special colors/icons)</param>
  /// <param name="header">Text to show at the top of our display.</param>
  /// <returns></returns>
  public static (float Output, LocString Description) MapAndDescribe(
    float val,
    LimitMapper.Config config,
    LocString outputName,
    Func<float, LocString> inputValDescription,
    Func<float, LocString> outputValDescription,
    LocString header);

  /// <summary>Functions for 'soft capping' values. That is, making them approach a 'soft cap' linearly as an input changes, then approach a 'hard cap' as a limit,
  /// never actually reaching it.  This is used in various places in order to allow for unlimited improvement as a value goes up, but at diminishing returns.</summary>
  [TypeConverter(typeof (ValueTypeTypeConverter))]
  public struct Config
  {
    [LocDescription("Start the mapping at this value.")]
    public float InputMin { get; set; }

    [LocDescription("After the amount increases this much, it will increase the output half the remaining distance to the limit.")]
    public float InputHalflife { get; set; }

    [LocDescription("The output yielded when input is at or below 'InputMin'.")]
    public float OutputAtMin { get; set; }

    [LocDescription("When the input value goes 'InputHalfLife' past 'InputSoftCap', the output will reach 50% towards this value.  This is the value it will approach but never reach..")]
    public float OutputLimit { get; set; }

    public override string ToString();

    /// <summary>Describes the values of this config</summary>
    public LocString Describe(LocString input, LocString output);
  }
}
