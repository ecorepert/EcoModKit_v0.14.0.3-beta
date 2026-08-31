// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.Gases.SmogItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Wires;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Pipes.Gases;

[Serialized]
[Liquid]
[LocDisplayName("Smog")]
[System.ComponentModel.Category("Hidden")]
[LocDescription("A smoke that contains a combination of pollutants.")]
public class SmogItem : Item, ICanExitFromPipe
{
  public const float PollutionTonsPerSmogItem = 0.001f;

  public override LocString DisplayNamePlural { get; }

  public float OnPipeExit(WireOutput wire, Ray posDir, PipePayload payload);

  public LocString FlowTooltip(float flowrate);
}
