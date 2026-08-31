// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.PersonalBankAccount
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Economy;

/// <summary> Player's default bank account with an infinite amount of their personal currency. The player cannot be removed from managers list. </summary>
[Serialized]
[ForceCreateView]
[NoIcon]
public class PersonalBankAccount : 
  BankAccount,
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  ISpecialRegistrarEntry
{
  public override User AnyManager { get; }

  [SyncToView(null, true)]
  public override bool IsPermanent { get; }

  public override Settlement Settlement { get; }

  [Serialized]
  public int SpecialType { get; set; }

  public override float PercentOwnership(User user);

  public override string ToString();

  protected override bool CanHaveNullSettlement { get; }

  public override void Initialize();

  protected override bool TryRemoveManagerOrUser(
    Player player,
    IAlias alias,
    PermissionsType permissionsChangeType);

  public Result Verify();
}
