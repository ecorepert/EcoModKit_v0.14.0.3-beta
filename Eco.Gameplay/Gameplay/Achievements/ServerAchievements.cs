// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Achievements.ServerAchievements
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Achievements;

/// <summary>Tracks scores and achievements for servers as a whole</summary>
[Serialized]
public class ServerAchievements : IController, IViewController, IHasUniversalID
{
  [Serialized]
  [ForceSerializeFullObject]
  public ThreadSafeDictionary<string, AchievementInstance> Achievements { get; set; }

  public void Initialize();

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
