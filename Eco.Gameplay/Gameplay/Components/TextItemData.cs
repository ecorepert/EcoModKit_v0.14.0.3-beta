// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.TextItemData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
public class TextItemData : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IClearRequestHandler
{
  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }

  [Serialized]
  [SyncToView(null, true)]
  public string Text { get; set; }

  public bool HasDataThatCanBeCleared { get; }

  public CustomTextComponent Parent { get; set; }

  public Result TryHandleClearRequest(Player player);
}
