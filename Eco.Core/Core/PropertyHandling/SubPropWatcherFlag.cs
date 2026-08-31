// Decompiled with JetBrains decompiler
// Type: Eco.Core.PropertyHandling.SubPropWatcherFlag
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.PropertyHandling;

[Flags]
public enum SubPropWatcherFlag
{
  None = 0,
  DontTriggerWhenRootPropSetToNull = 1,
}
