// Decompiled with JetBrains decompiler
// Type: Eco.Core.Tooltips.TooltipsCore
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.PropertyHandling;
using System;
using System.Reflection;

#nullable enable
namespace Eco.Core.Tooltips;

/// <summary>Utils for watching properties on properties.</summary>
public static class TooltipsCore
{
  /// <summary>A function filled in by the tooltip system, which lives in gameplay, that will create an action invalidating a specific tooltip.</summary>
  public static TooltipsCore.CreateTooltipInvalidationAction? CreateTooltipInvalidationActionDelegate;

  public delegate PropertyChangedBeforeAfterEventHandler CreateTooltipInvalidationAction(
    Type type,
    MethodInfo method);
}
