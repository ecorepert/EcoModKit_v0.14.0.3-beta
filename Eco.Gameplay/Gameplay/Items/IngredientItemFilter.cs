// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.IngredientItemFilter
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

[Serialized]
public class IngredientItemFilter
{
  [Serialized]
  public string TagName { get; set; }

  [Serialized]
  public ThreadSafeHashSet<string> AllowedItemTypeNames { get; set; }

  public IngredientItemFilter();

  public IngredientItemFilter(string tagName, IEnumerable<string> allowedItemTypeNames);
}
