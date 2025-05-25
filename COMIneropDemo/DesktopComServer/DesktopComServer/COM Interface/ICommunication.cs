using System;
using System.Runtime.InteropServices;

namespace DesktopComServer.COM_Interface
{
    [ComVisible(true)] // Makes the interface visible to COM
    [Guid("E33E7639-78D7-41D0-BAB2-6DCC8B6AEB6A")] // Unique GUID
    [InterfaceType(ComInterfaceType.InterfaceIsDual)] // Dual = Automation + vtable
    public interface ICommunication
    {
        string SendMessage(string message);
        void NotifyFromWeb(string data);
        string FetchDesktopUpdates();
    }
}
