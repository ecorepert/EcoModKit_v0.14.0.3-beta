// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ControllerPropertyNameAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.Controller;

/// <summary>
/// Attribute marking a parameter as a controller property name for static analysis (i.e. ControllerSubscribeAnalyzer). Requires controller passed as an another parameter of same method.
/// By default uses previous parameter as controller, but the controller parameter may be explicitly specified with optional <see cref="P:Eco.Core.Controller.ControllerPropertyNameAttribute.ControllerParameterName" /> property.
/// A property with the attribute should exists on subject and have sync attributes like [SyncToView] or [Eco]. If property isn't constant (string literal) then it should be either
/// parameter reference for a parameter with <see cref="T:Eco.Core.Controller.ControllerPropertyNameAttribute" /> or should be suppressed with disable warning or SuppressMessage attribute.
/// </summary>
[AttributeUsage(AttributeTargets.Parameter)]
public class ControllerPropertyNameAttribute : Attribute
{
  public string? ControllerParameterName { get; }

  public ControllerPropertyNameAttribute(string? controllerParameterName = null);
}
