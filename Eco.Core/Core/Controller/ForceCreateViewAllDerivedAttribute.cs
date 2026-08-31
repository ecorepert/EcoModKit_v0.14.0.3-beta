// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ForceCreateViewAllDerivedAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Controller;

/// <summary> Tag for the view system to create a view even if there are no synctoview properties in the class, affects all derived classes too. </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class ForceCreateViewAllDerivedAttribute : Attribute
{
}
