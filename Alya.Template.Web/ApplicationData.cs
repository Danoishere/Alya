using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alya.Template.Web
{
    public class Skill
    {
        public Skill(string title, string description, int stars)
        {
            Title = title;
            Description = description;
            Stars = stars;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Stars { get; set; }

        public int EmptyStars { get { return 5 - Stars; } }
    }


    public class ApplicationData
    {
        #region Singelton stuff
        private ApplicationData() { }
        private static ApplicationData instance = null;
        public static ApplicationData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationData();
                }
                return instance;
            }
        }
        #endregion

        public List<Skill> Skills { get; set; } = new List<Skill>();
    }
}