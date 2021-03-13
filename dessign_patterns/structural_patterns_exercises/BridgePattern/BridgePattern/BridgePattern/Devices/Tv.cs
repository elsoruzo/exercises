using System;

namespace DesignPatterns.Bridge.Devices
{   
  public class Tv : IDevice {
    private bool _on = false;
    private int _volume = 30;
    private int _channel = 1;

    public bool IsEnabled() {
        return _on;
    }

    public void Enable() {
        _on = true;
    }

    public void Disable() {
        _on = false;
    }

    public int GetVolume() {
        return _volume;
    }

    public void SetVolume(int volume) {
        if (volume > 100) {
            this._volume = 100;
        } else if (volume < 0) {
            this._volume = 0;
        } else {
            this._volume = volume;
        }
    }


    public int GetChannel() {
        return _channel;
    }


    public void SetChannel(int channel) {
        this._channel = channel;
    }


    public void PrintStatus() {
        Console.Write("------------------------------------\n");
        Console.Write("| I'm Tv set.\n");
        Console.Write("| I'm " + (_on ? "enabled\n" : "disabled\n"));
        Console.Write("| Current volume is " + _volume + "%\n");
        Console.Write("| Current channel is " + _channel+"\n");
        Console.Write("------------------------------------\n");
    }
  }
}