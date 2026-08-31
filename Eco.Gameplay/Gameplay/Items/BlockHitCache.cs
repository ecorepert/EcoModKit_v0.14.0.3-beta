// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.BlockHitCache
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

public class BlockHitCache
{
  public const int HitMemoryCapacity = 16 /*0x10*/;

  public void ForgetHit(Vector3i pos);

  public float GetHit(Vector3i pos);

  public float MemorizeHit(Type blockType, Vector3i pos, float dmg);

  public float MemorizeHit(BlockHitCache.BlockHit blockHit);

  public class BlockHit
  {
    public Type BlockType;
    public float Damage;
    public Vector3i Position;
  }
}
