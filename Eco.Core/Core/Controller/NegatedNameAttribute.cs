// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.NegatedNameAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Controller;

/// <summary> For boolean properties that serve as context, this will be the negated name that we also add to context (so the bool 'Bought' can have a negated context name 'Sold' that is shown to the player).
/// Note: if you want a dynamic name for the tab, create a property named ComponentTabName in the class and make it synctoview.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class NegatedNameAttribute : Attribute
{
  public string NegatedName;

  public NegatedNameAttribute(string negatedName);
}
