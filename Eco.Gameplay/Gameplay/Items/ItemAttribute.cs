// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ItemAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public abstract class ItemAttribute : Attribute
{
  public static void BuildCache(IEnumerable<Item> allItems);

  public static bool Has<T>(Type itemType) where T : ItemAttribute;

  public static bool Has(Type itemType, Type attributeType);

  /// <summary> Tries to get item attribute of requested type. </summary>
  public static bool TryGet<T>(Type itemType, out T attr) where T : ItemAttribute;

  public static T Get<T>(Type itemType) where T : ItemAttribute;
}
