// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.ClassSerializer`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

#nullable disable
namespace Eco.Core.Serialization.Serializers;

public class ClassSerializer<T> : ClassSerializer, IInitializableSerializer, ISerializer
{
  public override object NewInstance { get; }

  public ClassSerializer(SimpleSerializer parent);

  public virtual void Initialize();

  protected void DecodeMember(MemberInfo member, ref object instance, BinaryReader reader);

  internal override void DecodeToInstance(ref object instance, BinaryReader reader);

  protected void OnDecodeComplete(object instance);

  protected internal override void EncodeInstance(
    BinaryWriter writer,
    object instance,
    SerializeFlags flags);

  protected IEnumerable<PropertyInfo> GetProperties(Type type);

  protected IEnumerable<FieldInfo> GetFields(Type type);

  protected IEnumerable<MethodInfo> GetMethodsToCallAfterSerialize(Type type, bool postAllLoading);
}
