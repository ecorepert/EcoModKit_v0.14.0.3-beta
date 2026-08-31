// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.TagManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Icons;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>Create tags into the tag registrar, using ones that exist already (to preserve ID's)
/// and creating new ones as needed (perhaps a mod gets added)</summary>
[Serialized]
public class TagManager : IHasRequiredIcons
{
  public static 
  #nullable disable
  Dictionary<Type, HashSet<Eco.Gameplay.Items.Tag>> TypeToTags;
  public static Dictionary<Eco.Gameplay.Items.Tag, HashSet<Type>> TagToTypes;

  public static Eco.Gameplay.Items.Tag Tag(string name);

  public static IEnumerable<Eco.Gameplay.Items.Tag> AllTags { get; }

  public void InitializeRegistrars();

  public static Eco.Gameplay.Items.Tag GetTagOrFail(string name);

  /// <summary>Creates a tag with the given name (or returns existing one if already created)</summary>
  public static Eco.Gameplay.Items.Tag GetOrMake(string name);

  /// <summary>Registers <paramref name="type" /> under the named tag at runtime. For tags populated programmatically rather than via [Tag] attributes (e.g. the Garbage tag built from the GarbageMaterial registry).</summary>
  public static void AddTypeToTag(string tagName, Type type);

  public static void Initialize();

  public static void SetupRecipes();

  public static IEnumerable<(string Name, string Comment)> GetRequiredIcons();

  public static string IconsCategoryName { get; }
}
