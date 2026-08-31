// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SocialistShirtItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
[System.ComponentModel.Category("Hidden")]
[NotSpawnable]
[LocDisplayName("Socialist Shirt")]
[LocDescription("Embrace the power of the people with this bold t-shirt. Crafted for the champions of equality, this shirt is a rallying cry for collective action. Wear it to stand united with your comrades in the fight for a fairer world!")]
[TwitchDrop("b96316e5-5994-11ef-a5f2-0a58a9feac02")]
public class SocialistShirtItem : ClothingItem
{
  public override LocString DisplayNamePlural { get; }

  public override string Slot { get; }

  public override bool Starter { get; }
}
