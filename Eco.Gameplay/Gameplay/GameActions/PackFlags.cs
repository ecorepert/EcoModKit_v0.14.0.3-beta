// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.PackFlags
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.GameActions;

/// <summary>A set of flags that can be set on a game action pack to change how its processed.</summary>
[Flags]
public enum PackFlags
{
  /// <summary>If set, anything preventing the action is ignored.</summary>
  Force = 1,
  /// <summary>If set, the performance will skip the post effects.</summary>
  DryRun = 2,
}
