// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.InitializableExtension
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Utils;

public static class InitializableExtension
{
  /// <summary>Call now if the object is already initialized, and if not then queue it for when that happens. Higher priority is called first.</summary>
  /// <param name="priority">Higher value means higher priority.</param>
  public static void RunIfOrWhenInitialized(this Initializer obj, Action action, int priority = 0);

  public static void RunIfOrWhenInitialized(this IInitializationSubscribable obj, Action action);

  public static void Initialize(this IInitializationSubscribable obj);

  /// <summary>Runs an action when two initializers are initialized.</summary>
  public static void ChainTo(this Initializer obj, Initializer other, Action action, int priority = 0);
}
