// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.Internal.TooltipSubscriptionStorage
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip.Internal;

/// <summary>
/// We use this struct to store all the data about our tooltips subscriptions (Keep track of what part is subscribed to which user and instance).
/// Important : this is just storing and not actually doing the caching, to see how we're actually caching each tooltip part you can start by checking <see cref="T:Eco.Gameplay.Systems.NewTooltip.TooltipPartBase" />.
/// </summary>
public struct TooltipSubscriptionStorage
{
  private const int ConcurrencyLevel = 4;
  private const int DefaultCapacity = 31 /*0x1F*/;
  private readonly ThreadSafeHashSet<User> users;
  private readonly ConcurrentDictionary<TooltipSubscriptionStorage.UserAndTooltipPartName, ConcurrentDictionary<TooltipSubscriptionStorage.TooltipPartTypeAndInstance, TooltipPartRef>> cachedTooltips;

  public TooltipSubscriptionStorage();

  /// <summary>Add a tooltip reference for the specified part to all our collections.</summary>
  public void Add(User user, TooltipPartBase part, IController controller);

  /// <summary>We try to get the tooltip part reference with the specified user, tooltip name, type and controller.</summary>
  public bool TryGetTooltipPartRef(
    User user,
    string tooltipName,
    Type type,
    IController controller,
    out TooltipPartRef tooltipRef);

  /// <summary>We get all the cached parts refs with the user that they are related to.</summary>
  public IEnumerable<(User User, TooltipPartRef PartRef)> GetAllPartsRefs();

  /// <summary>Using the specified tooltip name and type, we get a list of all the related parts with their users.</summary>
  public IEnumerable<(User User, TooltipPartRef PartRef)> GetPartsRefs(
    string tooltipName,
    Type type);

  /// <summary>We get all the tooltip parts with their type and controller that are named "tooltipName" and cached for the specified user.</summary>
  public IEnumerable<KeyValuePair<TooltipSubscriptionStorage.TooltipPartTypeAndInstance, TooltipPartRef>> GetTypeAndInstanceToPartRef(
    User user,
    string tooltipName);

  /// <summary>We get all the users that have any cached tooltip.</summary>
  public IEnumerable<User> AllUsersWithCachedTooltips { get; }

  /// <summary>We remove a tooltip reference to the specified tooltip part from our collections.</summary>
  public void RemovePartRef(User user, TooltipPartRef partRef);

  /// <summary>Remove all the tooltip parts references that are connected to the specified user.</summary>
  public void ClearAllTooltipsRefsForUser(User user);

  public void Clear();

  /// <summary>We store the user and the tooltip part name.</summary>
  public readonly struct UserAndTooltipPartName : 
    IEquatable<TooltipSubscriptionStorage.UserAndTooltipPartName>
  {
    public readonly User User;
    public readonly string PartName;

    public UserAndTooltipPartName(User user, string tooltipName);

    [CompilerGenerated]
    public override 
    #nullable disable
    string ToString();

    [CompilerGenerated]
    public static bool operator !=(
      TooltipSubscriptionStorage.UserAndTooltipPartName left,
      TooltipSubscriptionStorage.UserAndTooltipPartName right);

    [CompilerGenerated]
    public static bool operator ==(
      TooltipSubscriptionStorage.UserAndTooltipPartName left,
      TooltipSubscriptionStorage.UserAndTooltipPartName right);

    [CompilerGenerated]
    public override int GetHashCode();

    [CompilerGenerated]
    public override bool Equals(object obj);

    [CompilerGenerated]
    public bool Equals(
      TooltipSubscriptionStorage.UserAndTooltipPartName other);
  }

  /// <summary>We store the tooltip part type and the instance that's using it.</summary>
  public readonly struct TooltipPartTypeAndInstance : 
    IEquatable<TooltipSubscriptionStorage.TooltipPartTypeAndInstance>
  {
    public readonly 
    #nullable enable
    Type PartParentType;
    public readonly IController? RelatedInstance;

    public TooltipPartTypeAndInstance(Type type, IController instance);

    [CompilerGenerated]
    public override 
    #nullable disable
    string ToString();

    [CompilerGenerated]
    public static bool operator !=(
      TooltipSubscriptionStorage.TooltipPartTypeAndInstance left,
      TooltipSubscriptionStorage.TooltipPartTypeAndInstance right);

    [CompilerGenerated]
    public static bool operator ==(
      TooltipSubscriptionStorage.TooltipPartTypeAndInstance left,
      TooltipSubscriptionStorage.TooltipPartTypeAndInstance right);

    [CompilerGenerated]
    public override int GetHashCode();

    [CompilerGenerated]
    public override bool Equals(object obj);

    [CompilerGenerated]
    public bool Equals(
      TooltipSubscriptionStorage.TooltipPartTypeAndInstance other);
  }
}
