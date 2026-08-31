// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.Gases.GasItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Rooms;
using Eco.Gameplay.Wires;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Pipes.Gases;

[Serialized]
[Liquid]
[System.ComponentModel.Category("Hidden")]
[Tag("NotInBrowser")]
public abstract class GasItem : Item, ICanExitFromPipe
{
  public abstract float ApplyAtmosphere(Atmosphere a, float amount);

  public abstract float GetInAtmosphere(Atmosphere a);

  public virtual LocString FlowTooltip(float flowrate);

  public float OnPipeExit(WireOutput wire, Ray posDir, PipePayload payload);
}
