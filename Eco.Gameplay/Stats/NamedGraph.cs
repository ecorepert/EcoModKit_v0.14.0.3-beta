// Decompiled with JetBrains decompiler
// Type: Eco.Stats.NamedGraph
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Stats;

public class NamedGraph
{
  public NamedGraph(LocString category, LocString name, Graph graph);

  public LocString Category { get; set; }

  public LocString Name { get; set; }

  public Graph Graph { get; set; }
}
