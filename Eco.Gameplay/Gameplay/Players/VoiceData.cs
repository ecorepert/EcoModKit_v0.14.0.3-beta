// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.VoiceData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public class VoiceData : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }

  [Serialized]
  [SyncToView(null, true)]
  public Vector2 ClusterCenter { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public float ClusterRadius { get; set; }
}
