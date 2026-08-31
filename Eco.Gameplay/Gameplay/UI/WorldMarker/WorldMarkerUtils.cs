// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.UI.WorldMarker.WorldMarkerUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Math;
using System;

#nullable disable
namespace Eco.Gameplay.UI.WorldMarker;

public static class WorldMarkerUtils
{
  public static void TickMarkers();

  public static Eco.Gameplay.UI.WorldMarker.WorldMarker DebugTrackPos(
    Func<Vector3i> getPos,
    string text);

  public static void StopTracking(Eco.Gameplay.UI.WorldMarker.WorldMarker marker);

  /// <summary> Removes a marker from the user's list and adds it to the global list. </summary>
  public static void MakeMarkerGlobal(User user, Eco.Gameplay.UI.WorldMarker.WorldMarker marker);

  /// <summary> Removes a marker from the global list and adds it to the user's list. </summary>
  public static void MakeMarkerPersonal(User user, Eco.Gameplay.UI.WorldMarker.WorldMarker marker);
}
