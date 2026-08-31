// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SewageItem
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
[LocDisplayName("Sewage")]
[LocDescription("Sewage is a byproduct that is often created when using water for industrial purposes. It is a source of ground pollution.")]
[System.ComponentModel.Category("Hidden")]
[StartsDiscovered]
[Tag("Liquid")]
[Ecopedia("Blocks", "Byproducts", true, true, null)]
public class SewageItem : BlockItem<SewageBlock>, ICanExitFromPipe
{
  public const float SewagePollutionPerHourAtUnitFlow = 0.5f;

  public override LocString DisplayNamePlural { get; }

  public override bool CanStickToWalls { get; }

  public LocString FlowTooltip(float flowrate);

  public float OnPipeExit(WireOutput wire, Ray posDir, PipePayload payload);

  public void OnDiscarded(Vector3i pos, float amount);
}
