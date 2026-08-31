// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.UI.WorldMarker.WorldMarkerVisibility
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.UI.WorldMarker;

/// <summary> Controls the visibility of the world marker in the minimap and the world. </summary>
[Serialized]
[Flags]
public enum WorldMarkerVisibility
{
  ShowInTheWorldAndMinimap = 0,
  ShowInTheWorld = 1,
}
