using ClickableTransparentOverlay;
using GuiStyle;
using ImGuiNET;
using System.Numerics;
using System.Runtime.InteropServices;
using WindowsInput;
using WindowsInput.Native;

namespace Gui
{
    public class Renderer : Overlay
    {

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vkey);



        Vector2 windowsize = new Vector2(688, 400);


        InputSimulator inputSimulator = new InputSimulator();
        Vector2 mouseMovement = new Vector2(0, 0);



        protected override void Render()
        {

            StyleGui styleGui = new StyleGui();

            styleGui.styleGui();



            ImGui.Begin("Window");
            ImGui.SetWindowSize(windowsize);








            ImGui.End();

        }
    }
}