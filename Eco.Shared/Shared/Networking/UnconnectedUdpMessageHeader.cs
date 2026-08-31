// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.UnconnectedUdpMessageHeader
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Eco.Shared.Networking;

[StructLayout(LayoutKind.Explicit, Size = 5)]
public ref struct UnconnectedUdpMessageHeader
{
  private const int MaxLengthInBits = 65535 /*0xFFFF*/;
  public const int HeaderSize = 5;
  [FieldOffset(0)]
  public readonly uint Dword;
  [FieldOffset(0)]
  public readonly byte MessageType;
  [FieldOffset(1)]
  public readonly byte SegmentIndex;
  [FieldOffset(2)]
  public readonly byte SegmentCount;
  [FieldOffset(3)]
  public readonly byte LengthInBitsLow;
  [FieldOffset(4)]
  public readonly byte LengthInBitsHigh;

  public int LengthInBits { get; }

  public UnconnectedUdpMessageHeader(int lengthInBits);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool HasUnconnectedMessageDataHeader(IntPtr data, int length);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool HasUnconnectedMessageDataHeader(byte[] buffer, int offset, int length);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void WriteTo(byte[] buffer, int offset, int length);
}
