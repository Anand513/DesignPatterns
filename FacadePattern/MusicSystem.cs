using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class DVDPlayer
    {
        public void TurnOn()
        {
            Console.WriteLine(" DVD Turn on");
        }

        public void Turnoff() {
            Console.WriteLine("DVD Turn OFF");
                
        }

        public void PlayMove(string MovieName)
        {
            Console.WriteLine($"Playing Move : {MovieName}");
        }


    }

    public class SoundSystem
    {
        public void SetVolume(int level)
        {
            Console.WriteLine($"Volume set to : {level} ");
        }
    }

    public class Projector
    {
        public void Turnon()
        {
            Console.WriteLine("Projector Turned ON");
        }

        public void Turnoff()
        {
            Console.WriteLine("Project Turned OFF");
        }
    }
}
