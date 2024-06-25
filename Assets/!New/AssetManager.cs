using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;
using UnityEngine.Video;
using Google.Play.AssetDelivery;

public class AssetManager : MonoBehaviour
{
   // public DeliveryType dt;
    public static AssetManager Instance { get; private set; }
    /*
[SerializeReference]
  public AssetReference[] loadableAssets;
  public List<VideoClip> _videoClips = new  List<VideoClip>();
  public bool isLoadingFinished = false;
*/
    private void Awake()
    {
        Instance = this;
       StartCoroutine(LoadAll());
    }

    private IEnumerator LoadAll()
    {
        yield return null;
       /* 
        for (int i = 0; i < loadableAssets.Length; i++)
        {
            AsyncOperationHandle<VideoClip> handle = loadableAssets[i].LoadAssetAsync<VideoClip>();
            yield return handle;
            if (handle.Status == AsyncOperationStatus.Succeeded)
            {
                VideoClip videoClip = handle.Result;
                _videoClips.Add(videoClip);
                Addressables.Release(handle);
            }
        }

        isLoadingFinished = true;*/
    }

    public VideoClip GetVideo(int index)
    {
        return null;
        /*
        if (_videoClips.Count == 0)
            return null;
        return _videoClips[index % _videoClips.Count];
        */
    }
}
