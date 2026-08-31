// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipSubscriptions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Players;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip;

/// <summary>
/// Helper class to manage the subscriptions to tooltips by users.
/// Tracks which parts are dirty, informs users of them on an interval, and clears
/// the cache. They are recached the next time they are queried (ie, lazily).
/// </summary>
/// <remarks>See 'Tooltip.md' for more info.</remarks>
public class TooltipSubscriptions : ITooltipSubscriptions
{
  /// <summary>Marks a user as having received the tooltip part, so we know to inform them if it gets invalidated.</summary>
  public void Subscribe(User user, TooltipPartBase part, IController controller);

  /// <summary>Marks tooltip part as dirty. All parameters required by this part's CacheMode must be provided.</summary>
  /// <param name="includeDerivedTypes">If set to true, all types that derive from passed type will also have this tooltip part marked as dirty. Should only be used with <see cref="F:Eco.Shared.Items.CacheAs.SubType" />.</param>
  /// <remarks>If the tooltip is only using <see cref="F:Eco.Shared.Items.CacheAs.User" /> then we still need to specify a type when invoking this method.</remarks>
  public void MarkTooltipPartDirty(
    string partName,
    Type type = null,
    IController instance = null,
    User user = null,
    bool includeDerivedTypes = false,
    bool markDirtyForAllUsers = false);

  /// <summary>Scans entire tooltip cache for entries referencing objects that were alread ygarbage collected and removes them on server and clients by marking them as dirty.</summary>
  public void RemoveDeadEntries();

  /// <summary>Go through all the dirty tooltips and tell whoever subscribes to each one that they're gonna need to refresh next time they need it.
  /// Also clear the server cache for these dirty tooltips.</summary>
  public void ApplyDirtyTooltips();

  /// <summary>
  /// Clears the record of parts that this user is subscribed to. Since we dont store user-specific data on the server-side cache, we
  /// dont need to remove any cached data otherwise.
  /// </summary>
  public void ClearCacheForUser(User user);

  /// <summary>Clear the cache and list of dirty things.</summary>
  public void ClearCache();
}
