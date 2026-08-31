// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.SelectionMode
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.SharedTypes;

/// <summary> The selection mode of a target BlockFillView. The hammer will adjust its behaviour based the Selection Mode that it uses. </summary>
public enum SelectionMode
{
  Point,
  Line,
  Rectangle,
  Floor,
  Wall2Point,
  Wall3Point,
  Box2Point,
  Box3Point,
}
