using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBasics
{
    public delegate void Display<T>(T sender, EventArgs e);

    public class Shape
    {
        public event Display<Shape> Displayed;

        private void OnDisplay()
        {
            if (Displayed != null)
                Displayed(this, new EventArgs());
        }

        public void Display()
        {
            OnDisplay();
        }
    }


    public class ShapeUsingAction
    {
        public event Action<ShapeUsingAction, EventArgs> Displayed;

        private void OnDisplay()
        {
            if (Displayed != null)
                Displayed(this, new EventArgs());
        }

        public void Display()
        {
            OnDisplay();
        }
    }
}
