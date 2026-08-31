// Decompiled with JetBrains decompiler
// Type: Eco.Stats.ShortNameMap
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Stats;

public sealed class ShortNameMap : IDisposable
{
  public event Action<ShortNameEntry>? OnAdded;

  public IEnumerable<ShortNameEntry> All { get; }

  public string GetOrAddShortName(string longName);

  public void Init(IEnumerable<ShortNameEntry> collection);

  public void Dispose();
}
