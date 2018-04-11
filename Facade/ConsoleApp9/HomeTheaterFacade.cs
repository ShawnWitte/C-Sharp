using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class HomeTheaterFacade
    {
        Amplifier amp;
        Projector projector;
        DvdPlayer dvd;
        

        public HomeTheaterFacade(Amplifier amp,
        Projector projector,
        DvdPlayer dvd)
        {
            this.amp = amp;
            this.projector = projector;
            this.dvd = dvd;
            
        }

        public void watchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie");
            amp.on();
            amp.setDvd(movie);
            amp.setVolume(5);
            projector.on();
            projector.wideScreenMode();
            dvd.on();
            dvd.play(movie);
        }

        public void endMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            amp.off();
            projector.off();
            dvd.stop();
            dvd.eject();
            dvd.off();
        }
        }

    }

