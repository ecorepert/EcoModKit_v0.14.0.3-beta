// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Voice.VoicePlayerCluster
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Voice;

public class VoicePlayerCluster
{
  public const float VoiceRadius = 10f;
  public const float PlayerRadius = 20f;
  public readonly List<VoiceChatUser> Users;
  public Vector2 Center;
  public float Radius;

  public void Add(VoiceChatUser vcu);

  public void Combine(VoicePlayerCluster vpc);

  public bool InRange(VoiceChatUser vcu);

  public bool InRange(VoicePlayerCluster vpc);

  public Vector2 GetClosestWrappedPoint(Vector2 source, Vector2 reference);

  public Vector2 GetWrappedPoint(Vector2 source);
}
