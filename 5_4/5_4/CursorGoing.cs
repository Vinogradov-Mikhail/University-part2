using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursorProgram
{
    /// <summary>
    /// class for action of up, down, right and left button
    /// </summary>
    class CursorGoing
    {
        /// <summary>
        /// maximum travel way to right and down
        /// </summary>
        private const int MaximumWay = 80;

        /// <summary>
        /// action for up button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void GoingUp(object sender, EventArgs args)
        {
            if (Console.CursorTop != 0)
            {
                Console.CursorTop--;
            }
        }

        /// <summary>
        /// action for right button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void GoingRight(object sender, EventArgs args)
        {
            if (Console.CursorLeft != MaximumWay)
            {
                Console.CursorLeft++;
            }
        }

        /// <summary>
        /// action for down button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void GoingDown(object sender, EventArgs args)
        {
            if (Console.CursorTop != MaximumWay)
            {
                Console.CursorTop++;
            }
        }

        /// <summary>
        /// action for left button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void GoingLeft(object sender, EventArgs args)
        {
            if(Console.CursorLeft != 0)
            {
                Console.CursorLeft--;
            }
        }
    }
}
