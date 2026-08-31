// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.StorageProfiles
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using System;

#nullable disable
namespace Eco.Gameplay.Components.Storage;

/// <summary>Storage summaries keyed by world object type.
/// Restrictions are attached to an inventory instance, but they are the same for every instance of a type, so each storage publishes its own once it finishes
/// initializing. That gives the item tooltip -- which has no instance to read from -- something to show for an object the player hasn't placed yet.</summary>
public static class StorageProfiles
{
  public static StorageProfile For(Type worldObjectType);

  /// <summary>First storage of a given world object type to come up wins; the rest describe themselves identically.
  /// Checked before reading the inventory so a world full of chests only summarizes one of them.</summary>
  public static void Publish(Type worldObjectType, Inventory inventory);
}
