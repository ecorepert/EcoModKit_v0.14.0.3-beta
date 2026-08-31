// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ViewMemberInfo
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.Reflection;

#nullable disable
namespace Eco.Shared.View;

/// <summary>Contains data about an individual member (property or method) that is accessible on the server from the client.
/// Its analgous to a MemberInfo reflection class, it communicates to the client the type data on properties of a ViewClassInfo.</summary>
[BsonAutoSerialize]
public struct ViewMemberInfo : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  [BsonSerializeIgnore]
  public MemberInfo MemberInfo;
  [BsonSerializeIgnore]
  public System.Type ViewType;
  [BsonSerializeIgnore]
  public string ViewName;
  public string Name;
  public string DisplayName;
  public int NameID;
  public string TypeName;
  public string UITypeName;
  public string UIListTypeName;
  public string ListTypeName;
  public string GenericParamName;
  public Eco.Shared.Math.Range Range;
  public EcoTextLimit EcoTextLimit;
  public float Sort;
  public ViewMemberFlags ViewFlags;
  public ViewSelectorFlags SelectorFlags;
  public SyncFlags SyncFlags;
  public string Description;
  public string DynamicTitleParam;
  public string RelatedFeatureName;
  public string RelatedFeatureDisabledName;
  public string VisibilityParam;
  public string EnabledParam;
  public int RestrictToDerivedTypeID;
  public string RequiredTag;
  public Color BackgroundColor;

  public ViewClassInfo Type { get; }

  public override string ToString();

  public bool IsList { get; }

  public bool IsSet { get; }

  public bool DerivesType<T>();

  public bool DerivesType(ViewClassInfo type);

  public bool DerivesType(string parent, bool listEntryType);

  public string RelevantTypeName { get; }

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
