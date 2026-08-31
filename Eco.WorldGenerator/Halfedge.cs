// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.Halfedge
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

#nullable disable
namespace Eco.WorldGenerator;

internal class Halfedge
{
  public Halfedge ELleft;
  public Halfedge ELright;
  public Edge ELedge;
  public bool Deleted;
  public int ELpm;
  public Site Vertex;
  public double YStar;
  public Halfedge PQnext;
}
