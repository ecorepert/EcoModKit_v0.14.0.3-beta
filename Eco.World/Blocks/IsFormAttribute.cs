// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.IsFormAttribute
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using System;

#nullable enable
namespace Eco.World.Blocks;

public sealed class IsFormAttribute : BlockAttribute
{
  /// <summary> FormType for form, eg typeof(WallFormType), typeof(FloorFormType), typeof(RoofFormType). </summary>
  public Type FormType { get; }

  /// <summary> The item type this form can be created from. </summary>
  public Type MaterialType { get; }

  public IsFormAttribute(Type formType, Type materialType);
}
