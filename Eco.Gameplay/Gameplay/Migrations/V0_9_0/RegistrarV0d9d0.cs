// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Migrations.V0_9_0.RegistrarV0d9d0
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Migrations.Attributes;
using Eco.Core.Systems;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Migrations.V0_9_0;

[MigrationType("Eco.Core.Systems.Registrar", SinceVersion = 3.8)]
[MigrationType("Eco.Core.Systems.IHasID", SinceVersion = 3.8, MigrationType = typeof (IHasID))]
public class RegistrarV0d9d0
{
  [Serialized]
  [ForceSerializeFullObject]
  [ThreadSafe]
  public Dictionary<int, IHasID> IdToObj { get; set; }

  public RegistrarV0d9d0();

  public RegistrarV0d9d0(Dictionary<int, IHasID> idToObj);
}
