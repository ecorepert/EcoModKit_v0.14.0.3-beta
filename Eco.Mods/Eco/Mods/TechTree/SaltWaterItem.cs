// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SaltWaterItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Pipes;
using Eco.Gameplay.Wires;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[Liquid]
[LocDisplayName("Salt Water")]
[LocDescription("Salt water pumped from the ocean. Unfit for drinking or irrigation; requires desalination before reuse.")]
[System.ComponentModel.Category("Hidden")]
[Eco.Gameplay.Items.MaxStackSize(10)]
[StartsDiscovered]
[Tag("Liquid")]
[Ecopedia("Natural Resources", "Blocks", true, true, null)]
public class SaltWaterItem : BlockItem<SaltWaterBlock>, ICanExitFromPipe
{
  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }

  public LocString FlowTooltip(float flowrate);

  public float OnPipeExit(WireOutput wire, Ray posDir, PipePayload payload);
}
