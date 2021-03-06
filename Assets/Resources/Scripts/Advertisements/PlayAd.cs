﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_ADS
using UnityEngine.Advertisements;
#endif

public class PlayAd : MonoBehaviour
{
    public SkillPointManager skillPointManager;
	public void ShowAd()
    {
        #if UNITY_ADS
        if (!Advertisement.IsReady())
        {
            //Debug.Log("Ads not ready for show");
            return;
        }
        Advertisement.Show("rewardedVideo", new ShowOptions(){ resultCallback = HandleAdResult});
        #endif
    }

    public void ShowRewardedAd()
    {
        const string RewardedPlacementId = "rewardedVideo";

        #if UNITY_ADS
        if(!Advertisement.IsReady(RewardedPlacementId))
        {
            //Debug.Log(string.Format("Ads not ready for placement '{0}'", RewardedPlacementId));
            return;
        }

        var options = new ShowOptions { resultCallback = HandleAdResult };
        Advertisement.Show(RewardedPlacementId, options);
        #endif
    }

#if UNITY_ADS
    private void HandleAdResult(ShowResult result)
    {
        skillPointManager = FindObjectOfType<SkillPointManager>();
        switch (result)
        {
            case ShowResult.Finished:
                skillPointManager.CurrentSkillPointValue += 5;
                skillPointManager.skillPointValueText.text = skillPointManager.CurrentSkillPointValue.ToString();
                skillPointManager.skillPointTabTxt.text = skillPointManager.CurrentSkillPointValue.ToString();
                break;
            case ShowResult.Skipped:
                //Debug.Log("Player didn't finish ad");
                break;
            case ShowResult.Failed:
                //Debug.Log("Player failed to launch the ad? Internet? ");
                break;
        }
    }
#endif
}
