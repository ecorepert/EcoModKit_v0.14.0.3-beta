// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.SortingComponentData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Persistent data for the sorting component. Survives pickup/putdown via IPersistentData.</summary>
[Serialized]
public class SortingComponentData : IClearRequestHandler
{
  [Serialized]
  public GroupAccumulator[] Accumulators { get; set; }

  [Serialized]
  public CatalystState[] CatalystStates { get; set; }

  [Serialized]
  public string[] TargetNames { get; set; }

  [Serialized]
  [ThreadSafe]
  public Dictionary<Type, int> CurrentRepartition { get; set; }

  public bool HasDataThatCanBeCleared { get; }

  public Result TryHandleClearRequest(Player player);
}
