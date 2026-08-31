// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PaintableItemData
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
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Synced data for persisting color data for a paintable world object.</summary>
[Serialized]
public sealed class PaintableItemData : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IClearRequestHandler
{
  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }

  public bool HasDataThatCanBeCleared { get; }

  /// <summary>Represents the red color channel on the world object's material.</summary>
  [Serialized]
  [SyncToView(null, true)]
  public ByteColor ChannelOneColor { get; set; }

  /// <summary>Represents the green color channel on the world object's material.</summary>
  [Serialized]
  [SyncToView(null, true)]
  public ByteColor ChannelTwoColor { get; set; }

  /// <summary>Represents the blue color channel on the world object's material.</summary>
  [Serialized]
  [SyncToView(null, true)]
  public ByteColor ChannelThreeColor { get; set; }

  public bool AnyChannelPainted { get; }

  /// <summary>
  /// Attempts to clear th configured colors on the world object. This restores it to its original
  /// color state as defined by the art team.
  /// </summary>
  public Result TryHandleClearRequest(Player player);

  public bool SetAllChannelsColor(ByteColor color);

  public bool SetChannelOneColor(ByteColor color);

  public bool SetChannelTwoColor(ByteColor color);

  public bool SetChannelThreeColor(ByteColor color);
}
