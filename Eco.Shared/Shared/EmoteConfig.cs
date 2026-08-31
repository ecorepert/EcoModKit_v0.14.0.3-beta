// Decompiled with JetBrains decompiler
// Type: Eco.Shared.EmoteConfig
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared;

public class EmoteConfig
{
  /// <summary> Layer emote will be played in </summary>
  public EmoteLayer Layer;
  /// <summary> Emote clip definition type (single, or triple with in and out) </summary>
  public EmoteType Type;
  /// <summary> Custom override duration, -1 means duration will be default (as anim clip has) </summary>
  public float Duration;
  /// <summary> If player can move while in this emote (useful when its not full body, so legs can blend) </summary>
  public bool AllowPlayDuringMovement;
  /// <summary> If player can move while in this emote (useful when its not full body, so legs can blend) </summary>
  public bool BlockMovements;
  /// <summary> Velocity of player that will trigger emote exit (ex some external movements) </summary>
  public float VelocityToExit;
  /// <summary> If Avatar IK should be kept enabled (ex sit/lie anims will want to disable this) </summary>
  public bool EnableIK;
  /// <summary> If this emote can be played on full body (ex upper body that has legs inside for some reason) </summary>
  public bool CanUseWhileStanding;
  /// <summary> Emote will not appear while sitting if its marked as false </summary>
  public bool CanUseWhileSitting;
  /// <summary> If true - will not be available by default and will need some logic from current player state, ex sitting in court, etc </summary>
  public bool RequiresSpecialState;

  public EmoteConfig(
    EmoteLayer layer,
    EmoteType type,
    bool allowPlayDuringMovement,
    bool blockMovements,
    float duration,
    bool canWhileStanding,
    bool canWhileSitting,
    bool requiresSpecialState);
}
