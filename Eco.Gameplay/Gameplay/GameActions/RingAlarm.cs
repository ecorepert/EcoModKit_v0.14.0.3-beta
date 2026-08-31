// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.RingAlarm
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Stats;

#nullable disable
namespace Eco.Gameplay.GameActions;

[NoStats]
[DontTest]
[LocCategory("Interaction")]
[LocDescription("An alarm or bell was used.")]
[ChangeParentConfigLoc("WorldObjectItem", null, null, null, true)]
public class RingAlarm : WorldObjectInteractAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Is the alarm being broadcast?")]
  public bool Ringing { get; set; }
}
