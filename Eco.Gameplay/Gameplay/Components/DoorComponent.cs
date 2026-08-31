// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.DoorComponent
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

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary> Component containing necessary logic for doors. Enables the Open/Close interactions. </summary>
[Serialized]
[NoIcon]
public class DoorComponent : WorldObjectComponent, IHasEnvVars
{
  [Serialized]
  [Notify]
  [EnvVar]
  public bool IsOpen { get; }

  [Serialized]
  public bool OpensOutwards { get; }

  [Interaction(InteractionTrigger.RightClick, "Open", InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f, DisallowedEnvVars = new string[] {"IsOpen"}, AuthRequired = AccessType.ConsumerAccess)]
  [Interaction(InteractionTrigger.RightClick, "Close", InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f, RequiredEnvVars = new string[] {"IsOpen"}, AuthRequired = AccessType.ConsumerAccess)]
  public void Toggle(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  public override void OnCreate();

  public void SetOpen(User user, bool open);

  public void ForceSetOpen(bool open);
}
