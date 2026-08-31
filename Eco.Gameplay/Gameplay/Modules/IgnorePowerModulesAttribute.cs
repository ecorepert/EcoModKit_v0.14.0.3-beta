// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.IgnorePowerModulesAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Modules;

/// <summary>Apply to a world object whose power type must never be changed by installed modules (for example a campfire stays fuel-fired and can't be electrified). The designer decides which objects get this.</summary>
[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public class IgnorePowerModulesAttribute : Attribute
{
}
