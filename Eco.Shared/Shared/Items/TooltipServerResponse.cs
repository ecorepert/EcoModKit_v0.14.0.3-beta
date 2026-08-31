// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.TooltipServerResponse
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Items;

/// <summary>Packs data server sends to client in response to <see cref="T:Eco.Shared.Items.TooltipServerRequest" /></summary>
[BsonAutoSerialize]
public class TooltipServerResponse : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  /// <summary>If tooltip content can't be generated this error should be displayed as title instead.</summary>
  public LocString ErrorTitle;
  /// <summary>If tooltip content can't be generated this error message should be displayed as tooltip content instead.</summary>
  public LocString ErrorMessage;
  /// <summary>IDs and contents of requested tooltip parts.</summary>
  public List<TooltipPartData> Parts;
  /// <summary></summary>
  public List<TooltipChildrenPartData> ChildrenParts;

  public TooltipServerResponse();

  public TooltipServerResponse(LocString errorTitle, LocString errorMessage);

  public TooltipServerResponse(
    List<TooltipPartData> parts,
    List<TooltipChildrenPartData> childrenParts);

  /// <summary>Returns false if tooltip content couldn't be generated.</summary>
  public bool IsSuccess { get; }

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
