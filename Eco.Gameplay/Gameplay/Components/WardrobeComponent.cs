// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.WardrobeComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary> Component that adds wardrobe in a storage panel, allows ability to swap clothing using interaction </summary>
[Serialized]
[Priority(-100)]
[Tag("Wardrobe")]
[HasIcon(null)]
public class WardrobeComponent : WorldObjectComponent
{
  [Interaction(InteractionTrigger.RightClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {})]
  public void EditAppearance(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);
}
