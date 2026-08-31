// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.WorkPartyExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy.WorkParties;

public static class WorkPartyExtensions
{
  public static void Initialize();

  public static void OnPropertyChanged(object sender, PropertyChangedEventArgs e);

  public static int UserCount(this IEnumerable<Laborer> list);

  public static IEnumerable<User> Users(this IEnumerable<Laborer> list);

  public static CollectResourcesWork GetCollectResourcesWork(
    this WorkParty workParty,
    WorkOrder workOrder);
}
