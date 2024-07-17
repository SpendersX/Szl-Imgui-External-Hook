using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClickableTransparentOverlay;
using ImGuiNET;
using Gui;
using Loop;

namespace Hook
{


        class LoadHook
        {
        static void Main(string[] args)
        {

            Renderer renderer = new Renderer();
            renderer.Start().Wait();

            Loop.Functions functions = new Loop.Functions();


            while (true)
            {
                functions.function();



                



                Thread.Sleep(10);
            }

        }
    }
}
