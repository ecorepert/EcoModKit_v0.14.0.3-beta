// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Occupancy.OccupancyContextUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.SharedTypes;
using System;

#nullable disable
namespace Eco.Gameplay.Occupancy;

/// <summary> Contains functionality that allows us to operate on OccupancyContexts and make a versions of them readable by the client. </summary>
public static class OccupancyContextUtils
{
  /// <summary> Gathers the placement requirements for objects of specified type and packs them into a struct that's shareable to the client. </summary>
  /// <remarks> That struct is used by the client to pre-emptively validate or invalidate the placement, and display useful info without querying the server.</remarks>
  public static WorldObjectPlacementRequirements GetPlacementRequirements(Type worldObjectType);
}
