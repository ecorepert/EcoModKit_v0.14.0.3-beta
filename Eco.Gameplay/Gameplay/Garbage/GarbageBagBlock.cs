// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.GarbageBagBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Gameplay.Garbage;

[Solid]
[Transient]
[LookAtTooltip("Garbage", IconName = "TrashItem")]
public abstract class GarbageBagBlock : GarbageInventoryBlock
{
  public const int DecayNum = 3;
  public const int StackedNum = 4;

  protected GarbageBagBlock();

  protected GarbageBagBlock(DecayingInventory inventory);

  /// <summary> Updates world with <see cref="T:Eco.Gameplay.Garbage.GarbageBagBlock" /> corresponding to <paramref name="inventory" /> and returns synced block. </summary>
  public static void UpdateByInventory(DecayingInventory inventory);
}
