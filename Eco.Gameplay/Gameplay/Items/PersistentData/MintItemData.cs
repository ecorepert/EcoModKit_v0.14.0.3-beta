// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.PersistentData.MintItemData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Items.PersistentData;

[Serialized]
public class MintItemData : 
  IController,
  IViewController,
  IHasUniversalID,
  IClearRequestHandler,
  IPermanentDestroyHandler,
  INotifyPropertyChanged
{
  [Notify]
  public static ThreadSafeAction<MintItemData> CurrencyRenamedEvent { get; }

  [Serialized]
  [SyncToView(null, true)]
  public Currency Currency { get; }

  public bool HasDataThatCanBeCleared { get; }

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public void SetCurrency(Currency value);

  public Result TryHandleClearRequest(Player player);

  public void OnPermanentDestroy();
}
