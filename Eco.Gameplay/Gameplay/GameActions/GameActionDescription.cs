// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.GameActionDescription
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.GameActions;

/// <summary>
/// Wraps Game Action descriptions that are visible to the players in two tenses.(Simple tense and progressive tense).
/// </summary>
public class GameActionDescription
{
  public LocString SimpleTense { get; set; }

  public LocString ProgressiveTense { get; set; }

  public static GameActionDescription DoStr(string normal, string present);

  public static GameActionDescription Do(FormattableString normal, FormattableString present);

  public GameActionDescription(LocString normal, LocString present);

  public override string ToString();
}
