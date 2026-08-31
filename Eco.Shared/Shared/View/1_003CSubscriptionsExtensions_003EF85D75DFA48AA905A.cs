// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.<SubscriptionsExtensions>F85D75DFA48AA905A0DC9AC02A35A0CCB79674C11A1D7C0FD1611F83E8F22160C__PropertySubjectSubscriptionFilter
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Utils;

#nullable enable
namespace Eco.Shared.View;

internal readonly struct \u003CSubscriptionsExtensions\u003EF85D75DFA48AA905A0DC9AC02A35A0CCB79674C11A1D7C0FD1611F83E8F22160C__PropertySubjectSubscriptionFilter : 
  IPredicate<ISubscription>
{
  private readonly IObservable? subject;

  public \u003CSubscriptionsExtensions\u003EF85D75DFA48AA905A0DC9AC02A35A0CCB79674C11A1D7C0FD1611F83E8F22160C__PropertySubjectSubscriptionFilter(
    IObservable? subject);

  public bool Match(ISubscription item);
}
