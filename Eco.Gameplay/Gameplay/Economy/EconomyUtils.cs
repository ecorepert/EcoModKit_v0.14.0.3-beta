// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.EconomyUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Components.Store;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Math;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Economy;

public static class EconomyUtils
{
  public static string GetRandomCurrencyName(string userName);

  public static Task<Task> SpawnEconomy(
    Player player,
    int ordersPerStore = 20,
    int categoriesPerStore = 4,
    int stores = 5);

  /// <summary>Spawns [store, stockpile, chest], links them and fills with tools.</summary>
  public static Task<StoreComponent> SpawnToolsStore(User mainUser, User otherUser, Vector3i pos);

  /// <summary>Spawns [store, stockpile, chest], links them and fills with carriedItems.</summary>
  public static Task<StoreComponent> SpawnCarriedStore(User mainUser, User otherUser, Vector3i pos);

  /// <summary>Spawns [store, stockpile, chest], links them and fills with some random items.</summary>
  public static Task<(StoreComponent Store, StorageComponent Chest, StorageComponent Stockpile)> SpawnStoreAndFillAndClaim(
    User mainUser,
    User otherUser,
    Vector3i pos,
    Deed? deed,
    int offersPerStore = 0,
    int categoriesPerStore = 0,
    float? fixedPrice = null);

  public static (float SubTotal, float Tax) SubtotalAndTax(float total, float taxRate);
}
