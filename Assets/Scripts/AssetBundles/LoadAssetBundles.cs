using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundles : MonoBehaviour
{   
    public string bundleName;
    public AudioSource music;

    [System.Obsolete]
    public void Start()
    {
        StartCoroutine(Go());
    }

    [System.Obsolete]
    IEnumerator Go()
    {
        using (WWW send = WWW.LoadFromCacheOrDownload(@"AssetBundles/content/" + bundleName, 0))
        {

            yield return send;

            if (!string.IsNullOrEmpty(send.error))
            {
                Debug.Log(send.error);
                yield break;
            }
            Debug.Log("Bundles загружен");
            var assetBundles = send.assetBundle;
            string musicName = "guard.mp3";
            string imageName = "Basketball.gif";

            var musicRecuest = assetBundles.LoadAssetAsync(musicName, typeof(AudioClip));
            yield return musicRecuest;
            Debug.Log("Music");
            var imageRecuest = assetBundles.LoadAssetAsync(imageName, typeof(AudioClip));
            yield return imageRecuest;
            Debug.Log("Image");

            music.clip = musicRecuest.asset as AudioClip;
            music.Play();
        }
    }

}
