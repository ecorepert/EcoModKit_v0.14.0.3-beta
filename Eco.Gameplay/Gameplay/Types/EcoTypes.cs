// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Types.EcoTypes
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Types;

/// <summary>Provides data about all the different kinds of things available through the eco codebase: Items, Blocks, and NetObjects.
/// Todo: migrate ItemInfo and BlockInfo into here.</summary>
public class EcoTypes : Singleton<EcoTypes>, IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public Dictionary<string, NetObjectInfo> NetObjectTypeNameToInfo { get; }

  [SyncToView(null, true)]
  public Dictionary<string, BlockInfo> BlockNameToInfo { get; }

  [SyncToView(null, true)]
  public Dictionary<Type, ItemInfo> ItemTypeToInfo { get; }

  [SyncToView(null, true)]
  public Dictionary<Type, WorldObjectInfo> WorldObjectTypeToInfo { get; }

  public WorldObjectInfo GetWorldObjectInfo(Type type);

  public void Initialize();

  public ref int ControllerID { get; }
}
