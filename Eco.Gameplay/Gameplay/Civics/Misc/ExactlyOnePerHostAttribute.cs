// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.ExactlyOnePerHostAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Civics.Misc;

/// <summary>
/// Put this tag on a civic object to say that when there are orphans of this type, we should make sure that the player chooses exacly one of them to set on the host object.
/// This is usually used with classes that implement the <see cref="T:Eco.Gameplay.Placement.IHostedObject" /> interface.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class ExactlyOnePerHostAttribute : Attribute
{
}
