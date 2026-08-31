// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Culture.CultureManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Achievements;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements.Culture;

/// <summary>Manages various tracking of culture.</summary>
[Serialized]
public class CultureManager : 
  Singleton<
  #nullable disable
  CultureManager>,
  IController,
  IViewController,
  IHasUniversalID,
  IHasSerializableID,
  IContainsAchievements,
  INotifyPropertyChanged
{
  public ThreadSafeAction ChangedEvent;

  /// <summary>Returns how many users have produced &gt; 0 culture.</summary>
  [Notify]
  public int CultureCreatingUserCount { get; }

  /// <summary>Global culture sum for *actual* cultural values (ie, the settlement reduction is applied in the sum for artwork)</summary>
  [Notify]
  public float GlobalCulture { get; }

  [SyncToView(null, true)]
  public float TotalCulture { get; set; }

  /// <summary>Shows the ranks of all culture creating citizens.</summary>
  [SyncToView(SyncFlags.MustRequest)]
  public string CitizenCultureRanksText { get; set; }

  /// <summary>Displays all the top cultural works generating culture.</summary>
  [SyncToView(SyncFlags.MustRequest)]
  public string CulturalWorksRanksText { get; set; }

  public void Initialize();

  public void FastTick();

  [RPC]
  public TooltipSection ArtworkFoldout(string texID);

  [RPC]
  public TooltipSection CulturalWorksOfUser(string userID);

  [RPC]
  public TooltipSection CultureRanksFoldout();

  /// <summary>Describes the total culture and number of works a user has made with a link to the full list.</summary>
  public LocString DescribeCultureCreated(User user);

  /// <summary>Describes the rank of the user with a foldout going to the full list.</summary>
  public LocString DescribeCulturalRank(User user);

  /// <summary>Makes a nice summary for all the culture in the world.</summary>
  public LocString DescribeAllCulture();

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
