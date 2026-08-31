// Decompiled with JetBrains decompiler
// Type: Eco.Server.ApplicationHostedService
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Server;

public class ApplicationHostedService : IHostedService
{
  public ApplicationHostedService(
  #nullable disable
  IHostApplicationLifetime hostApplicationLifetime);

  public Task StartAsync(CancellationToken cancellationToken);

  public Task StopAsync(CancellationToken cancellationToken);
}
