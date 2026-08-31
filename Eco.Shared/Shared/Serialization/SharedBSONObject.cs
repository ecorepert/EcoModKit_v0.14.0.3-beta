// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.SharedBSONObject
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Serialization;

/// <summary>
/// Use this object if you have to share bson object.
/// I.e. Player.animationData stored as shared object and then delivered to all clients.
/// It keeps tracking of all object references and only recycle object when all references recycled.
/// </summary>
public sealed class SharedBSONObject : IDisposable
{
  public void StartSharing(BSONObject value, bool addRef);

  public void StopSharing();

  public bool TryGetRef(out BSONObject value);

  public void Dispose();
}
