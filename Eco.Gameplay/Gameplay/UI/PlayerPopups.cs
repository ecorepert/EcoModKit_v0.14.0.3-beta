// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.UI.PlayerPopups
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Services;
using Eco.Shared.UI;
using Eco.Shared.Voxel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.UI;

public static class PlayerPopups
{
  public static void Error(this 
  #nullable disable
  Player player, LocString message);

  public static void ErrorLocStr(this Player player, string message);

  public static void ErrorLoc(this Player player, FormattableString message);

  public static void InfoBox(this Player player, LocString message);

  public static void InfoBoxLocStr(this Player player, string message);

  public static void InfoBoxLoc(this Player player, FormattableString message);

  public static void Msg(this Player player, LocString message, NotificationStyle style = NotificationStyle.Chat);

  public static void MsgLoc(this Player player, FormattableString message, NotificationStyle style = NotificationStyle.Chat);

  public static void MsgLocStr(this Player player, string message, NotificationStyle style = NotificationStyle.Chat);

  public static Result OkBox(this Player player, LocString message, bool succeeded);

  public static void OkBox(this Player player, LocString message);

  public static void OkBoxLoc(this Player player, FormattableString message);

  public static Task<bool> OkBoxAwaitable(this Player player, LocString message);

  public static Task<bool> OkBoxAwaitableLoc(this Player player, FormattableString message);

  public static Task<bool> ConfirmBoxLoc(this Player player, FormattableString message);

  public static Task<bool> ConfirmBox(this Player player, LocString message);

  public static Result OkBoxLoc(this Player player, FormattableString message, bool succeeded);

  public static Task<List<INamed>> PopupSelectFromOptions(
    this Player player,
    LocString title,
    LocString entryName,
    LocString entryNamePlural,
    IEnumerable<INamed> options,
    IEnumerable<INamed> existingSet,
    MultiSelectorPopUpFlags flags = MultiSelectorPopUpFlags.ShowCategories,
    LocString? subtitle = null);

  public static Task<List<string>> PopupSelectItemsFromTag(
    this Player player,
    LocString title,
    string tagName,
    List<string> currentAllowedTypeNames);

  public static Task<List<object>> PopupSelectFromIndexedOptions(
    this Player player,
    LocString title,
    LocString entryName,
    LocString entryNamePlural,
    PlayerPopups.NamedSelection[] options,
    MultiSelectorPopUpFlags flags = MultiSelectorPopUpFlags.None);

  public static void PopupSelectSelectDerivedInstances(
    this Player player,
    LocString title,
    LocString entryName,
    LocString entryNamePlural,
    Type baseType,
    IEnumerable<INamed> existingSet,
    Action<List<INamed>> callback,
    MultiSelectorPopUpFlags flags = MultiSelectorPopUpFlags.None);

  public static void PopupTypePicker(
    this Player player,
    LocString title,
    Type type,
    Action<List<Type>> callback);

  /// <summary>Shows a dialog with a dropdown.</summary>
  /// <param name="player"></param>
  /// <param name="message">The text to be shown.</param>
  /// <param name="options">Options to be added to the dropdown.</param>
  /// <returns>Index of the selected item. -1 if the player cancells the dialog.</returns>
  public static Task<int> OptionBox(this Player player, LocString message, List<string> options);

  public static Task<float> PopupNumberBox(
    this Player player,
    string text,
    string quantityText,
    string buttonText,
    int defaultVal,
    Eco.Shared.Math.Range range,
    bool integerOnly);

  /// <summary><paramref name="title" /> and <paramref name="confirmLabel" /> rename the header and the confirm button when the purchase isn't a plain buy,
  /// like paying for a dish eaten on the spot. The quantity row hides itself when a single unit is available.</summary>
  public static Task<AccountAndAmount> PopupBuyPlacedItems(
    this Player player,
    string description,
    int numAvailable,
    float pricePerItem,
    PlotPos pos,
    Currency currency,
    LocString title = default (LocString),
    LocString confirmLabel = default (LocString));

  public struct NamedSelection
  {
    public string Name;
    public object Entry;
  }
}
