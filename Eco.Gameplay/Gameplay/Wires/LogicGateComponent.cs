// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Wires.LogicGateComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Shared.Serialization;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Wires;

[Serialized]
[Category("Hidden")]
[NoIcon]
public class LogicGateComponent : SelectionComponent, IWireContainer
{
  [Serialized]
  public bool On;
  [Serialized]
  public bool[] Signals;

  public override string[] Options { get; }

  public IEnumerable<WireConnection> Wires { get; }

  public override void Initialize();

  public override void Destroy();

  public override void OnSelectionChanged();
}
