// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.EnabledParamAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Controller;

/// <summary> Specifies the name of another property on this same object that determines if this UI should be enabled or not.
/// If the property using this is a list, its expcted the property pointed to is also a list.</summary>
public class EnabledParamAttribute : Attribute
{
  public string EnabledDeterminedByParam;

  public EnabledParamAttribute(string paramName);
}
