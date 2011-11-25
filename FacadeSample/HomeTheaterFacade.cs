using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeSample
{
    class HomeTheaterFacade
    {
        public Amplifier Amp { get; set; }
        public Tuner Tuner { get; set; }
        public DVDPlayer Dvd { get; set; }
        public CDPlayer Cd { get; set; }
        public Projector Projector { get; set; }
        public TheaterLights Lights { get; set; }
        public Screen Screen { get; set; }
        public PopcornPopper Popper { get; set; }

        public HomeTheaterFacade(Amplifier amp,
            Tuner tuner,
            DVDPlayer dvd,
            CDPlayer cd,
            Projector projector,
            TheaterLights lights,
            Screen screen,
            PopcornPopper popper)
        {
            Amp = amp;
            Tuner = tuner;
            Dvd = dvd;
            Cd = cd;
            Projector = projector;
            Lights = lights;
            Screen = screen;
            Popper = popper;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch movie...");
            Popper.On();
            Popper.Pop();
            Lights.Dim(10);
            Screen.Down();
            Projector.On();
            Projector.WideScreenMode();
            Amp.On();
            Amp.SetDVD(movie);
            Amp.SetSurroundSound();
            Amp.SetVolume(5);
            Dvd.On();
            Dvd.Play();
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting down the move theater...");
            Popper.Off();
            Lights.On();
            Screen.Up();
            Projector.Off();
            Amp.Off();
            Dvd.Stop();
            Dvd.Eject();
            Dvd.Off();
        }
    }
}
