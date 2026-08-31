// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Placement.HostedObjectExtension
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Placement;

public static class HostedObjectExtension
{
  /// <summary>We update the validity of the hosted object according to whether it's still orphan or not.</summary>
  public static void UpdateHostedObjectValidity(this 
  #nullable disable
  IHostedObject hostedObject);

  /// <summary>Set the hosted object on a specified world object(it can be null), doing the proper needed updates.</summary>
  public static void SetHostObject(this IHostedObject hostedObject, WorldObject newHost);

  /// <summary>We check the validity of the hosted object.</summary>
  public static Result CheckHostState(this IHostedObject hostedObject);

  /// <summary>Returns objects that are currently hosted on this world object.</summary>
  public static IEnumerable<IHostedObject> GetHostedObject(IEnumerable<Type> types, WorldObject obj);

  public static IEnumerable<IHostedObject> GetHostedObject(Type type, WorldObject obj);

  /// <summary>Calculate how much time is left until the hosted object is disabled permanently.</summary>
  public static double CalcTimeToDisable(this IHostedObject hostedObject);

  public static double DisableTime(this IHostedObject hostedObject);

  public static bool IsHostedObjectSpecial(this IHostedObject entry);

  public static WorldObject GetHostObject(this IHostedObject hostedObj);

  /// <summary>We use this to initialize the hosted object when necessary.</summary>
  public static void InitializeHostedObject(this IHostedObject entry);

  /// <summary>Sets/clears a status element on a contained of hosted objects, to inform the user when they open the container object.</summary>
  public static void UpdateStatusForContainerObject(
    WorldObject obj,
    IEnumerable<IHostedObject> toDisable,
    Type objectType,
    ref StatusElement disableStatus);
}
