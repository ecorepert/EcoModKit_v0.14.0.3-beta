// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.BoatCaptainFlipFlopsItem
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
[LocDisplayName("Boat Captain Flip Flops")]
[LocDescription("Appropriate for all occasions.")]
[TwitchDrop("9c1e58e1-59ee-4679-8982-46de22d1227c")]
public class BoatCaptainFlipFlopsItem : ClothingItem
{
  public override LocString DisplayNamePlural { get; }

  public override string Slot { get; }

  public override bool Starter { get; }
}
