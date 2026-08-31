// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.PipeEmitterObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Pipes;

[Serialized]
public class PipeEmitterObject : WorldObject
{
  public Ray Ray;

  public override LocString DisplayName { get; }

  public override bool Transient { get; }

  public void Cleanup();

  public void Emit(Item emitItem, int avgFlow);

  public override void Tick();

  public static void EmitParticles(Ray ray, Item emissionItem, int avgFlow, double burstDuration = 0.0);

  public static void RemoveEmitters(Ray ray);

  public static void CleanupEmitters();
}
