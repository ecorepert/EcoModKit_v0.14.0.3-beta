// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Internal.ChangeDetection.SettlementChangeDetector
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.View;

#nullable enable
namespace Eco.Gameplay.Settlements.Internal.ChangeDetection;

public class SettlementChangeDetector : 
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  public void Initialize();

  public void Tick();

  /// <summary>Trigger an immediate update of all dirty settlement aspects.</summary>
  public void DoUpdateNow();

  /// <summary>Set everything to update next tick, and make the tick happen right away.</summary>
  public void MarkAllForUpdate(bool now);

  public ref 
  #nullable disable
  ThreadSafeSubscriptions Subscriptions { get; }
}
