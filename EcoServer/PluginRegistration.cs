// Decompiled with JetBrains decompiler
// Type: Eco.Server.PluginRegistration
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils.Threading;

#nullable disable
namespace Eco.Server;

public class PluginRegistration
{
  public override string ToString();

  public IServerPlugin Plugin { get; set; }

  public int Priority { get; set; }

  public IWorker Worker { get; set; }

  public bool Started { get; set; }
}
