// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementDebug
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Settlements;

/// <summary>Various debug flags concenting settlements that are typically enabled via chat commands.</summary>
public class SettlementDebug : INotifyPropertyChanged
{
  [Notify]
  public bool IgnoreSettlementRequirements { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;
}
