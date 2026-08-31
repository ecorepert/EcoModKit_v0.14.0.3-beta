// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.AuthorizationInventory
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary> Inventories of this type should be used when they can be accessed by other players.
/// It's also possible to adjust authorization flags for some non-standard scenarios. </summary>
[Serialized]
public class AuthorizationInventory : LimitedInventory, IContributesMoveGameAction
{
  [Serialized]
  public AuthorizationInventory.AuthorizationFlags Authorizations { get; set; }

  [Serialized]
  public AccessType AuthorizationLevel { get; set; }

  public override bool NeedsAuth { get; }

  public AuthorizationInventory();

  public AuthorizationInventory(
    int maxStacks,
    AuthorizationInventory.AuthorizationFlags autorizations = (AuthorizationInventory.AuthorizationFlags) 0,
    AccessType authLevel = AccessType.ConsumerAccess);

  public GameAction MakeMoveGameAction(Type itemType, int delta, User user);

  /// <summary> These flags allow to forbid or allow some scenarios when players interact with <see cref="T:Eco.Gameplay.Items.AuthorizationInventory" />. </summary>
  [Serialized]
  [Flags]
  public enum AuthorizationFlags
  {
    PublicMayAdd = 1,
    PublicMayRemove = 2,
    AuthedMayAdd = 4,
    AuthedMayRemove = 8,
  }
}
