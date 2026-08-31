// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.Internal.UserSubTaskCarvePath
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Simulation.Agents;

#nullable disable
namespace Eco.Gameplay.Tutorial.Internal;

/// <summary> Task for following player's progress towards carving path around (as example, learning machete) </summary>
public class UserSubTaskCarvePath : UserSubTaskSubscribe<Plant, object, bool>
{
  public string ItemName;
  public int TargetCount;

  protected override ThreadSafeAction<Plant, object, bool> Subscription { get; }

  /// <summary> Decrement plants count until zero and pass when selected required tool </summary>
  protected override bool IsComplete(Plant plant, object killer, bool destroyed);
}
