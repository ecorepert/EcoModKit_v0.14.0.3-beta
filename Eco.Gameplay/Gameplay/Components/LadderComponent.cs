// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.LadderComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Interactable ladder, teleports player to relative localtion inside world object</summary>
/// 
///             Instead of directly adding logic to WorldObject component spliting to this component and add it where necessary
[Serialized]
[NoIcon]
public class LadderComponent : WorldObjectComponent
{
  [Interaction(InteractionTrigger.InteractKey, null, InteractionModifier.None, new string[] {"isLadder"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.None, (InteractionFlags) 0, null, false, new string[] {})]
  public void Climb(Player player, InteractionTriggerInfo trigger, InteractionTarget target);
}
