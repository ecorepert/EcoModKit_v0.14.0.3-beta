// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SharkJawsObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
[Category("Hidden")]
[NotSpawnable]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RequireComponent(typeof (ForSaleComponent), null)]
[Tag("Usable")]
public class SharkJawsObject : WorldObject, IRepresentsItem
{
  public virtual Type RepresentedItemType { get; }

  public override LocString DisplayName { get; }

  public override TableTextureMode TableTexture { get; }
}
