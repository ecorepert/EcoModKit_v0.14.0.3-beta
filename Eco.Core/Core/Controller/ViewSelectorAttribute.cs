// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.ViewSelectorAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Core.Controller;

/// <summary> Additional set of flags since <see cref="T:Eco.Core.Controller.ViewMemberAttribute" /> doesn't have much free space. </summary>
public abstract class ViewSelectorAttribute : Attribute
{
  public abstract ViewSelectorFlags Flags { get; }
}
