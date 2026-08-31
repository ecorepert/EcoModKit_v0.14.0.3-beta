// Decompiled with JetBrains decompiler
// Type: Eco.Core.Items.TagAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Items;

/// <summary> Tags can be added to types or properties to allow other systems to identify them and use them if they want to.
/// <para>    For example the interaction system heavily uses tags to determine what interactions are valid for the targeted object. </para>
/// </summary>
/// <remarks> We prefer using tags over attributes on IControllers because tags are being sent over view IDs instead of strings. </remarks>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Interface, AllowMultiple = true)]
public class TagAttribute : Attribute
{
  public static Dictionary<string, string[]> CategoryToTags;
  /// <summary>When true, then we REMOVE the tag instead of adding it.</summary>
  public bool Unset;

  public string Tag { get; }

  public TagAttribute(string tag);
}
