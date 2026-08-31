// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Wires.SelectionComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Objects;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Wires;

public abstract class SelectionComponent : WorldObjectComponent
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public abstract string[] Options { get; }

  [Serialized]
  [SyncToView(null, true)]
  public int OptionsSelection { get; set; }

  protected string SelectionEntry { get; }

  [RPC]
  public void SetOptions(int index);

  public virtual void OnSelectionChanged();
}
