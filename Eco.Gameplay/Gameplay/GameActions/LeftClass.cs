// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.LeftClass
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Civics;
using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Education")]
[LocDescription("A student left or was removed from a class.")]
[RelatedFeature("EducationEnabled", true)]
[CannotBePrevented]
public class LeftClass : LeaveClassBase
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Describes why the student left the class.")]
  public StoppedStudying CompletionReason { get; set; }
}
