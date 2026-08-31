// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.ThreadSafeNetObjectViewerCollection
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using ConcurrentCollections;
using Eco.Shared.Networking;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Eco.Plugins.Networking;

public class ThreadSafeNetObjectViewerCollection : 
  ConcurrentHashSet<INetObjectViewer>,
  INetObjectViewerCollection,
  IEnumerable<INetObjectViewer>,
  IEnumerable
{
  public bool Remove(INetObjectViewer viewer);

  bool INetObjectViewerCollection.Add(INetObjectViewer viewer);
}
