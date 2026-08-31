// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.SettlementLegal
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Settlements;
using Eco.Shared.Serialization;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy;

[Serialized]
public class SettlementLegal : INotifyPropertyChanged
{
  public void Initialize(Settlement settlement);

  public void UpdateBlocks();

  /// <summary>See if this settlement or any of its parents is blocking the specified trigger or legal action.</summary>
  public bool TriggerOrLegalActionIsBlocked(Type type);

  /// <summary>See if this settlement or any of its parents is blocking the specified law.</summary>
  public bool LawIsBlocked(Law law);

  public event PropertyChangedEventHandler PropertyChanged;
}
