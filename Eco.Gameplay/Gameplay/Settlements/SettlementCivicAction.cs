// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementCivicAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics;

#nullable enable
namespace Eco.Gameplay.Settlements;

/// <summary>Settlement civics actions</summary>
public abstract class SettlementCivicAction : CivicAction
{
  public override bool IsSameAction(CivicAction action);
}
