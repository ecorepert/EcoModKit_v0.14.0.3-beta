// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.ISettlementAssociated
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Settlements;

/// <summary>For items and other types that have an associated settlement. Allows using inventory restrictions that limit to a specific settlement (like claim stakes that can only
/// hold claim papers from a specific settlement)</summary>
public interface ISettlementAssociated : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [ClientInterfaceProperty]
  [Notify]
  Settlement Settlement { get; set; }
}
