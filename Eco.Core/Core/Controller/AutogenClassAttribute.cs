// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.AutogenClassAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.View;

#nullable disable
namespace Eco.Core.Controller;

/// <summary> A class that has its view autogennerated.  Applying this attribute will prevent it from generating a view class in the view autogen file.</summary>
public class AutogenClassAttribute : ViewClassAttribute
{
  public override ViewClassFlags Flags { get; }
}
