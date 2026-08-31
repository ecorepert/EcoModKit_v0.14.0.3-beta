// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.RPCLog.RPCLogger
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System.Text;

#nullable disable
namespace Eco.Simulation.RPCLog;

[Localized(false, true, "", false)]
public sealed class RPCLogger : Singleton<RPCLogger>, IServerPlugin
{
  public StringBuilder Strs;

  public static void AddString(string clientId, string methodName, string args, bool isSent);

  public string GetCategory();

  public override string ToString();

  string IServerPlugin.GetStatus();
}
