using System;

namespace DesignPatterns.Bridge.Devices
{   
  public interface IRemote {
    
    void Power();

    void VolumeDown();

    void VolumeUp();

    void ChannelDown();

    void ChannelUp();
  }
}