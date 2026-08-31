// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.DetonatorBaseItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Gameplay.Items;

public abstract class DetonatorBaseItem : ToolItem
{
  public override ItemHandOrigin HandOrigin { get; }

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, Flags = InteractionFlags.NoTargetRequired)]
  public void DetonateLinksInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);
}
