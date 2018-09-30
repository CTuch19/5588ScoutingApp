using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace _5588ScoutingApp
{
    
    class TabController : UITabBarController
    {
        UIViewController scheduleTab, pitTab, fieldTab;

        public TabController()
        {
            scheduleTab = new UIViewController();
            scheduleTab.Title = "Matches";
            scheduleTab.View.BackgroundColor = UIColor.Blue;

            pitTab = new UIViewController();
            pitTab.Title = "Pits";
            pitTab.View.BackgroundColor = UIColor.Red;

            fieldTab = new UIViewController();
            fieldTab.Title = "Field";
            fieldTab.View.BackgroundColor = UIColor.Purple;

            var tabs = new UIViewController[]{
                scheduleTab, pitTab, fieldTab
            };

            ViewControllers = tabs;
        }
    }
}