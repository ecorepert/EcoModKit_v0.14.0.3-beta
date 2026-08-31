// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Annexation.AnnexationManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Shared.View;

#nullable enable
namespace Eco.Gameplay.Settlements.Annexation;

/// <summary>Maintains a list of all the settlements that can annex another or are in progress of it (so they can get advance warning)</summary>
public class AnnexationManager : 
  Singleton<
  #nullable disable
  AnnexationManager>,
  IThreadSafeSubscriptions,
  ISubscriptions<
  #nullable enable
  ThreadSafeSubscriptions>,
  ISubscriptions
{
  public 
  #nullable disable
  ThreadSafeAction<Settlement, IAnnexable> AnnexationCompleteEvent;
  public object AnnexLock;
  public ThreadSafeDictionary<(IAnnexable Source, IAnnexable Target), AnnexationRecord> CachedAnnexRecords;

  public LocString Describe();

  public bool AllowAdminsAnnexWithoutRequirements { get; set; }

  public void AnnexAndNotify(User user, Settlement source, IAnnexable target, bool force);

  /// <summary>Perform an annex of target settlement into source settlement. If user set, verify they are the leader.</summary>
  public Result DoAnnex(User user, Settlement source, IAnnexable target, bool force);

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
