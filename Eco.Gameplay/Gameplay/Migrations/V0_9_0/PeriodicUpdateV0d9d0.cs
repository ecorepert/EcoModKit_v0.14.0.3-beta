// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_0.PeriodicUpdateV0d9d0
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations.Attributes;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Migrations.V0_9_0;

[MigrationType("Eco.Shared.Utils.PeriodicUpdate", SinceVersion = 3.8)]
public class PeriodicUpdateV0d9d0
{
  [Serialized]
  public double Period;

  public PeriodicUpdateV0d9d0(double interval, bool useRealTime = true);
}
