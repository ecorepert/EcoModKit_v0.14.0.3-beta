// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.Level
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Players;

[Serialized]
public class Level : IController, IViewController, IHasUniversalID
{
  public Level();

  public Level(string name, float value, float capacity, string unit);

  public ref int ControllerID { get; }

  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public string Unit { get; set; }

  [SyncToView(null, true)]
  public float Value { get; set; }

  [SyncToView(null, true)]
  public float Capacity { get; set; }

  public float Percent { get; }
}
