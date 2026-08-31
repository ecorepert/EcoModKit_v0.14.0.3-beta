// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserDef
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Utils;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

[TypeConverter(typeof (ExpandableObjectConverter))]
public class UserDef : AutoSingleton<UserDef>
{
  public float MinPerformanceByCalories { get; set; }

  public Nutrients StartingNutrients { get; set; }

  public float StandardBodyMass { get; set; }

  public float StartingCalories { get; set; }

  public float BaseCaloriesUsesPerDay { get; set; }

  public float MinCaloriesPenalty { get; set; }

  public float MinSpeedPenalty { get; set; }

  public float DigestionDays { get; set; }

  public float MaxWasteCalories { get; set; }
}
