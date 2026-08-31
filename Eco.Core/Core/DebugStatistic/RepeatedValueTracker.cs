// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.RepeatedValueTracker
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.DebugStatistic;

/// <summary>
/// GlobalSubscribes to a provided list of types and analyzes notifications for these,
/// tracking repeated notifications of the same Controller member with the same value as the last notification
/// <br>Use <see cref="P:Eco.Core.DebugStatistic.RepeatedValueTracker.RepeatCounts" /> to get current count of repetitions of each Type.Member</br>
/// <br>Only tracks Server-Client notifications, not Server sided communications (ControllerID == 0)</br>
/// </summary>
public class RepeatedValueTracker
{
  /// <param name="types"> Types to analyze for repeated notifications </param>
  public RepeatedValueTracker(
  #nullable disable
  IEnumerable<Type> types);

  public void SubscribeNotifications();

  public void UnsubscribeNotifications();

  /// <summary> Sequence of pairs Type.Member and Number of repetitions </summary>
  public IEnumerable<KeyValuePair<string, int>> RepeatCounts { get; }
}
