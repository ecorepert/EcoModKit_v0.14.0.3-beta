// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.ParticipateInDinnerParty
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Dinner Party")]
[LocDescription("A citizen participated in a dinner party.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the deed and the citizen's settlements.")]
[CannotBePrevented]
public class ParticipateInDinnerParty : DinnerPartyCitizenAction
{
}
