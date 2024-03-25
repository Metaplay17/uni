using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceTuning
{
    internal class Workspace
    {
        private Monitor monitor;
        private Mouse mouse;
        private Keyboard keyboard;

        public Workspace(Monitor monitor, Mouse mouse, Keyboard keyboard)
        {
            this.monitor = monitor;
            this.mouse = mouse;
            this.keyboard = keyboard;
        }

        public void ChangeMonitor(Monitor newMonitor)
        {
            monitor = newMonitor;
        }

        public void ChangeKeyboard(Keyboard newKeyboard)
        {
            keyboard = newKeyboard;
        }

        public void ChangeMouse(Mouse newMouse)
        {
            mouse = newMouse;
        }

        public void Draw(Graphics graph)
        {
            monitor.Draw(graph);
            mouse.Draw(graph);
            keyboard.Draw(graph);
        }
    }
}
