using System;
using System.Collections.ObjectModel;
using DatingProfileUI.Models;

namespace DatingProfileUI.ViewModels
{
    public class ProfileViewModel
    {
        private ObservableCollection<Profile> profileCollection;

        public ObservableCollection<Profile> profile
        {
            get { return profileCollection; }
            set { profileCollection = value; }
        }

        public ProfileViewModel()
        {
            profileCollection = new ObservableCollection<Profile>();
            profileCollection.Add(new Profile { Description = "Music", BgColor = Color.FromArgb("#ffeefa") });
            profileCollection.Add(new Profile { Description = "Photo", BgColor = Color.FromArgb("#eaefff") });
            profileCollection.Add(new Profile { Description = "Art History", BgColor = Color.FromArgb("#fef1e8") });
            profileCollection.Add(new Profile { Description = "Design", BgColor = Color.FromArgb("#eaefff") });
            profileCollection.Add(new Profile { Description = "Art Filma", BgColor = Color.FromArgb("#fef1e8") });
            profileCollection.Add(new Profile { Description = "Dancing", BgColor = Color.FromArgb("#ffeefa") });

        }
    }

}

