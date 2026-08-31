// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClausePlowField
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[LocDescription("With this clause, the contractor must plow the given number of square meters of field into plantable soil.\n\nThe contractor will temporarily be given right to plow on the specified property.\n\nNote: You can split property into seperate deeds for more control.")]
public class ContractClausePlowField : ContractClausePropertyBase
{
  public override LocString Name { get; }

  public override LocString Describe { get; }

  protected override string PropertyDescription { get; }

  [Serialized]
  [SyncToView(null, true)]
  public int FieldSize { get; set; }

  [RPC]
  public void SetFieldSize(int val);

  public override Result Valid(User contractor, User client);

  public override Result CanSucceed(User contractor, User client);

  public override bool ShouldOverrideAuth(GameAction action);

  public override void TryJoin(GameActionPack pack, User contractor, User client);
}
