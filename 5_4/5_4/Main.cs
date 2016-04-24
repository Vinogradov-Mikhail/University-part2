using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursorProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            var eventLoop = new EventLoop();
            var cursorGoing = new CursorGoing();
            eventLoop.UpHandler += cursorGoing.GoingUp;
            eventLoop.RightHandler += cursorGoing.GoingRight;
            eventLoop.DownHandler += cursorGoing.GoingDown;
            eventLoop.LeftHandler += cursorGoing.GoingLeft;
            eventLoop.Run();
        }
    }
}
