// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Aliases.IAlias
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Demographics;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Aliases;

/// <summary>An object that contains a list of users (<see cref="T:Eco.Gameplay.Civics.Titles.Title" />, <see cref="T:Eco.Gameplay.Civics.Demographics.Demographic" />, <see cref="T:Eco.Gameplay.Players.User" />).</summary>
[Serialized]
[ForceCreateView]
[CustomIconOnTypeTooltip(typeof (Demographic))]
public interface IAlias : 
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  INotifyPropertyChanged
{
  [SyncToView(null, true)]
  IEnumerable<User> UserSet { get; }

  bool ContainsExactAlias(IAlias alias);

  bool ContainsUser(User user);

  bool Valid { get; }

  /// <summary>Raised when a user/users are added or removed from the UserSet. When invoked this event get passed the list of users that were added and removed.</summary>
  ThreadSafeAction<IEnumerable<User>> UserSetChangedEvent { get; set; }
}
