﻿(function () {
    "use strict";

    /*
     * LICENSE: http://opensource.org/licenses/ms-pl) 
     */

    WinJS.Namespace.define("Common", {
        // Create a unique meetup account for your app, and go to http://www.meetup.com/meetup_api/key/ 
        //    to get your API key
        meetupKey: "[YOUR-DEV-KEY-HERE]",
        // max 100
        meetupDistance: "50",
        maxMeetupsToFind: "200",
        meetupCity: "Seattle",
        meetupState: "WA",
        meetupKeywords: "JavaScript",

        // Bing Maps
        // Create your unique API key at http://www.bingmapsportal.com (Microsoft Account required for log in)
        bingMapsKey: "[YOUR-DEV-KEY-HERE]",

        // sharing info
        shareTitle: "Shared from NearMyMeetup",
        shareMessage: "Check out this great app!"
    });

})()