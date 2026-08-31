// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.HierarchyComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.Collections.Generic;
using System.Numerics;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>
/// Defines hierarchy that can have child objects attached or parent object
/// Use AttachChild and DetachChild on parent object to manipulate hierarchy of objects
/// </summary>
[Serialized]
[AlwaysMayBeComponent]
[NoIcon]
public class HierarchyComponent : WorldObjectComponent, IPickupConfirmationComponent
{
  /// <summary> Event to notify about hierarchy changed about (if this object attached or detached) contains old and new object </summary>
  public 
  #nullable disable
  ThreadSafeAction<WorldObject, WorldObject> HierarchyChangedEvent;
  public static int MaxAttachDepth;

  public bool IsAttached { get; }

  public bool HasAttachments { get; }

  [Serialized]
  public WorldObjectHandle AttachedTo { get; }

  [SyncToView(null, true)]
  public int AttachedToNetObjID { get; }

  /// <summary>The object we're attached to, null once it's gone: a parent may be destroyed without detaching us, leaving the handle pointing at nothing.</summary>
  public WorldObject AttachedToObject { get; }

  /// <summary> The child objects attached to this one. Handles that no longer resolve are skipped, so callers never see a destroyed child. </summary>
  public IEnumerable<WorldObject> AttachedWorldObjects { get; }

  public override void PostInitialize();

  /// <summary> Attaches target object to this as a child </summary>
  public void AttachChild(WorldObject child);

  /// <summary> Detaches target object from this as a child </summary>
  public void DetachChild(WorldObject child);

  public override void Destroy();

  /// <summary>Returns all objects attached to us, as well as to attached to an attached object, etc</summary>
  public IEnumerable<WorldObject> AllAttachedRecursive();

  /// <summary> Applies parent object pos and rot delta to all child attached objects recursively </summary>
  public void ApplyHierarchyDeltaToChildren(
    Vector3 posBefore,
    Eco.Shared.Math.Quaternion rotBefore,
    Vector3 posAfter,
    Eco.Shared.Math.Quaternion rotAfter);

  LocString IPickupConfirmationComponent.GetComponentPickupConfirmation();

  /// <summary> Checks if object has hierarchy component and has object attached to it </summary>
  public static bool HasAttachedObjects(WorldObject obj);

  /// <summary>Counts the surface-attachment links between this object and the ground; an unattached object is 0.</summary>
  public static int GetAttachDepth(WorldObject obj);

  /// <summary>True when nothing further may be attached on top of <paramref name="obj" />.</summary>
  public static bool HasReachedMaxDepth(WorldObject obj);

  /// <summary>Returns an enumerable containing us as well as all attached (recursive) objects.</summary>
  public static IEnumerable<WorldObject> AllAttachedRecursiveAndSelf(WorldObject obj);

  /// <summary>Returns an enumerable all attached (recursive) objects without self.</summary>
  public static IEnumerable<WorldObject> AllAttachedRecursive(WorldObject obj);
}
