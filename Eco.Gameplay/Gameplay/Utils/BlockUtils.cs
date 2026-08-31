// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.BlockUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.World.Blocks;
using System;

#nullable disable
namespace Eco.Gameplay.Utils;

public static class BlockUtils
{
  /// <summary> Tries to convert object into an item. </summary>
  public static Item GetItem(this Block target);

  /// <summary> Returns text for Look At tooltip for specified <paramref name="blockType" />. The tooltip appear on the client when player is looking on a block. </summary>
  public static LocString? GetLookAtTooltip(Type blockType);

  /// <summary> Returns most suitable <see cref="T:Eco.Gameplay.Items.Item" /> for <see cref="T:Eco.World.Blocks.BlockType" /> to be displayed in Look At tooltip. </summary>
  public static Item GetBlockTooltipItem(Type blockType);
}
