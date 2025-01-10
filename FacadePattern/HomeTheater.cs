using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class HomeTheater
    {
        SoundSystem soundSystem=new SoundSystem();
        Projector projector=new Projector();
        DVDPlayer DVDPlayer = new DVDPlayer();


        public HomeTheater(DVDPlayer _player, Projector _projector,SoundSystem _system ) 
        { 
            DVDPlayer=_player;
            projector=_projector;
            soundSystem=_system;
        }

        public void WatchMovie(string Movie)
        {
            Console.WriteLine("Movie starting");
            projector.Turnon();
            DVDPlayer.TurnOn();
            soundSystem.SetVolume(10);
            DVDPlayer.PlayMove(Movie);
        }

        public void EndMoview()
        {
            Console.WriteLine("End Movie");
            projector.Turnoff();
            DVDPlayer.Turnoff();
            soundSystem.SetVolume(0);
            
        }
    }
}
