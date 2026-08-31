// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.StringMatchObjectFinder
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

internal abstract class StringMatchObjectFinder : IObjectFinder, IDisposable
{
  public void Initialize();

  public StringMatchObjectFinder(bool caseSensitive);

  public IEnumerable<LinkData> FindObjects(string text);

  protected abstract Dictionary<string, LocString> NamesToUILinks();

  public void Dispose();
}
