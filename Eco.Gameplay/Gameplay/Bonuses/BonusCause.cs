// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusCause
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Defines when a bonus should trigger. </summary>
public abstract class BonusCause : IDescribable
{
  /// <summary> Check if this cause is triggered for the given context. All causes in a Bonus must return true for the bonus to apply. </summary>
  public abstract bool IsTriggered(BonusContext context);

  /// <summary> Describe when this cause triggers (Example: "when crafting wooden planks"). </summary>
  public abstract LocString Description();
}
