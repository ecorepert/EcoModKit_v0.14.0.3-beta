// Decompiled with JetBrains decompiler
// Type: ContractTracker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy.Contracts;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;

#nullable disable
public class ContractTracker : UnserializedEntry
{
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.LinkControls)]
  public Contract Contract { get; }

  [SyncToView(null, true)]
  public string Payment { get; }

  [SyncToView(null, true)]
  public string Deposit { get; }

  [SyncToView(null, true)]
  public Vector3i Position { get; }

  [SyncToView(null, true)]
  public string Currency { get; }

  [SyncToView(null, true)]
  public string Name { get; }

  [SyncToView(null, true)]
  public ProposableState State { get; }

  public ContractTracker(Contract contract);

  ~ContractTracker();

  [RPC]
  public void Open(Player player);

  public override void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public override LocString UILinkContent();
}
