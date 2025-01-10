using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TurnOnLightCommand :ICommand
    {
        private readonly Light _light;

        public TurnOnLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }

        public void undo()
        {
           _light.Turnoff();
        }
    }


    public class  TurnoffLightCommand:ICommand
    {
        private readonly Light _light;

        public TurnoffLightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Turnoff();
        }

        public void undo()
        {
            _light.TurnOn();
        }
    }
}
