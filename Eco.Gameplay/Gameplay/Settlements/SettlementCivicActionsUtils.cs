// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementCivicActionsUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;

#nullable disable
namespace Eco.Gameplay.Settlements;

public static class SettlementCivicActionsUtils
{
  /// <summary>Check for settlement joining/inviting validity</summary>
  /// <remarks>`inviting` boolean is to determine we are inviting or applying to the target settlement</remarks>
  public static Result CanInviteOrApply(
    this Settlement originSettlement,
    Settlement targetSettlement,
    bool inviting);
}
