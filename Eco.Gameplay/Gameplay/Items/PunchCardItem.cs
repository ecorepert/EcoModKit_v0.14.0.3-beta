// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.PunchCardItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
[NotSpawnable]
[LocDisplayName("Punch Card Time Clock")]
[LocDescription("Clock in for the late shift")]
[System.ComponentModel.Category("Hidden")]
[Tag("NotInBrowser")]
[TwitchDrop("976696b1-ef2a-418d-8f42-7b5655141338")]
public class PunchCardItem : WorldObjectItem<PunchCardObject>
{
  protected override OccupancyContext GetOccupancyContext { get; }
}
