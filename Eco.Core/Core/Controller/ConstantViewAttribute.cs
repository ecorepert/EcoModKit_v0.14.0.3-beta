// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ConstantViewAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Controller;

/// <summary> By applying this attribute to a controller you are assuming that it will never change and its fine to cache at first access and directly send it any future time.
/// It also will pack to the client all related views to ensure that he can refer these views. </summary>
public class ConstantViewAttribute : Attribute
{
}
