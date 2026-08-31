// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Types.NetObjectInfo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Types;

/// <summary>Stores type data about a netobject that is shared with the client.</summary>
public class NetObjectInfo : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public Tag[] Tags { get; set; }

  [SyncToView(null, true)]
  public Type CreatingItem { get; set; }

  [SyncToView(null, true)]
  public Type ObjectType { get; set; }

  [SyncToView(null, true)]
  public string[] ParameterNames { get; set; }

  /// <summary>Return false if there's no data we need to store/sync to client.</summary>
  public bool HasData { get; }

  public ref int ControllerID { get; }
}
