// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseMowLawn
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[LocDescription("All grass tiles on specified property must be cut with a sickle or other mower. \n\nThe contractor will temporarily be given the right to mow on the specified property.\n\nNote: You can split property into seperate deeds for more control.")]
public class ContractClauseMowLawn : ContractClausePropertyBase
{
  public override LocString Name { get; }

  public override LocString Describe { get; }

  protected override string PropertyDescription { get; }

  public override Result Valid(User contractor, User client);

  public override Result CanSucceed(User contractor, User client);

  public override void TryJoin(GameActionPack pack, User contractor, User client);

  public override bool ShouldOverrideAuth(GameAction action);
}
