// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ItemUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

public static class ItemUtils
{
  public static bool CanItemExistInInventories(this Item item);

  public static object GetRepresentativeObject(int typeID);

  public static object GetRepresentativeObject(ViewClassInfo classInfo);

  public static object GetRepresentativeObject(Type type);

  public static HashSet<Type> GetItemsByTag(params string[] tags);

  public static IEnumerable<Type> GetItemsByBlockAttribute<T>(this IEnumerable<BlockItem> blockItems) where T : Attribute;

  public static IEnumerable<Item> GetRandomItems(int amount);

  public static IEnumerable<Item> GetItemsByTwitchDropAttribute(this IEnumerable<Item> items);
}
