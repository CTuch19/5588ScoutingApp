using System;
using Foundation;
using UIKit;

namespace _5588ScoutingApp
{
        public class TableSource : UITableViewSource
        {

            string[] TableItems;
            string CellIdentifier = "TableCell";
            ScheduleTab schedule;

            public TableSource(string[] items, ScheduleTab schedule)
            {
                TableItems = items;
                this.schedule = schedule;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return TableItems.Length;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
                string item = TableItems[indexPath.Row];

                //---- if there are no cells to reuse, create a new one
                if (cell == null)
                { cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

                cell.TextLabel.Text = item;

                return cell;
            }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            UIAlertController okAlertController = UIAlertController.Create(TableItems[indexPath.Row], "Here is their stats", UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

            schedule.PresentViewController(okAlertController, true, null);

            tableView.DeselectRow(indexPath, true);
        }
    }
}

