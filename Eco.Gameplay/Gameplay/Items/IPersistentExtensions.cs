// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.IPersistentExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Items;

public static class IPersistentExtensions
{
  /// <summary> Triggers clear request handler and adds the result message to the provided string builder. Returns handler's bool result. </summary>
  public static bool TryHandleClearAndComposeFeedback(
    this IClearRequestHandler handler,
    Player player,
    LocStringBuilder feedback);

  /// <summary>This will gather IPersistentData components from the object and store them into PersistentData as a ThreadSafeDictionary.</summary>
  public static void CollectWorldObjectPersistentData(
    this IPersistentData pdata,
    WorldObject placedObject);

  /// <summary>Takes the data from an item and inserts it into the worldobject being placed.</summary>
  public static void AssignWorldObjectPersistentData(
    this IPersistentData pdata,
    WorldObject placedObject);

  public static void ClearOnTrade(this IPersistentData pdata);
}
