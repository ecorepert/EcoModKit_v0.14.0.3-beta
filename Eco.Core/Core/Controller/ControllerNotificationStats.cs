// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ControllerNotificationStats
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Controller;

/// <summary>Lightweight, opt-in counter for controller PropertyChanged fan-out. Used for diagnostics only.</summary>
public static class ControllerNotificationStats
{
  public static bool Enabled { get; }

  public static void Enable();

  public static bool TryEnable();

  public static void Disable();

  public static void Reset();

  public static void Record(string controller, string property, int subscriberCount);

  /// <summary>Snapshot ordered by total fan-out, descending.</summary>
  public static IReadOnlyList<(string Controller, string Property, long Calls, long Fanout)> Snapshot();

  public sealed class Stat
  {
    public long Calls;
    public long Fanout;
  }
}
