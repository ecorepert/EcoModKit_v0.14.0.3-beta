// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ViewClassInfo
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.View;

/// <summary>Represents the 'type' data about a server type, something which is also represented as a view. The server builds these
/// viewclassinfos and sends them to the client, which can then use them for many purposes.  Any information about a type can be transmitted
/// from server to client on this class.</summary>
[BsonAutoSerialize]
public class ViewClassInfo : IBsonSerializable, IBsonSerialize, IBsonDeserializable
{
  [BsonSerializeIgnore]
  public 
  #nullable disable
  Type Type;
  public int TypeID;
  public int BaseTypeID;
  /// <summary>Name of the client side type (IE: "UserView")</summary>
  public string Name;
  /// <summary>Name of the server side type (IE: "User")</summary>
  public string ServerName;
  public LocString DisplayName;
  public LocString DisplayNamePlural;
  public string BaseTypeName;
  public string[] Interfaces;
  public string UITypeName;
  public LocString Description;
  public LocString MarkedUpName;
  public string CategoryName;
  public string RelatedFeatureName;
  public string RelatedFeatureDisabledName;
  public ViewClassFlags ClassFlags;
  public List<ViewRPC> RPCs;
  public string[] EnumNames;
  public LocString[] EnumDescriptions;
  public HashSet<string> Tags;
  public string EcopediaCategory;
  public string EcopediaPage;
  public string EcopediaSubPageOrPage;
  public string IconName;
  public int Priority;
  public string ComponentTabName;
  /// <summary>Data about each member of this type, transmitted from server to client.</summary>
  public Dictionary<string, ViewMemberInfo> Members;

  public override string ToString();

  public bool HasMember(string name);

  public ViewMemberInfo GetMemberInfo(string name);

  public bool IsEnum { get; }

  public bool HasTag(string tag);

  public bool DerivesType(string parent, bool checkReverseToo = false);

  /// <summary>Returns the viewclassinfo of ourself and each parent</summary>
  public IEnumerable<ViewClassInfo> SelfAndParentTypes();

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
