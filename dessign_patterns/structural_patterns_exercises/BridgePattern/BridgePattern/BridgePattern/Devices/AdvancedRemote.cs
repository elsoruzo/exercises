using System;

namespace DesignPatterns.Bridge.Devices
{   
  public class AdvancedRemote : BasicRemote {
    public AdvancedRemote(IDevice device) : base(device){}

    public void Mute() {
        Console.Write("Remote: mute\n");
        device.SetVolume(0);
    }
  }
}