// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.ModContentUploadController
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Eco.Shared.Networking;
using System.Threading.Tasks;

#nullable enable
namespace Eco.ModKit;

/// <summary> Responsible for controlling upload requests to avoid overwhelming network, the way it does it now is that it assumes that each client can have only 1 mod to download at a time. </summary>
public sealed class ModContentUploadController
{
  public ModContentUploadController(int maxCount);

  /// <summary> Wait for the upload semaphore if needed. </summary>
  public 
  #nullable disable
  Task WaitForSemaphoreAsync();

  /// <summary> Send the given rpc for uploading the file and the bytes length is used to calculate the correct time out. Returns whether the upload completed. </summary>
  public Task<bool> SendRpcAndWaitUpload(int bytesLength, RPCEvent rpcToSend);

  /// <summary> Wait for upload or timeout if needed, returns true if the file is uploaded. A timed-out send is abandoned (never awaited to
  /// completion: a stalled reliable send may never finish, and blocking on it froze the whole per-client content stream). </summary>
  public Task<bool> WaitForTaskOrTimeOut(int timeoutInSeconds, Task sendTask);
}
