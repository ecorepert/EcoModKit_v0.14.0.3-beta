// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.TrashInventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Items;

[Serialized]
public class TrashInventory : LimitedInventory
{
  public 
  #nullable disable
  ItemStack FirstStack { get; }

  protected TrashInventory();

  public TrashInventory(int numStacks);

  protected override void Initialize();

  public Task TryDropItem(User user);

  public Task<Result> DropItemToWaste(User user);
}
