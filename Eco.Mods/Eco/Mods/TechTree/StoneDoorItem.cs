// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.StoneDoorItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Stone Door")]
[LocDescription("A heavy stone door.")]
[Tier(2f, true)]
[System.ComponentModel.Category("Hidden")]
[Tag("NotInBrowser")]
public class StoneDoorItem : WorldObjectItem<StoneDoorObject>
{
  protected override OccupancyContext GetOccupancyContext { get; }
}
