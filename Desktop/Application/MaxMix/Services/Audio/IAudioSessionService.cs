﻿using System;

namespace MaxMix.Services.Audio
{
    internal interface IAudioSessionService
    {
        void Start();
        void Stop();
        void SetItemVolume(int id, int volume, bool isMuted);
        void SetDefaultEndpoint(int id);

        event DefaultAudioDeviceChangedDelegate DefaultDeviceChanged;
        event AudioDeviceCreatedDelegate DeviceCreated;
        event AudioDeviceRemovedDelegate DeviceRemoved;
        event AudioDeviceVolumeDelegate DeviceVolumeChanged;

        event AudioSessionCreatedDelegate SessionCreated;
        event AudioSessionRemovedDelegate SessionRemoved;
        event AudioSessionVolumeDelegate SessionVolumeChanged;
    }
}
