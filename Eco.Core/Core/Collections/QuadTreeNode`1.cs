// Decompiled with JetBrains decompiler
// Type: Eco.Core.Collections.QuadTreeNode`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Math;
using Eco.Shared.Networking;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Collections;

public class QuadTreeNode<T> where T : IPositionAndBounds
{
  public Rect Bounds { get; }

  public bool IsEmpty { get; }

  public QuadTreeNode(Rect bounds);

  public void Query(Rect queryArea, List<T> results, bool rootNode = false);

  public QuadTreeNode<T> Insert(T item);

  public void Remove(T item);
}
