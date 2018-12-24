using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;

namespace _5588ScoutingApp
{
    public partial class FormCreator : UIViewController
    {
        public FormQuestionSet questionSet = new FormQuestionSet();
        public FormCreator() : base("FormCreator", null)
        {
        }

        public FormCreator(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            View.BackgroundColor = UIColor.Purple;
            QuestionTypes questionTypes = new QuestionTypes();

            UIButton newQuestionButton = new UIButton(UIButtonType.System)
            {
                Frame = new CGRect(UIScreen.MainScreen.Bounds.X + 20, 50, 160, 40),
                BackgroundColor = UIColor.Black,
                
            };
            newQuestionButton.SetTitle("Add Question", UIControlState.Normal);

            UITextField questionField = questionTypes.makeTextField("Type Question Here", new CGRect(UIScreen.MainScreen.Bounds.X + 20, 100, 160, 40));

            var saveQuestionButton = new UIButton(UIButtonType.System)
            {
                BackgroundColor = UIColor.White,
                Frame = new CGRect(UIScreen.MainScreen.Bounds.X + 20, 200, 160, 40)
            };
            saveQuestionButton.SetTitle("Save Question", UIControlState.Normal);

            var saveFormButton = new UIButton(UIButtonType.System)
            {
                BackgroundColor = UIColor.White,
                //Center = new CGPoint(),
                Frame = new CGRect(UIScreen.MainScreen.Bounds.GetMidX() - 80, UIScreen.MainScreen.Bounds.GetMaxY() - 80, 160, 40)
            };
            saveFormButton.SetTitle("Save Form", UIControlState.Normal);

            UILabel questionTypesLabel = new UILabel();
            var questionTypesPicker = questionTypes.makePickerView(questionTypesLabel, (nint)UIScreen.MainScreen.Bounds.GetMidX(), 70, 160, 100);

            //var testSwitch = questionTypes.makeSwitch(new CGRect(50, 300, 80, 100));
            //var testSegment = questionTypes.makeSegmentedControl(100, 300);

            View.AddSubviews(newQuestionButton, saveFormButton);

            newQuestionButton.TouchUpInside += (s, e) =>
            {
                View.AddSubviews(questionField, saveQuestionButton, questionTypesPicker);
            };

            saveQuestionButton.TouchUpInside += (s, e) =>
            {
                string qtext = questionField.Text;
                string qType = questionTypesLabel.Text;


                if(qtext != String.Empty)
                {
                    questionSet.addQuestion(new Question(qtext, qType));
                    
                    View.AddSubview(
                    new UITextField()
                    {
                        BackgroundColor = UIColor.Cyan,
                        Frame = new CGRect(UIScreen.MainScreen.Bounds.X + 20, 250, 250, 50),
                        Text = qtext + qType
                    }
                );
                }

            };

            var loginVC = new UIViewController() { Title = "Login Success!" };
            loginVC.View.BackgroundColor = UIColor.Purple;

            saveFormButton.TouchUpInside += (s, e) =>
            {
                //Create Alert
                var pitOrFieldController = UIAlertController.Create("Alert Title", "Choose from two buttons", UIAlertControllerStyle.Alert);


                //Add Actions
                pitOrFieldController.AddAction(UIAlertAction.Create("Pit", UIAlertActionStyle.Default, alert => this.NavigationController.PushViewController(loginVC, true)));
                pitOrFieldController.AddAction(UIAlertAction.Create("Field", UIAlertActionStyle.Default, alert => Console.WriteLine("field was clicked")));

                //Present Alert
                PresentViewController(pitOrFieldController, true, null);
            };

    }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

