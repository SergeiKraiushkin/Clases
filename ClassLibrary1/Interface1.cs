using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public interface INterface1
    {
        event System.EventHandler Event;

        int Property { get; set; }

        void Method();
    }
}