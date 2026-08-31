// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Common.WorkableExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.Common;

public static class WorkableExtensions
{
  /// <summary> Removes workables from their host containers and adds them to the provided one. Amount of entries to move can be capped. </summary>
  public static void MoveWorkables(
    this IEnumerable<Workable> workablesToMove,
    ContainedWorkables newContainer,
    WorldObject newHost,
    int maxEntriesToMove = -1);

  public static LocString DescribeWorkables(this IEnumerable<Workable> workablesToDescribe);
}
