// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.LiquidComponents.LiquidProducerComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Wires;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Pipes.LiquidComponents;

[Serialized]
[AutogenClass]
[LocDisplayName("Pipes")]
[NoIcon]
[LocDescription("View the input and output pipes to this object.")]
[Ecopedia(null, "Pipe Component", false, true, null)]
[RequireComponent(typeof (AttachmentComponent), null)]
[MustBeGridAligned]
public class LiquidProducerComponent : 
  WorldObjectComponent,
  IController,
  IViewController,
  IHasUniversalID,
  IWireContainer,
  IPolluter,
  IOperatingWorldObjectComponent
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public override 
  #nullable disable
  string IconName { get; }

  public LocString LiquidName { get; }

  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("PipeOutput")]
  public WireOutput OutputPipe { get; }

  public float DisplayedYield { get; set; }

  public IEnumerable<WireConnection> Wires { get; }

  public void Setup(Type producesType, float productionRate, BlockOccupancyType blockOccupancyType);

  public void UpdateProducedItem(Type producesType, float productionRate);

  public void UpdateOutputDisplay(Type displayedType);

  public override void OnAfterObjectMoved();

  public override void Destroy();

  public bool Operating { get; }

  public override void Tick();

  public override void LateTick();

  public float GetPollutionTonsPerHour();

  ref int IHasUniversalID.ControllerID { get; }
}
