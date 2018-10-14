using System;
using CoreGraphics;
using UIKit;

namespace _5588ScoutingApp
{
    public class QuestionTypes
    {
        public QuestionTypes()
        {
        }

        public UIPickerView makePickerView(UILabel label, nint x, nint y, nint width, nint height)
        {
            var questionTypesPicker = new UIPickerView(new CGRect(x, y, width, height));
            var questionTypesPickerModel = new QuestionTypePickerViewModel(label);
            questionTypesPicker.Model = questionTypesPickerModel;

            return questionTypesPicker;

        }

        public UITextField makeTextField(nint x, nint y, nint width, nint height)
        {
            return new UITextField()
            {
                BackgroundColor = UIColor.White,
                Frame = new CGRect(x, y, width, height),
                Placeholder = "Type question here",
                KeyboardType = UIKeyboardType.Default
            };
        }

        public UILabel makeLabel(CGRect frame, string text)
        {
            return new UILabel()
            {
                BackgroundColor = UIColor.White,
                Frame = frame,
                Text = text
            };
        }

        public UISwitch makeSwitch(CGRect frame)
        {
            //is an event handler for when the value is changed - note
            return new UISwitch()
            {
                Frame = frame,
                On = false
            };
        }

        public UISegmentedControl makeSegmentedControl(double x, double y)
        {
            string[] segmentItems = new string[] { "One", "Two", "Three" };
            var segment = new UISegmentedControl(segmentItems)
            {
                Center = new CGPoint(x, y),
                //for changing font color
                //TintColor = UIColor.Black
                
            };

            return segment;
        }

    }
}
