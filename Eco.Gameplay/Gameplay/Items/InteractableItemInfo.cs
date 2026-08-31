// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InteractableItemInfo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Interactable information about interactable item passed to client.</summary>
public class InteractableItemInfo : ItemInfo
{
  /// <summary> For IInteractingItem, the distance that it can be interacted with. </summary>
  [SyncToView(null, true)]
  public float InteractDistance { get; set; }

  /// <summary> For IInteractingItems, the block IDs that will get highlighted. </summary>
  [SyncToView(null, true)]
  public HashSet<ushort> HighlightBlockIDs { get; set; }

  [SyncToView(null, true)]
  public ushort[] PlaceBlockIDs { get; set; }
}
