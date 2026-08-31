// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ClientControllerExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Networking;
using System.Reflection;

#nullable disable
namespace Eco.Core.Utils;

public static class ClientControllerExtensions
{
  public static object AddNew(this IClientControlledContainer container, PropertyInfo property = null);

  public static object Add(
    this IClientControlledContainer container,
    INetObject caller,
    PropertyInfo property = null);

  /// <summary>An extension that allows ClientControlledContainers to be told to delete stuff by the client.</summary>
  public static Result Remove(
    this IClientControlledContainer container,
    INetObject caller,
    object entry,
    PropertyInfo property = null);

  /// <summary>An extension that allows ClientControlledContainers to be told to remove an index by the client.</summary>
  public static Result RemoveAt(
    IClientControlledList container,
    INetObject caller,
    int index,
    PropertyInfo property = null);

  public static void Move(
    IClientControlledList container,
    INetObject caller,
    int oldIndex,
    int newIndex,
    PropertyInfo property = null);

  public static void SetAt(
    IClientControlledList container,
    INetObject caller,
    int index,
    object entry,
    PropertyInfo property = null);
}
