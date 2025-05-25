using System;
using System.Runtime.InteropServices;

namespace DesktopComServer.COM_Interface
{
    [ComVisible(true)] // Expose this class to COM
    [Guid("66B2C321-FA3F-4B97-A4FA-92E9D16D8F13")] // Unique GUID
    [ClassInterface(ClassInterfaceType.None)] // Use explicit interface implementation
    [ProgId("DesktopComServer.Communication")] // ProgID used by COM clients
    public class Communication : ICommunication
    {
        private string _latestMessage = "Initial Value from COM";

        public string SendMessage(string message)
        {
            _latestMessage = $"Message received: {message} {new Random().Next(100)}";
            return _latestMessage;
        }
        public void NotifyFromWeb(string data)
        {
            _latestMessage = $"{data} {new Random().Next(100)}";
            // Show message on UI or update state
        }

        public string FetchDesktopUpdates()
        {
            return _latestMessage;
        }
    }
}
//GUID = {66b2c321-fa3f-4b97-a4fa-92e9d16d8f13}
