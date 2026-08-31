// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.StartElection
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics.Titles;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Civics")]
[LocDescription("A citizen started an election.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements that the Citizen is a part of, as well as the settlement (and its parents) hosting the election.")]
public class StartElection : ElectionAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("If it's an election for a title, this is the title.")]
  [CanAutoAssign]
  public ElectedTitle ElectedTitle { get; set; }
}
