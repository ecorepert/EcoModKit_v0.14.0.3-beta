// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Services.VisibleForQAOnlyAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Services;

/// <summary> attribute for making plugin properties visible when QA enabled </summary>
/// 
///             used mainly for testing, allowing to display/interect with props otherwise hidden
///             e.g.: expose ChinaLockedMode prop for QA
public class VisibleForQAOnlyAttribute : Attribute
{
}
