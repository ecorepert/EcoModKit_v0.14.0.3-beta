// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.GamePickerListAlias
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics.GameValues;

/// <summary>Special case for a list of aliases that gives some extra features, allowing watching of the full list of users.</summary>
/// 
///             Deprecated, use ControllerListAlias
[Eco.Shared.Networking.Eco(true)]
public class GamePickerListAlias : GamePickerList
{
  /// <summary>Triggers when user contents change, passing a list of both added and removed users.</summary>
  public 
  #nullable disable
  ThreadSafeAction<IEnumerable<User>> OnUserSetChanged { get; set; }

  public IEnumerable<IAlias> Values { get; }

  /// <summary>Returns all the users mentioned in our list.</summary>
  public IEnumerable<User> UserSet { get; }

  [Eco.Shared.Serialization.OnDeserialized]
  public void OnDeserialized();

  protected override void NewEntry(INetObject arg1, object o);

  protected override void RemovedEntry(INetObject arg1, object o);

  protected override void EntriesChanged();
}
