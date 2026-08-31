// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementSpawnConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Settlements;

public class SettlementSpawnConfig : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [Eco.Shared.Networking.Eco(true)]
  public int CitizensPerTown { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public int TownsPerCountry { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public int CountriesPerFederation { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public int Federations { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public bool GovernmentInEachSettlement { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }
}
