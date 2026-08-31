// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.ViewManager
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Text;
using Eco.Shared.Time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

#nullable enable
namespace Eco.Shared.View;

/// <summary> Manages Views on client. Read more details about View System in ViewSystem.md. </summary>
public static class ViewManager
{
  public static 
  #nullable disable
  ViewManager.IDataCache DataCache;
  public static Dictionary<int, ViewClassInfo> IdToViewClassInfo;
  public static Dictionary<string, ViewClassInfo> NameToViewClassInfo;
  public static Dictionary<int, byte[]> DataBlobs;

  public static INetObject Client { get; }

  public static event Action ViewDataReceivedEvent;

  public static ViewClassInfo GetViewClassInfo(int id);

  public static ViewClassInfo GetViewClassInfo(string name);

  public static Dictionary<int, PropertyInfo> GetProperties(int typeID);

  public static Type GetTypeFromID(int id);

  public static IEnumerable<ViewClassInfo> DerivedTypes(int typeID);

  public static bool TryGetTypeFromID(int id, out Type type);

  /// <summary>Returns all the derived types for the given type id.</summary>
  public static IEnumerable<ViewClassInfo> DerivedTypesRecursive(int typeID, bool includeObject);

  public static void AddError(string error);

  public static string GetAndClearErrors();

  public static void Initialize(IEnumerable<Assembly> assemblies, ViewManager.IDataCache cache = null);

  public static void Clear();

  public static void BindController(INetObject controller);

  public static void ReceiveViewData(BSONObject data);

  public static BSONObject PackageView(object view, in BsonSerializationContext context);

  [ClientAPI]
  public static T UnpackageView<T>(this BSONValue bson) where T : Eco.Shared.View.View;

  [ClientAPI]
  public static Eco.Shared.View.View UnpackageView(this BSONValue bson);

  [ClientAPI]
  public static void UnpackageViews(BSONArray data);

  [ClientAPI]
  public static void UnpackageBlobs(BSONArray data);

  public static void ReceiveViewUpdate(BSONArray updates);

  /// <summary>Processes a single view update from a client update packet. Callers processing a batch incrementally must call <see cref="M:Eco.Shared.View.ViewManager.RaiseViewUpdateNotifications" /> once done or interrupted.</summary>
  public static void ReceiveSingleViewUpdate(BSONObject updateBson);

  /// <summary>Raises change notifications for any views successfully updated so far.</summary>
  public static void RaiseViewUpdateNotifications();

  /// <summary>Returns the view with the given ID if we have it, otherwise null.</summary>
  public static Eco.Shared.View.View GetView(int viewID);

  public static T GetView<T>(int viewID) where T : Eco.Shared.View.View;

  /// <summary>Try get <see cref="T:Eco.Shared.View.View" /> by id. It may not return view if it wasn't received or already released (has no active ref).</summary>
  public static bool TryGetView(int viewId, out Eco.Shared.View.View view);

  public static void ReleaseUnusedViews(TimeLimit timeLimit);

  /// <summary> Collect stats about existing views in <see cref="T:Eco.Shared.View.ViewManager" />. May be used for statistic and leaks detection. </summary>
  public static IEnumerable<IGrouping<string, Eco.Shared.View.View.ViewData>> CollectViewStats();

  /// <summary>Collects all invalid subscriptions. Invalid subscription is a <see cref="T:Eco.Shared.View.IPropertySubscription" /> which has <c>null</c> or destroyed target for an instance method (it is always <c>null</c> for static methods).</summary>
  public static IEnumerable<IPropertySubscription> CollectInvalidSubscriptions();

  /// <summary> Traces existing views for references to view with specified <paramref name="viewId" />. It helps to debug why some view was added to the client and why it wasn't GC. </summary>
  public static string TraceViewRefs(int viewId);

  /// <summary> Returns <see cref="T:Eco.Shared.Text.InfoBuilder" /> with traces for <paramref name="n" /> views of <paramref name="viewType" /> type (see <see cref="M:Eco.Shared.View.ViewManager.TraceViewRefs(System.Int32)" />). Optionally it can skip firt <paramref name="skipN" /> elements. </summary>
  public static InfoBuilder SampleViewTraces(string viewType, int n, int skipN = 0);

  public static void LogError(string s);

  /// <summary> Notifies all views about all subscribed properties changes. NOT INTENDED FOR PRODUCTION USAGE. ONLY FOR DEBUGGING! </summary>
  public static void NotifyAllViews();

  public interface IDataCache
  {
    byte[] GetByHash(string hash);

    void SaveInCache(byte[] data);

    bool ContainsHash(string hash);
  }

  private struct ViewNotification
  {
    public Eco.Shared.View.View View;
    public int NameID;
  }
}
