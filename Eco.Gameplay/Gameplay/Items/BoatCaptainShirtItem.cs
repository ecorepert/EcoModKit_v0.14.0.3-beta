// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.BoatCaptainShirtItem
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
[LocDisplayName("Boat Captain Shirt")]
[LocDescription("A comfy yet stylish shirt to commemorate the launch of the boat update.")]
[TwitchDrop("7f792325-b5f6-4f71-8da3-60eff809dc48")]
public class BoatCaptainShirtItem : ClothingItem
{
  public override string Slot { get; }

  public override bool Starter { get; }
}
