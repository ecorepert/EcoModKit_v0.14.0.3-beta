// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.TableTracker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Utils;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Economy;

public class TableTracker : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public Item TableItem { get; }

  [SyncToView(null, true)]
  public float FeePerItem { get; }

  [SyncToView(null, true)]
  public float FeePerMinute { get; }

  [SyncToView(null, true)]
  public Vector3i Position { get; }

  [SyncToView(null, true)]
  public string CurrencyName { get; }

  [SyncToView(null, true)]
  public Item CurrentlyCrafting { get; }

  [SyncToView(null, true)]
  public WorkOrder CurrentWorkOrder { get; }

  [SyncToView(null, true)]
  public ImmutableCountdown TotalCraftTime { get; }

  [SyncToView(null, true)]
  public string TableName { get; }

  public CraftingComponent Crafting { get; }

  public CreditComponent Credit { get; }

  [NewTooltipChildren(CacheAs.Instance)]
  public WorldObject WorldObject { get; }

  public ref int ControllerID { get; }

  public TableTracker(CraftingComponent crafting);
}
