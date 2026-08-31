// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.BonusContextExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Convenience factory extensions for building <see cref="T:Eco.Gameplay.Bonuses.BonusContext" />. </summary>
public static class BonusContextExtensions
{
  /// <summary> Build a <see cref="T:Eco.Gameplay.Bonuses.BonusContext" /> for this user with the given action and optional item. </summary>
  public static BonusContext MakeBonusContext(this User user, BonusAction action, Item item = null);
}
