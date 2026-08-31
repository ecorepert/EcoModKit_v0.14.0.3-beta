// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.StatusComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[LocDescription("Examine status effects and room requirements for this object.")]
[Priority(-2147483647 /*0x80000001*/)]
[HasIcon(null)]
[Ecopedia(null, null, false, true, null)]
public class StatusComponent : WorldObjectComponent
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public ControllerList<StatusElement> Statuses { get; }

  /// <summary>False as soon as an element reports a blocking condition. An object that is on but blocked must not read as running on its on/off
  /// light, and the object's own Enabled flag can't say so: components gate their tick on it, so reporting their own blockage there would
  /// deadlock them. Only <see cref="M:Eco.Gameplay.Components.StatusElement.SetBlockedStatus(Eco.Shared.Localization.LocString)" /> moves this — a failed icon on its own is often just a reading.</summary>
  [SyncToView(null, true)]
  public bool AllOk { get; }

  internal void RefreshAllOk();

  /// <summary>Creates a status element, with lower values of priority appearing first.</summary>
  public StatusElement CreateStatusElement(int priority = 0);

  /// <summary>Removes a status element that was previously added..</summary>
  public void RemoveStatusElement(StatusElement element);
}
