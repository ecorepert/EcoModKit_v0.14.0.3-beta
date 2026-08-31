// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.PipePayload
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using System;

#nullable disable
namespace Eco.Gameplay.Pipes;

public readonly ref struct PipePayload
{
  public readonly Type ItemType;
  public readonly float Amount;
  public readonly float Time;

  public Item Item { get; }

  public PipePayload WithAmount(float amount);

  public static PipePayload Signal(float level);

  public PipePayload(Type itemType, float amount, float time);
}
