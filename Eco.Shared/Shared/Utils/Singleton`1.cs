// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Singleton`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Utils;

public class Singleton<T> where T : Singleton<T>
{
  /// <summary>Current Singleton instance of this object.</summary>
  public static T Obj { get; }

  public virtual void ClearSingleton();

  public static void WithTempSingleton<TNew>(Action action) where TNew : T, new();

  public static void WithTempSingleton(Func<T> objCreator, Action action);

  /// <summary>
  /// Structure which used for temporary replaced singletons (for test purposes). It saves previous singleton object (usually null) and when disposed restores it.
  /// It may be preferred over <see cref="M:Eco.Shared.Utils.Singleton`1.WithTempSingleton``1(System.Action)" />, because you may create this object in [SetUp] method and destroy in [TearDown] method
  /// allowing all tests to run with this temp singleton without explicitly wrapping them in WithTempSingleton call.
  /// </summary>
  public readonly struct Temp : IDisposable
  {
    private readonly T savedObj;

    public static Singleton<T>.Temp Create<TNew>() where TNew : T, new();

    public static Singleton<T>.Temp Create(Func<T> factory);

    public void Dispose();
  }
}
