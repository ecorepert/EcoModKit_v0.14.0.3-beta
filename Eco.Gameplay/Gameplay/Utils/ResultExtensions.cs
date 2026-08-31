// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.ResultExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Services;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Utils;

public static class ResultExtensions
{
  public static bool NotifyWithInfoPanel(
    this Result result,
    Player player,
    string title,
    string category = "general");

  public static Result Notify(this Result result, params User[] users);

  public static Result Notify(this Result result, Player? player);

  public static Result Notify(this Result result, User? user, bool forceTemporary = false);

  public static LazyResult Notify(this LazyResult result, Player? player);

  public static LazyResult Notify(this LazyResult result, User? user, bool forceTemporary = false);

  public static ValResult<T> NotifyIf<T>(this ValResult<T> result, bool test, params User[] users);

  public static Result NotifyIf(this Result result, bool test, params User[] users);

  public static Result NotifyAll(this Result result, NotificationCategory tag);

  public static Result Combine(this Result result, Result other, LocString messageDelimiter);

  public static Result Combine(this IEnumerable<Result> results, LocString messageDelimiter);

  public static void NotifyIfFailedLoc(
    this Result result,
    FormattableString title,
    NotificationCategory tag);

  /// <summary> If result is failed, notifies <paramref name="notifyUser" /> with failure message and with message style <see cref="F:Eco.Shared.Services.NotificationStyle.Error" />. Returns <c>true</c> if result failed.</summary>
  public static bool NotifyIfFailed(this Result result, User notifyUser);
}
