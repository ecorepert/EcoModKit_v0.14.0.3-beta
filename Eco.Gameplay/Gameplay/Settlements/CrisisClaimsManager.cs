// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.CrisisClaimsManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

#nullable enable
namespace Eco.Gameplay.Settlements;

/// <summary>Standalone manager that flags citizens to stop contributing claims after leaving a settlement and putting it into crisis. </summary>
/// <remarks>Once the crisis is resolved, this manager will make sure the settlements gain the claims they deserve.                    </remarks>
[Serialized]
public class CrisisClaimsManager : Singleton<
#nullable disable
CrisisClaimsManager>
{
  [Serialized]
  public ThreadSafeDictionary<Settlement, ThreadSafeHashSet<User>> FlaggedUsersPerSettlement;

  /// <summary> A user cannot provide claims if their previous settlement is currently in crisis. </summary>
  public bool CanProvideClaims(User user);

  public void Initialize();
}
