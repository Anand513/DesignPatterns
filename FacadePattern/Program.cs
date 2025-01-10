using FacadePattern;

DVDPlayer dVDPlayer = new DVDPlayer();
SoundSystem soundSystem = new SoundSystem();    
Projector projector = new Projector();

HomeTheater _hometheater=new HomeTheater(dVDPlayer,projector,soundSystem);

_hometheater.WatchMovie("Squid Game");
_hometheater.EndMoview();