// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.OptimizedActivator
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Reflection;

#nullable enable
namespace Eco.Core.Utils;

/// <summary>
/// https://rogerjohansson.blog/2008/02/28/linq-expressions-creating-objects/
/// https://stackoverflow.com/a/16162475
/// https://stackoverflow.com/questions/13041674/create-func-or-action-for-any-method-using-reflection-in-c
/// Check above links for details.
/// </summary>
public static class OptimizedActivator
{
  public static OptimizedActivator.ActivatorDelegate<T> GetDefaultActivator<T>();

  public static OptimizedActivator.ActivatorDelegate<T> GetActivator<T>(ConstructorInfo ctor);

  /// <summary>Builds compiled delegate of type <typeparamref name="T" /> (much faster than reflection) for call to <paramref name="method" />. If <typeparamref name="T" /> has less arguments than method then <paramref name="missingParamValues" /> will be used or default values supplied.</summary>
  public static T BuildDelegate<T>(this MethodInfo method, params object[] missingParamValues) where T : Delegate;

  public delegate T ActivatorDelegate<out T>(params object[] args);
}
