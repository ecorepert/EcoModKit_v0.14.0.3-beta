// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.PropertyScanning.ICustomValidity
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Core.Utils.PropertyScanning;

public interface ICustomValidity : IValidity
{
  /// <summary>If true, only the implementing objects Validity will be checked. If false, all properties will be validated and report added to result (default behavior).
  /// Is used in Demographics to ignore validity of props for Special Demographics as they are statically set up and cannot change.</summary>
  bool SkipPropertyValidation { get; }

  Result Valid();
}
