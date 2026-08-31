// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ClockComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[NoIcon]
public class ClockComponent : WorldObjectComponent, IHasEnvVars
{
  [Serialized]
  [Notify]
  [EnvVar]
  public bool IsRinging { get; }

  [Interaction(InteractionTrigger.RightClick, "Ring Bell", InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 75f, DisallowedEnvVars = new string[] {"IsRinging"}, AuthRequired = AccessType.ConsumerAccess)]
  public void Trigger(
  #nullable disable
  Player player, InteractionTriggerInfo trigger, InteractionTarget target);
}
