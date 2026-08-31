// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.EcopediaRoot.IEcopediaDynamicPageName
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;

#nullable disable
namespace Eco.Gameplay.EcopediaRoot;

/// <summary>Use this interface when we need to give each instance of the current type has a different ecopedia page name.</summary>
public interface IEcopediaDynamicPageName
{
  /// <summary>The ecopedia page name of the current instance.</summary>
  [ClientInterfaceProperty]
  string PageName { get; }
}
