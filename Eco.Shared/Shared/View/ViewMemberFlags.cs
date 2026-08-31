// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ViewMemberFlags
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.View;

[Flags]
public enum ViewMemberFlags
{
  None = 0,
  OwnerReadOnly = 1,
  OwnerHidden = 2,
  GuestEditable = 4,
  GuestHidden = 8,
  Autogen = 16, // 0x00000010
  NegativeAllowed = 32, // 0x00000020
  ActiveContractOnly = 64, // 0x00000040
  Reference = 128, // 0x00000080
  ReadOnly = 256, // 0x00000100
  Advanced = 512, // 0x00000200
  LargeUI = 1024, // 0x00000400
  Locked = 2048, // 0x00000800
  AdminEditableOnly = 4096, // 0x00001000
  EnabledByProperty = 8192, // 0x00002000
  AllowCopyPaste = 16384, // 0x00004000
  HideRoot = 65536, // 0x00010000
  ShowFullObject = 262144, // 0x00040000
  HideRootListEntry = 2097152, // 0x00200000
  DontGetContext = 4194304, // 0x00400000
  AnyState = 8388608, // 0x00800000
  HideDescription = 33554432, // 0x02000000
  InheritParentScanProps = 536870912, // 0x20000000
}
