// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.EcoObjectManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System;

#nullable disable
namespace Eco.Gameplay.Objects;

[LocDisplayName("EcoObjectManager")]
public class EcoObjectManager : Singleton<EcoObjectManager>, IServerPlugin
{
  public static void Add(IEcoObject ecoObject);

  public static void Remove(IEcoObject ecoObject);

  public string GetCategory();

  public string GetStatus();

  /// <summary>
  /// Marks Eco object as dirty. This object will be saved in background by StorageManager.
  /// It prevents too often saves for object for often modifications and ensures object will be eventually save latest modifications.
  /// If object isn't thread-safe for concurrent modifications then use <see cref="M:Eco.Gameplay.Objects.EcoObjectManager.Modify``1(``0,System.Action{``0})" /> instead of make direct changes and call <see cref="M:Eco.Gameplay.Objects.EcoObjectManager.MarkAsDirty(Eco.Gameplay.Objects.IEcoObject)" />.
  /// </summary>
  /// <param name="obj">object marked as dirty.</param>
  public static void MarkAsDirty(IEcoObject obj);

  /// <summary>
  /// If Eco object isn't safe for concurrent modifications then instead of using <see cref="M:Eco.Gameplay.Objects.EcoObjectManager.MarkAsDirty(Eco.Gameplay.Objects.IEcoObject)" /> directly make all object modifications inside of modifyAction.
  /// It also marks object as dirty.
  /// It will guarantee object won't be saved during modification and no other concurrent modification will be performed to that object.
  /// </summary>
  /// <param name="obj">object to modify.</param>
  /// <param name="modifyAction">action which modifies object.</param>
  public static void Modify<T>(T obj, Action<T> modifyAction) where T : IEcoObject;

  public override string ToString();
}
