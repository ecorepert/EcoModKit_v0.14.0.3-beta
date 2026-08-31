// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SharkJawsItem
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
[LocDisplayName("Shark Jaws")]
[LocDescription("A mounted jaw from a mighty catch!")]
[System.ComponentModel.Category("Hidden")]
[Tag("NotInBrowser")]
[TwitchDrop("5a275279-f267-4f0f-81ff-377bf67ff360")]
public class SharkJawsItem : WorldObjectItem<SharkJawsObject>
{
  protected override OccupancyContext GetOccupancyContext { get; }
}
