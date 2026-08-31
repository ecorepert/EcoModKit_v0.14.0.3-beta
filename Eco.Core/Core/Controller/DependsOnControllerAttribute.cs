// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.DependsOnControllerAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.Controller;

/// <summary> This attribute says that this view value depends on another's, so send that result as well
/// when it changes. Note that dependencies which are not 'synctoview' will not be found.
/// NOTE: There is another [DependeOn] attribute that is similar, but uses fody property change detection instead.
/// That one is faster, doing it when the change occurs, while this one will queue it up for a later change call.</summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
public class DependsOnControllerAttribute : SyncToViewAttribute
{
  public readonly string[] DependencyNames;

  public DependsOnControllerAttribute(string dependencyName, bool viewIsReadOnly = true);

  public DependsOnControllerAttribute(params string[] dependencyNames);
}
