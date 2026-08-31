// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.EnvVar
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Shared.SharedTypes;

/// <summary>An on-demand variable queried and cached by the client, while the server notifies on cache invalidate.
/// Cannot be null.</summary>
public struct EnvVar : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  public string Key;
  public object Value;
  public bool Cache;

  public EnvVar();

  public EnvVar(string key, object value, bool cache);

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();

  public BSONArray ToBson(BsonSerializationContext context);
}
