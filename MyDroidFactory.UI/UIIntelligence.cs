using System.Runtime.InteropServices;

namespace MyDroidFactory.UI;

public class UIIntelligence
{
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
    
    static uint MOUSE_DOWN_ADDRESS = 0x0002;
    static uint MOUSE_UP_ADDRESS = 0x0004;
    //static uint MOUSEEVENTF_ABSOLUTE = 0x8000; Dont need this in the end, since I will use the Cursor method.

    public static void DoMouseClick()
    {
        //uint X = (uint)Cursor.Position.X; Since I displace the cursor in the form(s), I wont need X Y Position here.
        //uint Y = (uint)Cursor.Position.Y;
        mouse_event(MOUSE_DOWN_ADDRESS | MOUSE_UP_ADDRESS, 0, 0, 0, 0);
    }
}
public class BoolCarrier
{
    public bool MyBool { get; set; } = false;
}


