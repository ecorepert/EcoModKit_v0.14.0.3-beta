// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.EcoTextLimitAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary> Limit the strings to a certain range, based on the text type </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class EcoTextLimitAttribute : Attribute
{
  public EcoTextLimit Range;

  public EcoTextLimitAttribute(int min, int max, int maxWithTags);

  public EcoTextLimitAttribute(
    EcoTextLimitAttribute.TextRangeStyle textRangeStyle);

  public enum TextRangeStyle
  {
    Title,
    ConstitutionName,
    CivicArticleName,
    ChatTitle,
    ChannelName,
    LongText,
  }
}
