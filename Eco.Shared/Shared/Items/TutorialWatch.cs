// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.TutorialWatch
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Items;

/// <summary> Shared with the client to indicate when an RPCs (tutorial related) is needed </summary>
[Flags]
public enum TutorialWatch
{
  OnJump = 0,
  OnTooltipOpened = 1,
  OnTooltipClosed = 2,
  OnMeteorSpotted = OnTooltipClosed | OnTooltipOpened, // 0x00000003
  OnCameraViewChanged = 4,
  OnCameraZoomEnabled = OnCameraViewChanged | OnTooltipOpened, // 0x00000005
  OnObservationEnabled = OnCameraViewChanged | OnTooltipClosed, // 0x00000006
  OnFovZoomEnabled = OnObservationEnabled | OnTooltipOpened, // 0x00000007
  OnDoneSwimming = 8,
  OnTabToggleMouse = OnDoneSwimming | OnTooltipOpened, // 0x00000009
}
