// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ViewClassFlags
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.View;

[Flags]
public enum ViewClassFlags
{
  Autogen = 1,
  Abstract = 2,
  CreateComponentTab = 4,
  HasIcon = 8,
  NoStats = 16, // 0x00000010
  ActiveWhenDisabled = 32, // 0x00000020
}
