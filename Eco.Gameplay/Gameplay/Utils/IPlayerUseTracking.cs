// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.IPlayerUseTracking
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using System;

#nullable disable
namespace Eco.Gameplay.Utils;

/// <summary>Interface for things that get callbacks *and* track the using players (world objects).</summary>
public interface IPlayerUseTracking
{
  ThreadSafeList<WeakReference> UsingPlayers { get; set; }

  void OnUsingPlayersChange();
}
