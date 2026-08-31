// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.RelatedFeatureAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Controller;

/// <summary>Used to highlight that the class/member is dependant on one of the features and hide/show it from client</summary>
/// <remarks>Note: Name of the feature must be the exactly the same as in Eco.Gameplay.Systems.FeatureConfig</remarks>
public class RelatedFeatureAttribute : Attribute
{
  public string ParameterNameOfFeatureConfig;
  public bool Required;

  /// <summary>Accepts the name of the feature and a bool if it should be required or not required.</summary>
  public RelatedFeatureAttribute(string featureName, bool required = true);
}
