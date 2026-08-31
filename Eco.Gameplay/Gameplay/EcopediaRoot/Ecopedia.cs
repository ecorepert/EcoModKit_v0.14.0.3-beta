// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.EcopediaRoot.Ecopedia
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Icons;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.EcopediaRoot;

public class Ecopedia : 
  Singleton<
  #nullable disable
  Ecopedia>,
  IController,
  IViewController,
  IHasUniversalID,
  IHasRequiredIcons
{
  public static Dictionary<Type, EcopediaPage> TypeToPage;

  [SyncToView(null, true)]
  public Dictionary<string, EcopediaChapter> Chapters { get; set; }

  [SyncToView(null, true)]
  public Dictionary<string, EcopediaCategory> Categories { get; set; }

  [SyncToView(null, true)]
  public int RuntimeEcopediaVersion { get; set; }

  public ref int ControllerID { get; }

  public void ShowPage(Player player, Type type);

  public void ShowPage(Player player, EcopediaPage page);

  public EcopediaPage GetPage(string name);

  public bool HasPage(Type type);

  public IEnumerable<IEcopediaTab> AllTabs();

  public void OnEcopediaRebuild();

  public static IEnumerable<(string Name, string Comment)> GetRequiredIcons();
}
