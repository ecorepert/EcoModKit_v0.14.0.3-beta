// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Dispository
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Utils;

/// <summary>
/// Dispository (Disposable Repository) used for objects with IDisposable interface which won't be disposed in usual way,
/// because they are singletons in example. In shutdown logic you should call DisposeAll to proper dispose all registered objects.
/// </summary>
public static class Dispository
{
  public static void AutoDispose(IDisposable disposable);

  public static void DisposeAll();
}
