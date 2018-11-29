﻿/*
 * Copyright (c) 2018 Samsung Electronics Co., Ltd
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://floralicense.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.Generic;
using Xamarin.Forms;

namespace AudioManagerSample
{
    public class DeviceItem
    {
        private uint _sampleFormat;
        private uint _sampleRate;
        private bool _mediaOnly;
        private bool _avoidResampling;
        private bool _isUsbOutputDevice;

        public DeviceItem(int id, string type, string name, string state)
        {
            Id = id;
            Type = type;
            Name = name;
            State = state;
        }

        /// <summary>
        /// Gets or sets the device id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the device type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the device name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the device state.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets the device sample format.
        /// </summary>
        public string SampleFormat {
            get
            {
                if (_sampleFormat == 0)
                    return "unknown-bit";
                else
                    return _sampleFormat + "-bit";
            }
        }

        /// <summary>
        /// Gets the device sample rate.
        /// </summary>
        public string SampleRate {
            get
            {
                return _sampleRate + "-Hz";
            }
        }

        /// <summary>
        /// Gets the device media-only property.
        /// </summary>
        public string MediaOnly {
            get
            {
                return "Media-Only is " + (_mediaOnly ? "Enabled" : "Disabled");
            }
        }

        /// <summary>
        /// Gets the device avoid-resampling property.
        /// </summary>
        public string AvoidResampling {
            get
            {
                return "Avoid-Resampling is " + (_avoidResampling ? "Enabled" : "Disabled");
            }
        }

        /// <summary>
        /// Verifies if the device is USB output device.
        /// </summary>
        public bool IsUsbOutputDevice {
            get => _isUsbOutputDevice;
        }

        public void SetUsbOutputDeviceProperties(uint sampleFormat, uint sampleRate, bool mediaOnly, bool avoidResampling)
        {
            _sampleFormat = sampleFormat;
            _sampleRate = sampleRate;
            _mediaOnly = mediaOnly;
            _avoidResampling = avoidResampling;
            _isUsbOutputDevice = true;
        }
    }
}