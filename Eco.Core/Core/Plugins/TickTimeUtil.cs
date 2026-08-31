// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.TickTimeUtil
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Plugins;

public static class TickTimeUtil
{
  public static double TimeSubprocess(Action func);

  public static Task<double> TimeSubprocessAsync(Func<Task> func);
}
