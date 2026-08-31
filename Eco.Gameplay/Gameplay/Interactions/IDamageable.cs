// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Interactions.IDamageable
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Shared.Networking;
using Eco.Shared.SharedTypes;
using System;

#nullable disable
namespace Eco.Gameplay.Interactions;

public interface IDamageable
{
  GameActionPack TryApplyDamage(
    GameActionPack pack,
    INetObject damager,
    float amount,
    InteractionTarget target,
    Item tool,
    out float damageReceived,
    Type damageDealer = null,
    float experienceMultiplier = 1f);
}
