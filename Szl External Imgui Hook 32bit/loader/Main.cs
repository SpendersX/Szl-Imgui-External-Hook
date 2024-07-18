using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClickableTransparentOverlay;
using ImGuiNET;
using Gui;

namespace Hook
{

    class LoadHook
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            renderer.Start().Wait();
        }
    }
}
