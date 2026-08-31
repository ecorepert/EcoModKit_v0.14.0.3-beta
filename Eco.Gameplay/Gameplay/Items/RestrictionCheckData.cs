// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.RestrictionCheckData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;

#nullable disable
namespace Eco.Gameplay.Items;

public struct RestrictionCheckData
{
  public User User;
  public Inventory Source;
  public Inventory Target;
  public InventoryAccessType InventoryAccessType;

  public static RestrictionCheckData New(
    Inventory source,
    User user,
    Inventory target = null,
    InventoryChangeSet changeSet = null);

  public static RestrictionCheckData FromChangeSet(InventoryChangeSet changeSet, Inventory target);
}
