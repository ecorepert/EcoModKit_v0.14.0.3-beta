// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blueprints.Blueprint
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Blueprints;

/// <summary>Contains persistent data for <see cref="T:Eco.Gameplay.Blueprints.BlueprintItem" />. Inherited by World Object's <see cref="T:Eco.Gameplay.Blueprints.BlueprintComponent" /> when <see cref="T:Eco.Gameplay.Blueprints.FoundationStoneObject" /> created from item.</summary>
[Serialized]
public class Blueprint : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  [Serialized]
  [SyncToView(null, true)]
  public string? Name { get; set; }

  [SyncToView(SyncFlags.MustRequest)]
  public BlockLayout? Layout { get; set; }

  public event PropertyChangedEventHandler? PropertyChanged;

  public ref int ControllerID { get; }
}
