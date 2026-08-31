// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.CurrencyHolding
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy;

[Serialized]
public class CurrencyHolding : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public static ThreadSafeAction<CurrencyHolding> ValChangedEvent { get; }

  [Serialized]
  [SyncToView(null, true)]
  public Currency Currency { get; set; }

  [SyncToView(null, true, Flags = SyncFlags.UnreliableChangeNotification)]
  public float Val { get; set; }

  public string Description { get; }

  [RPC]
  public void SetVal(float v);

  public override string ToString();

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
