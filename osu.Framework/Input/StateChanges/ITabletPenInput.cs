// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

namespace osu.Framework.Input.StateChanges
{
    /// <summary>
    /// Denotes a simulated mouse input that was made by a tablet/pen device.
    /// </summary>
    public interface ITabletPenInput : IInput
    {
        public TabletPenDeviceType DeviceType { get; }
    }
}
