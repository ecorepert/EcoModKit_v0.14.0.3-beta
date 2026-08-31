// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blueprints.BlueprintItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Blueprints;

/// <summary>Item which may be used for <see cref="T:Eco.Gameplay.Blueprints.FoundationStoneObject" /> creation, containing blueprint data.</summary>
[Serialized]
[System.ComponentModel.Category("Hidden")]
public class BlueprintItem : WorldObjectItem<FoundationStoneObject>, IPersistentData
{
  /// <summary>Part of item's persistent data which contains information about associated Blueprint (name and blocks info). This data will be inherited by <see cref="T:Eco.Gameplay.Blueprints.BlueprintComponent" /> when <see cref="T:Eco.Gameplay.Blueprints.FoundationStoneObject" /> created from the item.</summary>
  public Blueprint? Blueprint { get; set; }

  [Serialized]
  public ItemPersistentData? PersistentData { get; set; }

  object? IPersistentData.PersistentData { get; set; }
}
