using System;
namespace _5588ScoutingApp
{
    public class Question
    {
        string text { get; set; }
        string type;
        int intOfType { get; set; }

        private enum QTypes { TextField, Switch, Slider, Picker };

        public Question(string text, string type)
        {
            this.text = text;
            this.type = type;
            this.convertTypeToNum(type);
        }

        public string GetText()
        {
            return text;
        }

        public void convertTypeToNum(string type)
        {
            if(type.Contains("Text Field"))
            {
                intOfType = (int)QTypes.TextField;
            }
            else if (type.Contains("Picker"))
            {
                intOfType = (int)QTypes.Picker;
            }
            else if (type.Contains("Slider"))
            {
                intOfType = (int)QTypes.Slider;
            }
            else
            {
                intOfType = (int)QTypes.Switch;
            }
        }
    }
}
