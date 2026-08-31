// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ClothingItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
[ItemGroup("Avatar Part")]
[Eco.Gameplay.Items.MaxStackSize(1)]
public abstract class ClothingItem : Item
{
  public virtual Dictionary<UserStatType, float> GetFlatStats();

  [SyncToView(null, true)]
  public virtual string Slot { get; }

  public virtual bool Starter { get; }

  public override string OnUsed(Player player, ItemStack itemStack);
}
