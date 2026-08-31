// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Objects.UniqueSettlementCivicItem`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using System;
using System.Numerics;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Civics.Objects;

public abstract class UniqueSettlementCivicItem<T> : WorldObjectItem<T> where T : WorldObject
{
  public virtual Type CivicObjectType { get; }

  public override Task<bool> CanPlaceObject(Player player, Vector3 worldPos, Eco.Shared.Math.Quaternion rotation);
}
