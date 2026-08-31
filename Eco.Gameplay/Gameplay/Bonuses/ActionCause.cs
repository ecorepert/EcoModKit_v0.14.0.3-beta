// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Bonuses.ActionCause
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Bonuses;

/// <summary> Triggers when the action being performed matches a specific <see cref="T:Eco.Gameplay.Bonuses.BonusAction" />. </summary>
public class ActionCause : BonusCause
{
  /// <summary> The action type that must match <see cref="P:Eco.Gameplay.Bonuses.BonusContext.Action" />. </summary>
  public BonusAction Action { get; init; }

  public override bool IsTriggered(BonusContext context);

  public override LocString Description();
}
