using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;


public class AdManager : MonoBehaviour, IUnityAdsListener
{
    public GameObject gatavideo;
    public GameObject video;
    private string MagazinPlayID = "3731293";

    private string SkipAd = "video";
    private string RewardAd = "rewardedVideo";

    public bool TestAd;
    
    void Start()
    {
        Advertisement.AddListener(this);
        StartAds();
    }

    private void StartAds()
    {
        Advertisement.Initialize(MagazinPlayID, TestAd);
    }

    public void PlaySkipAd()
    {
        if (Advertisement.IsReady(SkipAd) == false)
        {
            return;
        }
        Advertisement.Show(SkipAd);
    }

    public void PlayRewardedAd()
    {
        if (Advertisement.IsReady(RewardAd) == false)
        {
            return;
        }
        Advertisement.Show(RewardAd);
        video.SetActive(false); //Nu stiu daca asta
        gatavideo.SetActive(true); // vine aici sau nu dar merge
    }

    public void OnUnityAdsReady(string placementId)
    {

    }
    public void OnUnityAdsDidError(string message)
    {

    }
    public void OnUnityAdsDidStart(string placementId)
    {

    }
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        switch(showResult)
        {
            case ShowResult.Failed:
                break;
            case ShowResult.Skipped:
                Debug.Log("Nu primesti nimic nene");
                break;
            case ShowResult.Finished:
                if(placementId == RewardAd)
                {
                   // video.SetActive(false);
                    //gatavideo.SetActive(true);
                }
                break;
        }
    }


}
