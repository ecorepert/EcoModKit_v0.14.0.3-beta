// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.PropertyValues.IHasDynamicHomeFurnishingValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Housing.PropertyValues;

/// <summary>World objects can implement this interface to define an additional component that will be calulated to determine home furnishing value
/// when evaluating property value.  This is used of things like PictureFrames which can hold artwork of dynamic value.</summary>
public interface IHasDynamicHomeFurnishingValue
{
  /// <summary>Returns the dynamic value</summary>
  float DynamicFurnishingValue { get; }

  /// <summary>How to describe the dynamic value in tooltips etc</summary>
  LocString DynamicFurnishingTitle { get; }

  /// <summary>If a unique object is defined, then it will test uniqueness based on this dynamic trait instead of repetitions of the same type (ie, the artist of the painting is the
  /// unique factor for picture frames, making repeated paintings from the same artist reduce in value compared to different artists).</summary>
  object UniqueObject { get; }

  /// <summary>What the type of the unique object is, described for tooltips and such.</summary>
  LocString UniqueObjectName { get; }
}
