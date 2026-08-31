// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.Transient
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

#nullable disable
namespace Eco.World.Blocks;

/// <summary>
/// Attribute used to mark a block that is nulled out on load, to handle desync issues with other
/// saved data (such as plants or world objects).
/// </summary>
public sealed class Transient : BlockAttribute
{
}
