// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.UI.WorldMarker.GroupMarkerPart
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;

#nullable enable
namespace Eco.Gameplay.UI.WorldMarker;

[Serialized]
public class GroupMarkerPart
{
  [Serialized]
  public string? Category;
  [Serialized]
  public ThreadSafeList<IStack> Items;
  [Serialized]
  public string? Text;
  [Serialized]
  public int WorldMarkerReference;
  [Serialized]
  public Vector3i Pos;
  [Serialized]
  public Guid Id;
}
