using CommandPattern;

Light light=new Light();

ICommand turnoncommand=new TurnOnLightCommand(light);
ICommand turnoffcommand=new TurnoffLightCommand(light);

RemoteControl remote=new RemoteControl();

remote.Setcommand(turnoncommand);
remote.PressButton();
remote.PressUndo();

remote.Setcommand(turnoffcommand);
remote.PressButton();
remote.PressUndo();



