﻿using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace surfm.tool.ad {
    public class Admober : MonoBehaviour {

        public static void requestBanner() {
            string adUnitId = AdConfig.getInstance().getAdmobKey();
            // Create a 320x50 banner at the top of the screen.
            BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
            // Create an empty ad request.
            AdRequest request = new AdRequest.Builder().Build();
            // Load the banner with the request.
            bannerView.LoadAd(request);
        }

    }
}
