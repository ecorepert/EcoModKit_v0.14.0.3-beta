// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.Internal.StorageComponentUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Gameplay.Components.Storage.Internal;

public static class StorageComponentUtils
{
  /// <summary>Put selected thing in given inventory.</summary>
  public static void Put(
    Player player,
    Inventory inventory,
    InteractionTarget target,
    InteractionModifier modifier = InteractionModifier.None,
    bool allSame = false);
}
