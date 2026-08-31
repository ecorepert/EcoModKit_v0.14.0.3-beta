// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.ConstantHighlightInfo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Networking;
using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Gameplay.Players;

/// <summary>Used for combining Object to highlight and the purpose "marker" to store in main dict of entities to highlight. </summary>
public struct ConstantHighlightInfo : IEquatable<ConstantHighlightInfo>
{
  public INetObjectPosition ObjectToHighLight { get; set; }

  public HighlightPurpose HighlightPurpose { get; set; }

  public override int GetHashCode();

  [CompilerGenerated]
  public override readonly string ToString();

  [CompilerGenerated]
  public static bool operator !=(ConstantHighlightInfo left, ConstantHighlightInfo right);

  [CompilerGenerated]
  public static bool operator ==(ConstantHighlightInfo left, ConstantHighlightInfo right);

  [CompilerGenerated]
  public override readonly bool Equals(object obj);

  [CompilerGenerated]
  public readonly bool Equals(ConstantHighlightInfo other);
}
