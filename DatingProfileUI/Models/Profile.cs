using System;
namespace DatingProfileUI.Models
{
    public class Profile
    {
        private string description;
        private Color bgColor;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public Color BgColor
        {
            get { return bgColor; }
            set { bgColor = value; }
        }
    }
}

