using System;
using UIKit;

namespace _5588ScoutingApp
{
    public class QuestionTypePickerViewModel: UIPickerViewModel
    {
        public string[] questionTypes = new string[]{
            "Text Field",
            "Switch",
            "Slider",
            "Picker"
        };

        private UILabel questionLabel;
        public QuestionTypePickerViewModel(UILabel qlabel)
        {
            this.questionLabel = qlabel;
        }

        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return questionTypes.Length;
        }

        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            if (component == 0)
                return questionTypes[row];
            else
                return row.ToString();
        }

        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
            questionLabel.Text = $" {questionTypes[pickerView.SelectedRowInComponent(0)]}";
        }

        public override nfloat GetComponentWidth(UIPickerView pickerView, nint component)
        {
            if (component == 0)
                return 200f;
            else
                return 40f;
        }

        public override nfloat GetRowHeight(UIPickerView pickerView, nint component)
        {
            return 40f;
        }
    }
}
