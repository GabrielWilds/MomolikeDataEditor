using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MomolikeDataEditor
{
    class MainWindowViewModel : ViewModelBase
    {
        public List<Animation> Animations
        {
            get;
            set;
        }

        public void Browse()
        {
            //open file browser to point at a sprite sheet, defaulting to game dir
        }

        public void Load()
        {
            //fill canvas with selected sprite sheet
        }

        public void Save()
        {
            //save the animation definitions and data to JSON text file to be read by momolike
        }

        public void AddAnimation()
        {
            Animations.Add(new Animation());
            //add a new default Animation to the list, to be defined by the user.
        }
    }
}
