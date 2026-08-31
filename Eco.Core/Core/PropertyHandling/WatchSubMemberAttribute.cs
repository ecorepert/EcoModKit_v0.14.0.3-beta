// Decompiled with JetBrains decompiler
// Type: Eco.Core.PropertyHandling.WatchSubMemberAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.PropertyHandling.Internal;
using System;
using System.Reflection;

#nullable enable
namespace Eco.Core.PropertyHandling;

/// <summary>When put on a property, will create subscriptions watching a given sub-property to change, and trigger the corresponding method or event.</summary>
/// 
///             IE, CreditComponent has a property containing a BankAccount and it uses this attribute to call one of its own methods whenever MarkedUpName is changed.
///             This attribute will both:
///             - Watch when the BankAccount's property 'MarkedUpName' changes and trigger the callback
///             - Watch when the BankAccount property itself changes, and update remove the subscription to the old BankAccount.MarkedUpName, and add a subscription
///               to the new BankAccount.MarkedUpName.  Will also call the callback in this case.
///             Either way declaring class should implement <see cref="T:System.ComponentModel.INotifyPropertyChanged" />
///  and <see cref="T:Eco.Core.PropertyHandling.INotifyPropertyChangedInvoker" />
///  (usually auto-implemented by Fody).
///             See wiki guide here: https://github.com/StrangeLoopGames/Eco/wiki/Watching-System
///             <remarks>
/// Declaring class must implement INotifyPropertyChanged, so that it can watch when the prop changes.
/// Declaring class must also implement ISubscriptions, allowing this service to property track subscriptions when they are made and remove them upon destroy.
/// </remarks>
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class WatchSubMemberAttribute : WatchBaseAttribute
{
  /// <summary>The name of the method on 'this' that we want to call. Can be either an event or a method.</summary>
  public readonly string Callback;
  /// <summary>Flags customizing behavior of this attribute.</summary>
  public readonly SubPropWatcherFlag Flags;

  /// <summary>When true callback won't be called when root property is set to null.</summary>
  /// <remarks>This flag can only be used when callback expects to receive new value of sub property as parameter and sub proeprty is of value type
  /// (so null can't be passed) and is mandatory in such cases to explicitly show that different behavior for value types will be used.</remarks>
  public bool DontTriggerWhenRootPropSetToNull { get; }

  /// <summary>Whenever the given sub property is changed/triggered, call the given callback.</summary>
  public WatchSubMemberAttribute(string subPropName, string callback, SubPropWatcherFlag flags = SubPropWatcherFlag.None);

  public WatchSubMemberAttribute(
    Type rootType,
    string subPropName,
    string callback,
    SubPropWatcherFlag flags = SubPropWatcherFlag.None);

  public WatchSubMemberAttribute(
    string subPropName,
    string callback,
    Type memberTypeMustDerive,
    SubPropWatcherFlag flags = SubPropWatcherFlag.None);

  public WatchSubMemberAttribute(bool watchAllSubProps, string callback);

  /// <summary>Returns callback delegate based on the value of Callback field.</summary>
  /// <param name="memberWithAttribute">Member to which this attribute is applied.</param>
  /// <param name="expectedCallbackParam">Type of expected callback parameter if any.</param>
  public override PropertyChangedBeforeAfterEventHandler GetCallback(
    MemberInfo memberWithAttribute,
    out Type? expectedCallbackParam);
}
