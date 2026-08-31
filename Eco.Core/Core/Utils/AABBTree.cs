// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.AABBTree
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Core.Utils;

public class AABBTree
{
  public bool IntersectsAny(AABB aabb);

  public IEnumerable<object> GetObjects(AABB aabb);

  public IEnumerable<object> GetObjects(Sphere sphere);

  public virtual object GetObject(Vector3 pos);

  public bool Add(AABB aabb, object obj);

  public bool Remove(Vector3 position);

  public bool Remove(Vector3 position, object obj);

  public bool Remove(AABB aabb);

  public void Clear();
}
