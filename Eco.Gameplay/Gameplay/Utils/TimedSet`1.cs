// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.TimedSet`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Utils;

[Serialized]
public class TimedSet<T> where T : IHasID
{
  [Serialized]
  public ControllerHashSet<T> Set { get; set; }

  public void Initialize();

  public double GetTime(T t);
}
