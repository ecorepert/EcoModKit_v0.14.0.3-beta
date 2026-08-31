// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.PropertyHandling.PropertyChangedNotificationInterceptor
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Gameplay.PropertyHandling;

/// <summary>Fody global interceptor for all notified property changes (unless custom OnPropertyChanged method implemented).</summary>
public static class PropertyChangedNotificationInterceptor
{
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Intercept(
    INotifyPropertyChangedInvoker invoker,
    string propertyName,
    object? before,
    object? after);
}
