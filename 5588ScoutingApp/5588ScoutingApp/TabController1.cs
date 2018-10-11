using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace _5588ScoutingApp
{
    
    class TabController1 : UITabBarController
    {
        UIViewController scheduleTab, pitTab, fieldTab;

        public TabController1()
        {
            scheduleTab = new UIViewController();
            scheduleTab.TabBarItem = new UITabBarItem();
            scheduleTab.TabBarItem.Image = UIImage.FromFile("RankingIcon.png");
            scheduleTab.TabBarItem.Title = "Matches";
            scheduleTab.View.BackgroundColor = UIColor.Blue;

            pitTab = new UIViewController();
            pitTab.TabBarItem = new UITabBarItem();
            pitTab.TabBarItem.Image = UIImage.FromFile("pitIcon.png");
            pitTab.TabBarItem.Title = "Pit";
            pitTab.View.BackgroundColor = UIColor.Red;

            fieldTab = new UIViewController();
            fieldTab.TabBarItem = new UITabBarItem();
            fieldTab.TabBarItem.Image = UIImage.FromFile("fieldIcon.png");
            fieldTab.TabBarItem.Title = "Field";
            fieldTab.View.BackgroundColor = UIColor.Purple;

            var tabs = new UIViewController[]{
                scheduleTab, pitTab, fieldTab
            };

            ViewControllers = tabs;
        }
    }
}