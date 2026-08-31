// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.WoodShopCartObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Components.Store;
using Eco.Gameplay.Economy;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Property;
using Eco.Gameplay.Skills;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary> This represents wood shop cart. It's a special shop which you can move by pulling it. Implements IFreezable, so when nobody pull it, it won't move anyway. </summary>
[Serialized]
[RequireComponent(typeof (StandaloneAuthComponent), null)]
[RequireComponent(typeof (PaintableComponent), null)]
[RequireComponent(typeof (PublicStorageComponent), null)]
[RequireComponent(typeof (SharedMovableLinkComponent), null)]
[RequireComponent(typeof (VehicleComponent), null)]
[RequireComponent(typeof (CustomTextComponent), null)]
[RequireComponent(typeof (ModularStockpileComponent), null)]
[RequireComponent(typeof (MinimapComponent), null)]
[RequireComponent(typeof (PartsComponent), null)]
[RepairRequiresSkill(typeof (BasicEngineeringSkill), 1)]
[Ecopedia("Crafted Objects", "Vehicles", false, true, "WoodShopCart Item")]
[RequireComponent(typeof (StoreComponent), null)]
public class WoodShopCartObject : 
  PhysicsWorldObject,
  IRepresentsItem,
  INullCurrencyAllowed,
  IFreezable,
  INetObject,
  IEcoObject,
  ICanOverrideAuth
{
  public override TableTextureMode TableTexture { get; }

  public override bool PlacesBlocks { get; }

  public override LocString DisplayName { get; }

  public Type RepresentedItemType { get; }

  protected override void Initialize();

  public NetPhysicsEntity NetEntity { get; }

  public float GroundDistance { get; set; }

  protected override void PostInitialize();

  protected override void OnCreatePostInitialize();

  public LazyResult ShouldOverrideAuth(IAlias alias, IOwned property, GameAction action);
}
