// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserHelpers.UserEvents
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Math;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Gameplay.Players.UserHelpers;

/// <summary>Various events for when users are doing stuff, used by achievements and other things.</summary>
public static class UserEvents
{
  public static ThreadSafeAction<User, Vector3i, Block> BlockMinedEvent;
}
