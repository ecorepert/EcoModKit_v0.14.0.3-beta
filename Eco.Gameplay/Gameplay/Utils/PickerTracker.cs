// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.PickerTracker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Utils;

[Serialized]
public class PickerTracker : PickerObject
{
  [Serialized]
  [DontClone]
  public ItemTracker Tracker { get; set; }

  [SyncToView(null, true)]
  public override string Contents { get; }

  public PickerTracker();

  public PickerTracker(
    InventoryActionType trackAction,
    string description = null,
    string offscreenText = null,
    bool autocontrolMarker = true);

  public void SetOriginalStacks(IEnumerable<IStack> stacks = null);

  public bool ShouldOverrideAuth(GameAction action);

  public Result Test();

  public bool ActionPerformed(GameAction action);

  public void AddRemainingItems(IEnumerable<ItemStack> items);

  protected override void UpdateMarks();

  public override void Accepted(string prepend, User user);

  public void UpdateMarker(User user, string prepend = "");
}
