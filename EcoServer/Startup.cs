// Decompiled with JetBrains decompiler
// Type: Eco.Server.Startup
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Server;

internal static class Startup
{
  public static int DisableConsoleClose();

  public static void RestoreConsoleClose(int state);

  public static Task<bool> StartAsync(StartupInfo startupInfo);

  public static Task RunAsync(IHostApplicationLifetime applicationLifetime, StartupInfo startupInfo);

  public static Task StopAsync();
}
