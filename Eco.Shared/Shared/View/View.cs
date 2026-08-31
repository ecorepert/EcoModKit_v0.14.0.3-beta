// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.View
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace Eco.Shared.View;

public class View : IView, IViewController, IObservable
{
  public const 
  #nullable disable
  string ViewRPCName = "ViewRPC";
  public const string SyncedViewRPCName = "SyncedViewRPC";
  public const string AutoSubscribeKey = "a";
  public const string NameKey = "n";
  public const string ValueKey = "v";
  public const string IDKey = "k";
  public const string TypeKey = "t";
  public const string PropertiesKey = "p";
  protected readonly Eco.Shared.View.View.ViewData Data;
  public static Func<Eco.Shared.View.View, string> DescribeView;

  protected View(Eco.Shared.View.View.ViewData data);

  public virtual void Initialize();

  public string TypeName { get; }

  public int ControllerID { get; set; }

  public ViewClassInfo ClassInfo { get; }

  public int ViewTypeID { get; set; }

  /// <summary> Checks if view is holding <paramref name="data" />. </summary>
  public bool HasData(Eco.Shared.View.View.ViewData data);

  public bool HasProperty(string propertyName);

  [Conditional("DEBUG")]
  protected void VerifyPropReceived(string name);

  public override string ToString();

  public bool SubscribeUnique(IPropertySubscription subscription);

  public void Subscribe(IPropertySubscription subscription);

  /// <summary> Removes <paramref name="subscription" /> from <see cref="F:Eco.Shared.View.View.changedCallbacks" />. </summary>
  public void Unsubscribe(IPropertySubscription subscription);

  /// <summary> Notifies all changed callbacks for all properties. Primarily intended for debugging. </summary>
  public void NotifyAll();

  /// <summary>Returns count of property subscriptions. Mostly for debugging purposes.</summary>
  public void DescribeSubscriptions(StringBuilder sb, string propertyName);

  public virtual void NotifyChanged(string propertyName);

  /// <summary>Get a dynamic value by property name, querying both reflection and the list of dynamic properties sent by the server.  Returns
  /// false if the property doesnt exist in either, or if referencing a list, the list index doesn't exist.</summary>
  public bool TryGetValue<T>(string propName, out T retVal, int listIndex = -1);

  public object GetValue(string propName, int listIndex = -1);

  public void UpdateProperty(BSONValue propNameID, BSONObject bson);

  /// <summary>Makes RPC call on the View.</summary>
  public void RPC(string methodname, params object[] args);

  /// <summary>Makes RPC call on the View with callback with no return value. <paramref name="response" /> callback doesn't wait while views changed with RPC synced back to the client, so you may have old View values when callback invoke. If you need to have synced values then use <see cref="M:Eco.Shared.View.View.SyncedRPC(System.String,System.Action,System.Object[])" /> instead.</summary>
  public void RPC(string methodname, Action response, params object[] args);

  /// <summary>Makes RPC call on the View with ensurence that it won't be sent again if server still didn't confirmed previous request. </summary>
  public void ThrottledRPC(string methodname, params object[] args);

  /// <summary>
  /// Makes RPC call on the View with callback with no return value. Callback will be synced with view updates initiated by RPC. I.e. if it changes a property then that property will be synced back to the client before callback invoked.
  /// Should be used when RPC callback expects view changes to be synced on the client. I.e. after SetProperty you want to make some calculations based on value of that property.
  /// <example><code>
  /// view.RPC("SetDateOfBirth", () =&gt; age = DateTime.Today - view.DateOfBirth, date);
  /// </code></example>
  /// When non-synced <c>RPC</c> used there no guarantee that DateOfBirth will have new value just set with RPC, because it synced asynchronously to RPC. It may still have old value (actually in most cases it will have previous value).
  /// </summary>
  public void SyncedRPC(string methodname, Action response, params object[] args);

  /// <summary>Makes RPC call on the View with callback having return value. <paramref name="response" /> callback doesn't wait while views changed with RPC synced back to the client, so you may have old View values when callback invoke. If you need to have synced values then use <see cref="M:Eco.Shared.View.View.SyncedRPC``1(System.String,System.Action{``0},System.Object[])" /> instead.</summary>
  public void RPC<T>(string methodname, Action<T> response, params object[] args);

  /// <summary>
  /// Makes RPC call on the View with callback having return value. Callback will be synced with view updates initiated by RPC. I.e. if it changes a property then that property will be synced back to the client before callback invoked.
  /// See <see cref="M:Eco.Shared.View.View.SyncedRPC(System.String,System.Action,System.Object[])" /> for more details and examples.
  /// </summary>
  public void SyncedRPC<T>(string methodname, Action<T> response, params object[] args);

  /// <summary>Makes RPC call on view with provided <paramref name="viewId" />.</summary>
  public static void ManualRPC<T>(
    string methodname,
    Action<T> response,
    int viewId,
    params object[] args);

  public static void ManualRPC(string methodname, int viewId, params object[] args);

  /// <summary>Check if a property is available (that is, if it needs requesting it has been received).</summary>
  public bool IsAvailable(string propname);

  /// <summary>Check if a property is available (that is, if it needs requesting it has been received).</summary>
  public bool IsAvailable(ViewMemberInfo member);

  /// <summary> Sets <paramref name="field" />'s <see cref="T:Eco.Shared.View.View.ViewData" /> from <paramref name="view" />. We need this method because of accessibility restrictions. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  protected void SetFieldViewData<T>(out T field, Eco.Shared.View.View view) where T : Eco.Shared.View.View.ViewData;

  /// <summary> Exposes access to <see cref="M:Eco.Shared.View.ViewManager.GetOrRecoverView(Eco.Shared.View.View.ViewData)" /> from <see cref="T:Eco.Shared.View.View" /> derived classes. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  protected Eco.Shared.View.View GetOrRecoverView(Eco.Shared.View.View.ViewData viewData);

  /// <summary>
  /// Recovers <see cref="T:Eco.Shared.View.View" /> from <see cref="F:Eco.Shared.View.View.Data" />.
  /// When original <see cref="T:Eco.Shared.View.View" /> was destroyed, but then a reference to it received from the server then it may need to perform some logic to correctly restore <see cref="T:Eco.Shared.View.View" /> from backup <see cref="F:Eco.Shared.View.View.Data" />.
  /// </summary>
  protected internal virtual void Recover();

  /// <summary> Returns View name which may be used for debugging. </summary>
  public string DebugName { get; }

  public class ViewData
  {
    public int ControllerID;
    public int ViewTypeID;

    public bool HasProperty(string propname);

    /// <summary>Get a dynamic value matching the given name, returning false if the property isnt found.</summary>
    public bool TryGetDynamicValue(string propName, out object val);

    public object GetDynamicValue(string propName);

    public bool HasDynamicValue(string propName);

    public void SetDynamicValue(string propName, object value);

    public virtual Eco.Shared.View.View CreateView();
  }

  /// <summary>Helper Property Subscription class for MustRequest properties. It always first in the list of such property subscriptions. And once invoked it marks property as received and auto-removes from subscriptions list.</summary>
  private sealed class MustRequestPropertySubscription : IPropertySubscription, ISubscription
  {
    public IObservable Subject { get; }

    public object Target { get; }

    public MethodInfo Method { get; }

    public string PropertyName { get; }

    public bool IsAlive { get; }

    public MustRequestPropertySubscription(Eco.Shared.View.View view, string propertyName);

    public void Unsubscribe();

    public void Invoke();
  }
}
