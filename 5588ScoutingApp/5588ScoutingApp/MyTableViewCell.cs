using System;

using Foundation;
using UIKit;

namespace _5588ScoutingApp
{
    public partial class MyTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MyTableViewCell");
        public static readonly UINib Nib;

        static MyTableViewCell()
        {
            Nib = UINib.FromName("MyTableViewCell", NSBundle.MainBundle);
        }

        protected MyTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public class TableSource : UITableViewSource
        {

            string[] TableItems;
            string CellIdentifier = "TableCell";

            public TableSource(string[] items)
            {
                TableItems = items;
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
        }
    }
}
