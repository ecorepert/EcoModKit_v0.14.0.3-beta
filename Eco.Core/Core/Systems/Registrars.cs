// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.Registrars
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Utils;
using Eco.Shared.Networking;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Systems;

public static class Registrars
{
  public static List<IRegistrar> AllRegistrars;
  public static Dictionary<Type, IRegistrar> DerivedTypeToRegistrar;
  public static Dictionary<string, IRegistrar> DerivedTypeNameToRegistrar;
  public static Dictionary<string, IRegistrar> RegistrarNameToRegistrar;
  public static Initializer Initializer;

  public static IRegistrar? GetByDerivedTypeOrDefault(Type type);

  public static IRegistrar? GetByDerivedTypeOrDefault(string typeName);

  public static Registrar<T>? GetOrDefault<T>() where T : class, IHasID;

  public static IRegistrar GetByDerivedType(Type type);

  public static IRegistrar GetByDerivedType(string typeName);

  public static Registrar<T> Get<T>() where T : class, IHasID;

  public static IEnumerable<T> All<T>() where T : IHasID;

  public static T? Add<T>(INetObject? client = null, string? name = null) where T : IHasID;

  public static void Insert(IHasID t);

  public static IEnumerable<IRegistrar> VisibleRegistrars { get; }

  public static Dictionary<string, IRegistrar> SharedWithClient { get; }

  /// <summary>Adds pre-init command which runs before initialization of any registrar.</summary>
  public static void AddPreInitCommand(Action command);

  /// <summary>Runs all pre-init commands and clears the list.</summary>
  public static void RunAndClearPreInitCommands();

  public static void Register(IRegistrar r);

  /// <summary>Verifies all registrars. Should be called when all fixups already applied, makes low level verification and removes invalid entities.</summary>
  public static void Verify();

  public static void InitializeAllRegistrars();

  public static string RandomString(int length);

  public static string RandomString(int length, List<IRegistrar>? possibleRegistrars);

  public static string RandomLink();

  public static string RandomLink(IReadOnlyList<IRegistrar?> registrars, int amount = 1);
}
