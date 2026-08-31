// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.AABBStub
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils;

internal class AABBStub
{
  public WeakReference<AABBStub> Parent;
  public List<AABBStub> Children;

  public AABB Aabb { get; set; }

  public object Obj { get; set; }

  public AABBStub(AABB aabb, object obj);

  public AABBStub Left { get; }

  public AABBStub Right { get; }

  public bool IsLeaf { get; }

  public void Detach();

  public void UpdateAABB();

  public bool AddChildren(AABBStub stub);
}
