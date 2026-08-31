// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Attachment
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.ComponentModel;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
public class Attachment : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [Serialized]
  public Guid ID { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string Name { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public Eco.Shared.Math.Quaternion Rotation { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public Vector3 LocalPos { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string Title { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public Color Tint { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public Direction Direction { get; set; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  public Attachment(string title, Ray localRay);

  public Attachment(string title, Ray localRay, Color tint);
}
