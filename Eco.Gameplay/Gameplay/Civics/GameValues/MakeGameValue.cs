// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.MakeGameValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Aliases;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Players;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

/// <summary>A GameValue factory for the most used cases.</summary>
public static class MakeGameValue
{
  public static Eco.Gameplay.Civics.GameValues.GameValue<T> GameValue<T>(T t);

  public static Eco.Gameplay.Civics.GameValues.GameValue<BankAccount> Treasury { get; }

  public static Eco.Gameplay.Civics.GameValues.GameValue<IAlias> Everyone { get; }

  public static Eco.Gameplay.Civics.GameValues.GameValue<IAlias> Active { get; }

  public static Eco.Gameplay.Civics.GameValues.GameValue<float> Number(float number);

  /// <param name="type">The type that has the property that we want to use as context.</param>
  /// <param name="propertyName">The name of the property that we want to use as context (It must be of type User).</param>
  public static Eco.Gameplay.Civics.GameValues.GameValue<User> UserContext(
    Type type,
    string propertyName);
}
