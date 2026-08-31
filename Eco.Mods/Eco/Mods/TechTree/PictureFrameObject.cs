// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PictureFrameObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Components;
using Eco.Gameplay.Culture.CultureItems;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>WorldObject that uses <see cref="T:Eco.Gameplay.Culture.CultureItems.PictureFrameComponent" /> to display images in the world.  We make it implemewnt
/// the IHasDynamicHomeFurnishingValue so that it can apply the value of the artwork to the property value.</summary>
[RequireComponent(typeof (PictureFrameComponent), null)]
[RequireComponent(typeof (ForSaleComponent), null)]
[Serialized]
[NotSpawnable]
public abstract class PictureFrameObject : WorldObject, IHasDynamicHomeFurnishingValue
{
  protected override void ComponentsInitialized();

  float IHasDynamicHomeFurnishingValue.DynamicFurnishingValue { get; }

  LocString IHasDynamicHomeFurnishingValue.DynamicFurnishingTitle { get; }

  object IHasDynamicHomeFurnishingValue.UniqueObject { get; }

  LocString IHasDynamicHomeFurnishingValue.UniqueObjectName { get; }
}
