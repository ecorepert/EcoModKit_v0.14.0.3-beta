// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ElevatorCallPostComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[Tag("ElevatorCallPost")]
[NoIcon]
public class ElevatorCallPostComponent : WorldObjectComponent, INotifyPropertyChanged
{
  public static int LinkDistance2D;
  public static int DefaultElevatorSerchRadius;

  [SyncToView(null, true)]
  public 
  #nullable disable
  ElevatorComponent LinkedElevator { get; }

  [SyncToView(null, true)]
  public Vector3i ElevatorLinkPosition { get; set; }

  public override void Initialize();

  [Interaction(InteractionTrigger.InteractKey, "Up", InteractionModifier.None, new string[] {"Up"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  public void MoveUp(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [Interaction(InteractionTrigger.InteractKey, "Down", InteractionModifier.None, new string[] {"Down"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  public void MoveDown(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [Interaction(InteractionTrigger.InteractKey, "Stop", InteractionModifier.None, new string[] {"Stop"}, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, MinCaloriesRequired = 0.0f)]
  public void Stop(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  public void CallElevator(Player player, InteractionTarget target, ElevatorComponent.State state);

  public void FindLinkedElevator();

  public void FindLinkedElevator(int searchSize);

  public override void Destroy();
}
