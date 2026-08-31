// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.CountdownExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Utils;

/// <summary> Functions that modify immutable countdowns to return a new countdown. </summary>
public static class CountdownExtensions
{
  /// <summary> Returns a new countdown with the same duration as the referenced one.</summary>
  public static ImmutableCountdown ResetAndPause(this ImmutableCountdown c);

  public static ImmutableCountdown Pause(
    this ImmutableCountdown c,
    bool set,
    double overrideTimeLeft = -1.0);
}
