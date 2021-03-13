using System;

namespace DesignPatterns.Bridge.Devices
{   
  public class BasicRemote : IRemote {
   protected IDevice device;

    public BasicRemote() {}

    public BasicRemote(IDevice device) {
        this.device = device;
    }

    public void Power() {
         Console.Write("Remote: power toggle\n");
        if (device.IsEnabled()) {
            device.Disable();
        } else {
            device.Enable();
        }
    }


    public void VolumeDown() {
        Console.Write("Remote: volume down\n");
        device.SetVolume(device.GetVolume() - 10);
    }


    public void VolumeUp() {
        Console.Write("Remote: volume up\n");
        device.SetVolume(device.GetVolume() + 10);
    }


    public void ChannelDown() {
        Console.Write("Remote: channel down\n");
        device.SetChannel(device.GetChannel() - 1);
    }

    public void ChannelUp() {
        Console.Write("Remote: channel up\n");
        device.SetChannel(device.GetChannel() + 1);
    }
  }
}