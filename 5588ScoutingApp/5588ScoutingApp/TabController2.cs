using Foundation;
using System;
using UIKit;

namespace _5588ScoutingApp
{
    public partial class TabController2 : UITabBar
    {
        public TabController2(IntPtr handle) : base(handle)
        {
            UIViewController scheduleTab, pitTab, fieldTab;

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
            fieldTab.TabBarItem.Title = "ield";
            fieldTab.View.BackgroundColor = UIColor.Purple;

            var tabs = new UIViewController[]{
                scheduleTab, pitTab, fieldTab
            };

            //ViewControllers = tabs;
        }
    }
}
    