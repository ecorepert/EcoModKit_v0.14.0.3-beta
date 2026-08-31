// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.WorldObjectManyBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Serializers;
using Eco.Core.Utils;
using Eco.Shared.Serialization;
using Eco.World.Blocks;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Objects;

[Serialized]
[Transient]
[Occupied]
[SerializedWith(typeof (ClassSerializer<>), null)]
public class WorldObjectManyBlock : Block
{
  [Serialized]
  public 
  #nullable disable
  ThreadSafeList<WorldObjectHandle> WorldObjectHandles { get; }

  public WorldObjectManyBlock(WorldObject obj);

  public WorldObjectManyBlock(Guid[] objs);

  public IEnumerable<WorldObject> Objects { get; }

  public void AddUnique(WorldObject obj);

  public void Remove(WorldObject obj);

  protected WorldObjectManyBlock();
}
