// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.AdditionalUserState`2
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Players;

/// <summary>
/// A mod friendly way of adding additional state to Users.
/// </summary>
/// <typeparam name="T">The type of the state to save.  Must be convertable to and from a string.</typeparam>
/// <typeparam name="TSelf">Self type.</typeparam>
public abstract class AdditionalUserState<T, TSelf> : AutoSingleton<TSelf>
  where T : new()
  where TSelf : AdditionalUserState<T, TSelf>
{
  public ThreadSafeAction<User> OnChanged { get; }

  protected abstract string Key { get; }

  public T GetState(User user);

  public void SetState(User user, T val);
}
