// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.SleepConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Systems;

[Localized(true, false, "", false)]
public class SleepConfig
{
  [LocDescription("Can players fast forward time by sleeping in a bed?  If all online players sleep, time will accelerate. (This shouldn't be enabled for public servers!)")]
  public bool AllowFastForward { get; set; }

  [LocDescription("The max time multiplier that time will pass while sleeping.  Lower this to make the simulation fast-forward more reliably.")]
  public double SleepTimePassMultiplier { get; set; }

  [LocDescription("How long it takes to reach the max sleep time.  Makes for a smooth transition into sleeping.")]
  public double TimeToReachMaximumTimeRate { get; set; }
}
