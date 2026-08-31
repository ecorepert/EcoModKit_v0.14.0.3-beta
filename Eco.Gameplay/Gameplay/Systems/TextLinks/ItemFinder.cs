// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.ItemFinder
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

internal class ItemFinder : IObjectFinder
{
  public void Initialize();

  public IEnumerable<LinkData> FindObjects(string text);

  private class ItemData
  {
    public Item Item;
    public bool IsSingular;
    public bool IsPlural;

    public bool IsSingularOnly { get; }

    public bool IsPluralOnly { get; }

    public LocString UILink();
  }
}
