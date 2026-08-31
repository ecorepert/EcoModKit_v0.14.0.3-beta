// Decompiled with JetBrains decompiler
// Type: Eco.Server.UI.Controls.PluginCategoryPage
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using Eco.Core.Plugins.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Server.UI.Controls;

internal class PluginCategoryPage : IDisposable
{
  public readonly string CategoryName;
  public readonly EcoTabPage CategoryPage;
  public readonly EcoVerticalTabControl CategoryOptions;
  public readonly Dictionary<int, IServerPlugin> OptionToPlugin;

  public IServerPlugin ActiveServerPlugin { get; }

  public PluginCategoryPage(string categoryName);

  public EcoTabPage CreatePluginOption(IServerPlugin plugin);

  public void Dispose();
}
