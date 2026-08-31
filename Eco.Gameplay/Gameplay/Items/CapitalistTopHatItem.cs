// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.CapitalistTopHatItem
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
[LocDisplayName("Capitalist Top Hat")]
[LocDescription("A symbol of wealth and status, this lavish top hat is the crown jewel of the capitalist elite. Adorned with the finest furs and gleaming with gold, it’s not just a hat—it’s a statement. Wear it to showcase your prowess in the free market and your unwavering commitment to the pursuit of profit!")]
[TwitchDrop("bbadbda6-59c8-11ef-8153-0a58a9feac02")]
public class CapitalistTopHatItem : ClothingItem
{
  public override LocString DisplayNamePlural { get; }

  public override string Slot { get; }

  public override bool Starter { get; }
}
