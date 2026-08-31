// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.AnimalTrapComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Simulation.WorldLayers.Layers;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[RequireComponent(typeof (PublicStorageComponent), null)]
[NoIcon]
public class AnimalTrapComponent : WorldObjectComponent
{
  public PublicStorageComponent Storage { get; }

  public List<AnimalLayer> TargetLayers { get; }

  public override void Initialize();

  public void UpdateTrappingStatus();

  public override bool Enabled { get; }

  public Func<Vector3i, bool> EnabledTest { get; set; }

  public LocString FailStatusMessage { get; set; }

  public void UpdateEnabled();

  public override void OnPickup(Player player);

  public void Initialize(List<string> layers);

  public void LayerTick();
}
