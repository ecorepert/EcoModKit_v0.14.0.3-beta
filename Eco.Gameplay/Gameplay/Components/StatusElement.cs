// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.StatusElement
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.View;
using PropertyChanged;

#nullable disable
namespace Eco.Gameplay.Components;

[AddINotifyPropertyChangedInterface]
public class StatusElement : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public LocString Message { get; set; }

  /// <summary>True while this element reports something that stops the object doing its work. Deliberately not implied by the failed icon: plenty
  /// of elements show a cross for a reading the object runs perfectly well with (stored pollution, an unassigned jurisdiction, an unlinked fuse).</summary>
  public bool Blocking { get; }

  /// <summary> Status component uses this value to order entries. The lower the value, the sooner this element appears in the list. </summary>
  public int Priority { get; set; }

  internal StatusComponent Owner { get; set; }

  public void SetStatusMessage(bool isEnabled, LocString enabledMessage, LocString disabledMessage);

  public void SetStatusMessage(bool isEnabled, LocString message);

  /// <summary>Reports a condition that halts the object, on top of showing the failed icon. This is what turns its on/off light from running to
  /// blocked, so use it only where the object really has stopped — not for a warning it keeps working through.</summary>
  public void SetBlockedStatus(LocString message);

  public static string GetEnabledIcon(bool enabled);

  public ref int ControllerID { get; }

  public void Clear();
}
