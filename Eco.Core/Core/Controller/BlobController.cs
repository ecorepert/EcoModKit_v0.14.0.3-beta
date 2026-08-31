// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.BlobController
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Core.Controller;

/// <summary> The whole point of this class is to avoid sending same heavy data. Currently its used to avoid sending repeated strings and LocStrings that are ofter sent several times.
/// Instead of sending same string again and again, it will save it as a byte[] and send just an id of that byte array. This way there are will be no need to send same data twice. </summary>
public static class BlobController
{
  public static bool TryGetOrCreateBlob(
    in BsonSerializationContext context,
    object value,
    out int blobId);

  /// <summary> Creates a pair (NameId,Value) </summary>
  internal static BSONObject PackageValue(
    in BsonSerializationContext context,
    object value,
    int nameID,
    bool clientShouldCacheIt,
    ControllerPacker.ControllerPackingPendingViews pendingData);

  public static byte[] GetBlob(int id);
}
