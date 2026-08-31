// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.DebugStatistic
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.DebugStatistic;

public class DebugStatistic
{
  public string Name { get; }

  public DebugStatistic(string name, int size);

  public Eco.Core.DebugStatistic.DebugStatistic.Entry StartEntry();

  public void AddTime(double milliseconds);

  public double Average();

  public int Count { get; }

  public override string ToString();

  public struct Entry
  {
    private readonly Eco.Core.DebugStatistic.DebugStatistic statistic;
    private readonly double startTime;

    public Entry(Eco.Core.DebugStatistic.DebugStatistic statistic);

    public void Finish();
  }
}
