// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SombreroItem
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
[LocDisplayName("Sombrero")]
[LocDescription("A traditional Sombrero.")]
[TwitchDrop("ce3e52e2-9136-4ada-af27-46c11428e94b")]
public class SombreroItem : ClothingItem
{
  public override LocString DisplayNamePlural { get; }

  public override string Slot { get; }

  public override bool Starter { get; }
}
