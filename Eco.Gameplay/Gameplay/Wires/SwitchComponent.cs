// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Wires.SwitchComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Components;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Gameplay.Wires;

[Serialized]
[NoIcon]
[Tag("Tech")]
public class SwitchComponent : WorldObjectComponent, ISwitchable, IEnabledIndicator
{
  [Serialized]
  public bool On { get; set; }

  public ThreadSafeAction<bool> OnChanged { get; set; }

  public WireOutput OutputWire { get; }

  Attachment IEnabledIndicator.IndicatorAttachment { get; set; }

  [Interaction(InteractionTrigger.RightClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void Switch(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  public override void Initialize();

  public override void Destroy();

  protected Result Switch(Player player);
}
