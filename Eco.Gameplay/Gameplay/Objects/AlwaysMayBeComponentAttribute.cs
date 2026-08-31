// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.AlwaysMayBeComponentAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Objects;

/// <summary>Put this tag on components that are always allowed to be on objects (they wont be removed automatically)</summary>
[AttributeUsage(AttributeTargets.Class)]
public class AlwaysMayBeComponentAttribute : Attribute
{
}
