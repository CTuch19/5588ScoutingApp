using System;
using CoreGraphics;
using UIKit;

namespace _5588ScoutingApp
{
    public partial class FormCreator : UIViewController
    {
        public FormCreator() : base("FormCreator", null)
        {
        }

        public FormCreator(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            this.View.BackgroundColor = UIColor.Purple;

            UIButton newQuestionButton = new UIButton(UIButtonType.System)
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.X + 20, 50, 160, 40),
                BackgroundColor = UIColor.Black,
                
            };
            newQuestionButton.SetTitle("Add Question", UIControlState.Normal);

            UITextField box = new UITextField()
            {
                BackgroundColor = UIColor.White,
                Frame = new CGRect(UIScreen.MainScreen.Bounds.X + 20, 100, 160, 40),
                Placeholder = "Type question here",
                KeyboardType = UIKeyboardType.Default

            };

            var saveQuestionButton = new UIButton(UIButtonType.System)
            {
                BackgroundColor = UIColor.White,
                Frame = new CGRect(UIScreen.MainScreen.Bounds.X + 20, 200, 160, 40)
            };
            saveQuestionButton.SetTitle("Save Question", UIControlState.Normal);
             
            UILabel questionTypesLabel = new UILabel();
            QuestionTypes questionTypes = new QuestionTypes();
            var questionTypesPicker = questionTypes.makePickerView(questionTypesLabel, (nint)UIScreen.MainScreen.Bounds.GetMidX(), 70, 160, 100);

            //var testSwitch = questionTypes.makeSwitch(new CGRect(50, 300, 80, 100));
            //var testSegment = questionTypes.makeSegmentedControl(100, 300);

            View.AddSubviews(newQuestionButton);

            newQuestionButton.TouchUpInside += (s, e) =>
            {
                View.AddSubviews(box, saveQuestionButton, questionTypesPicker);
            };

            saveQuestionButton.TouchUpInside += (s, e) =>
            {
                string qtext = box.Text;
                string qType = questionTypesLabel.Text;
                View.AddSubview(
                    new UITextField()
                    {
                        BackgroundColor = UIColor.Cyan,
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.X + 20, 250, 250, 50),
                        Text = qtext + qType
                    }
                );
            };

    }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

