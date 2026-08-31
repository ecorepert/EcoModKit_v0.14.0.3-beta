// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.Web.Utils.ControllerExtensions
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Microsoft.AspNetCore.Mvc;

#nullable enable
namespace Eco.WebServer.Web.Utils;

internal static class ControllerExtensions
{
  public const double DefaultTimeValue = -1.0;

  public static Range InputDaysToRangeSeconds(
    this Controller controller,
    double startDays,
    double endDays);

  public static void ThrowError(this Controller controller, string message);

  public static void ThrowError(this Controller controller, LocString message);

  /// <summary>Get an Eco user from the controller's HttpContext (if any).</summary>
  /// <returns>User that's logged in, or null if none.</returns>
  public static User? GetUserFromContext(this Controller controller);
}
