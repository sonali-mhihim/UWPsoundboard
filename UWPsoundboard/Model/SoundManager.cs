using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Streaming.Adaptive;

namespace UWPsoundboard.Model
{
    public static class SoundManager
    {
        public static void GetAllsounds(ObservableCollection<Sound> Sounds)
        {
            var allSounds = GetSounds();
            Sounds.Clear();
            //foreach (var sound in sounds)
            //{
            //  Sounds.Add(sound);
            //}
            allSounds.ForEach(Sound => Sounds.Add(Sound));
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory category)
        {
            var allSounds = GetSounds();
            var filteredSounds = allSounds.Where(sound => sound.Category == category).ToList();
            sounds.Clear();
            filteredSounds.ForEach(sound => sounds.Add(sound)); //lambda expression
        }

        private static List<Sound> GetSounds()
        {
            var Sounds = new List<Sound>();
            Sounds.Add(new Sound("Cow", SoundCategory.Animals));
            Sounds.Add(new Sound("Cat", SoundCategory.Animals));
            Sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            Sounds.Add(new Sound("Spring", SoundCategory.Cartoons));
            Sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            Sounds.Add(new Sound("Lol", SoundCategory.Taunts));
            Sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            Sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return Sounds;
        }
    }
}
