// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Display.Dialogs.LargeTextDisplayer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Display.Dialogs;

/// <summary>
/// A service that will store large strings for a given period of time, for users to view them at will using foldouts or other methods.
/// </summary>
[Serialized]
public class LargeTextDisplayer : 
  Singleton<LargeTextDisplayer>,
  IHasSerializableID,
  IHasUniversalID,
  IStorage,
  ISerializable,
  ILinkable
{
  /// <summary>Creates a foldout that when clicked will display large text.</summary>
  public LocString FoldoutLargeTextLoc(
    LocString header,
    LocString text,
    bool serialize,
    float hoursToKeep = 0.1f);

  /// <summary>Creates a foldout with truncated text as name that on hover will display full text.</summary>
  /// <returns>If text is considered large, returns it in form of a foldout.</returns>
  public LocString FoldoutLargeMessageToAll(LocString text);

  /// <summary>Display a large text with the given ID.</summary>
  [RPC]
  public void DisplayText(Player player, string textID);

  /// <summary>Returns a large text with the given ID in form of a TooltipSection.</summary>
  [RPC]
  public TooltipSection DisplayFoldout(string textID);

  public void CleanupOldTexts();

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public LocString UILinkContent();

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public IPersistent StorageHandle { get; set; }

  [Serialized]
  private class LargeText
  {
    [Serialized]
    public string Header;
    [Serialized]
    public string Text;
    [Serialized]
    public double ExpirationTime;
  }
}
