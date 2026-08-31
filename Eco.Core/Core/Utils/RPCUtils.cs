// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.RPCUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Systems;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Core.Utils;

public static class RPCUtils
{
  public static LocString RPCClick(LocString linktext, IHasSerializableID obj, string rpcName);

  public static LocString RPCClick(
    LocString linktext,
    IHasSerializableID obj,
    string rpcName,
    string param);

  public static LocString RPCClickNeverSerialized(
    LocString linktext,
    IHasUniversalID obj,
    string rpcName);

  public static LocString RPCClickNeverSerialized(
    LocString linktext,
    IHasUniversalID obj,
    string rpcName,
    string param);

  /// <summary>RPC foldout is like a foldout list, but the contents are sent from the server, by the client calling the given RPC on the given view.</summary>
  public static LocString RPCFoldout(LocString linktext, IHasSerializableID obj, string rpcName);

  public static LocString RPCFoldout(
    LocString linktext,
    IHasSerializableID obj,
    string rpcName,
    string param);

  /// <summary>An RPC foldout which the caller guarantees will never be serialized.  Allows us to create RPC calls to something with a transient ID.  This is useful in things like tooltip text
  /// where there's no change the text will be serialized.</summary>
  public static LocString RPCFoldoutNeverSerialized(
    LocString linktext,
    IHasUniversalID obj,
    string rpcName);

  public static LocString RPCFoldoutNeverSerialized(
    LocString linktext,
    IHasUniversalID obj,
    string rpcName,
    string param);

  public static LocString RPCFoldoutLoc(
    FormattableString linktext,
    IHasSerializableID obj,
    string rpcName);

  public static LocString RPCFoldoutLocStr(string linktext, IHasSerializableID obj, string rpcName);

  public static LocString RPCFoldoutNeverSerializedLoc(
    FormattableString linktext,
    IHasUniversalID obj,
    string rpcName);

  public static LocString RPCFoldoutNeverSerializedLocStr(
    string linktext,
    IHasUniversalID obj,
    string rpcName);

  public static LocString RPCFoldoutNeverSerializedLocStr(
    string linktext,
    IHasUniversalID obj,
    string rpcName,
    string param);
}
