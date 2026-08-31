// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.GroupMarker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Players;

/// <summary>Wraps world marker to make a single world marker appear to many users.</summary>
[Serialized]
public class GroupMarker
{
  [Serialized]
  public string PrependText;

  public void Initialize(
    Vector3i pos,
    User userToAdd,
    string prependText,
    string markerText,
    IEnumerable<IStack> stacks);

  public void Initialize(
    Vector3i pos,
    IEnumerable<User> usersToAdd,
    string categoryText,
    string markerText,
    IEnumerable<IStack> stacks);

  public void Clear();

  public void SetStacks(IEnumerable<IStack> stacks);

  public void SetMarkerText(string text);

  public void UpdateMarkerForAllUsers();

  public void AddUser(User user, bool notify = true);

  public void RemoveUser(User user);

  public void AddUsers(IEnumerable<User> users);

  public void RemoveUsers(IEnumerable<User> users);
}
