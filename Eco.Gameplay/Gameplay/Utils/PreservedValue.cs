// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.PreservedValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Serialization;
using System.Text;

#nullable disable
namespace Eco.Gameplay.Utils;

[Serialized]
public class PreservedValue
{
  [Serialized]
  public float Real { get; protected set; }

  [Serialized]
  public float Preserved { get; protected set; }

  [Serialized]
  public double PreservedTill { get; protected set; }

  public ThreadSafeAction OnValueChanged { get; protected set; }

  public PreservedValue.ValueRequester PreserveSecondsGetter { get; protected set; }

  public double PreseveSeconds { get; }

  public bool PreservationExpired { get; }

  public bool IsPreserving { get; }

  public float Get { get; }

  public void Set(float value);

  public void Initialize(PreservedValue.ValueRequester preserveSeconds);

  public bool TryAddPreservationWarning(StringBuilder sb);

  public void UnsubscribeAll();

  public void RemoveReductionRequest();

  public delegate double ValueRequester();
}
