// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.UserAndCalories
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
public class UserAndCalories : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  [Eco.Shared.Networking.Eco(true)]
  public User User { get; set; }

  [Serialized]
  public float Calories { get; set; }

  [SyncToView(null, true)]
  public float CaloriePercent { get; set; }

  [SyncToView(null, true)]
  public float EducationPercent { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
