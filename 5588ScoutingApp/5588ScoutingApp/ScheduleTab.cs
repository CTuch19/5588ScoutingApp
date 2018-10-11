using Foundation;
using System;
using UIKit;

namespace _5588ScoutingApp
{
    public partial class ScheduleTab : UIViewController
    {
        public ScheduleTab (IntPtr handle) : base (handle)
        {

        }


        UITableView table;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.BackgroundColor = UIColor.White;

            table = new UITableView(View.Bounds);
            string[] tableItems = new string[] { "Match 1", "Match 2", "Match 3", "Match 4", "Match 5", "Match 6" };
            table.Source = new TableSource(tableItems, this);
            Add(table);
        }


    }
}