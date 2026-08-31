// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ColoredFlowerItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary> Temp base flower class while flower coloring not implemented </summary>
[Tag("Flower")]
[Tag("CanBeOnSurface")]
[Serialized]
[ItemGroup("Flower")]
public abstract class ColoredFlowerItem : 
  SpoilageItem,
  IPlaceableItem,
  IController,
  IViewController,
  IHasUniversalID,
  IInteractor,
  IHasInteractions
{
  public abstract HomeFurnishingValue HomeValue { get; }

  public override bool CanBeHeld { get; }

  public override float BaseShelfLife { get; }

  public Type WorldObjectType { get; }
}
