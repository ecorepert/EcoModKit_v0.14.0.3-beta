// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.RecyclingComponentData
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

/// <summary>Persistent data for the recycling component.</summary>
[Serialized]
public class RecyclingComponentData : IClearRequestHandler
{
  [Serialized]
  public GroupAccumulator MixedGarbageAccumulator { get; set; }

  [Serialized]
  [ThreadSafe]
  public Dictionary<Type, int> CurrentBuffer { get; set; }

  [Serialized]
  public int CurrentInputItemTypeID { get; set; }

  [Serialized]
  public int CurrentBufferInitialMils { get; set; }

  public bool HasDataThatCanBeCleared { get; }

  public Result TryHandleClearRequest(Player player);
}
