// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.HanamuraCapItem
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
[LocDisplayName("Hanamura Cap")]
[LocDescription("Such a memorable feast could’ve drifted away like autumn leaves. Thankfully this stylish reward keeps the story alive.")]
public class HanamuraCapItem : ClothingItem
{
  public override LocString DisplayNamePlural { get; }

  public override string Slot { get; }

  public override bool Starter { get; }
}
