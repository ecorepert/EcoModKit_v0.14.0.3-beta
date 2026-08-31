// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Wires.WireInput
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Pipes;
using Eco.Shared.Math;
using System;

#nullable disable
namespace Eco.Gameplay.Wires;

[ForceCreateView]
public class WireInput : WireConnection
{
  public Func<Type, float> CanReceive { get; }

  public WireInput.OnReceiveHandler OnReceive { get; }

  public event Action<Type> OnUpstreamTypeChanged;

  public void RaiseUpstreamTypeChanged(Type newType);

  public Type UpstreamLiquidType { get; }

  protected override Type IdleDisplayType { get; }

  public static float ReceiveSignalOnly(Type itemType);

  public static WireInput CreateSignalInput(WorldObject owner, string name, Action<int> onReceive);

  public static WireInput CreateSignalInput(
    WorldObject owner,
    Ray posDir,
    string name,
    Action<int> onReceive);

  public static WireInput CreatePipeInput(
    WorldObject owner,
    string name,
    Ray posDir,
    Func<Type, float> canReceive,
    WireInput.OnReceiveHandler onReceive);

  public float Receive(PipePayload input);

  public delegate float OnReceiveHandler(PipePayload payload);
}
