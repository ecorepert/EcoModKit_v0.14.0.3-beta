// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Culture.Components.RateCultureComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Gameplay.Culture.Components;

/// <summary>
/// A component that allows associating culture to the property its placed on.
/// </summary>
[LocDisplayName("Cultural Plaque")]
[Serialized]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[NoIcon]
public class RateCultureComponent : WorldObjectComponent, IHasEnvVars
{
  [Interaction(InteractionTrigger.RightClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.None, (InteractionFlags) 0, null, false, new string[] {})]
  public void RateArchitecture(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);
}
