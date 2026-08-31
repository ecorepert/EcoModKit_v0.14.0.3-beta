// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.EcoMarketplace.EcoMarketplaceManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Achievements;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.View;
using PropertyChanged;
using StrangeCloud.Service.Client.Contracts;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Systems.EcoMarketplace;

/// <summary>Manages the list of stuff to buy provided to the client. </summary>
public class EcoMarketplaceManager : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public 
  #nullable disable
  List<MarketplaceCategory> Categories { get; set; }

  [SyncToView(null, true)]
  public Dictionary<string, AchievementDefinition> AchievementsRequiredForRecipes { get; set; }

  [SyncToView(null, true)]
  public ThreadSafeHashSet<int> ItemIDsRequiringStrangeItem { get; set; }

  public void Initialize();

  /// <summary>Notifies the server that an item was bought and to update accordingly.</summary>
  [RPC]
  public void UserTransactionComplete(User user, MarketplaceTransaction transaction);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public static Initializer Initializer { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
