// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Types.WorldObjectInfo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Types;

/// <summary>Stores type data about a <see cref="T:Eco.Gameplay.Objects.WorldObject" /> that gets shared with the client.</summary>
public class WorldObjectInfo : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public bool Hideable { get; set; }

  [SyncToView(null, true)]
  [ThreadSafe]
  public List<Type> RequiredComponents { get; set; }

  [SyncToView(null, true)]
  public WorldObjectPlacementRequirements PlacementRequirements { get; set; }

  public WorldObjectInfo(Type woType);

  public ref int ControllerID { get; }
}
