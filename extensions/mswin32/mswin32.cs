// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*
APIs removed/broken by this factoring:

*/
namespace Microsoft.Win32
{
    public partial class IntranetZoneCredentialPolicy : System.Net.ICredentialPolicy
    {
        public IntranetZoneCredentialPolicy() { }
        public virtual bool ShouldSendCredential(System.Uri challengeUri, System.Net.WebRequest request, System.Net.NetworkCredential credential, System.Net.IAuthenticationModule authModule) { throw null; }
    }
    public partial class PowerModeChangedEventArgs : System.EventArgs
    {
        public PowerModeChangedEventArgs(Microsoft.Win32.PowerModes mode) { }
        public Microsoft.Win32.PowerModes Mode { get { throw null; } }
    }
    public delegate void PowerModeChangedEventHandler(object sender, Microsoft.Win32.PowerModeChangedEventArgs e);
    public enum PowerModes
    {
        Resume = 1,
        StatusChange = 2,
        Suspend = 3,
    }
    public partial class SessionEndedEventArgs : System.EventArgs
    {
        public SessionEndedEventArgs(Microsoft.Win32.SessionEndReasons reason) { }
        public Microsoft.Win32.SessionEndReasons Reason { get { throw null; } }
    }
    public delegate void SessionEndedEventHandler(object sender, Microsoft.Win32.SessionEndedEventArgs e);
    public partial class SessionEndingEventArgs : System.EventArgs
    {
        public SessionEndingEventArgs(Microsoft.Win32.SessionEndReasons reason) { }
        public bool Cancel { get { throw null; } set { } }
        public Microsoft.Win32.SessionEndReasons Reason { get { throw null; } }
    }
    public delegate void SessionEndingEventHandler(object sender, Microsoft.Win32.SessionEndingEventArgs e);
    public enum SessionEndReasons
    {
        Logoff = 1,
        SystemShutdown = 2,
    }
    public partial class SessionSwitchEventArgs : System.EventArgs
    {
        public SessionSwitchEventArgs(Microsoft.Win32.SessionSwitchReason reason) { }
        public Microsoft.Win32.SessionSwitchReason Reason { get { throw null; } }
    }
    public delegate void SessionSwitchEventHandler(object sender, Microsoft.Win32.SessionSwitchEventArgs e);
    public enum SessionSwitchReason
    {
        ConsoleConnect = 1,
        ConsoleDisconnect = 2,
        RemoteConnect = 3,
        RemoteDisconnect = 4,
        SessionLock = 7,
        SessionLogoff = 6,
        SessionLogon = 5,
        SessionRemoteControl = 9,
        SessionUnlock = 8,
    }
    public sealed partial class SystemEvents
    {
        internal SystemEvents() { }
        public static event System.EventHandler DisplaySettingsChanged { add { } remove { } }
        public static event System.EventHandler DisplaySettingsChanging { add { } remove { } }
        public static event System.EventHandler EventsThreadShutdown { add { } remove { } }
        public static event System.EventHandler InstalledFontsChanged { add { } remove { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This event has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
        public static event System.EventHandler LowMemory { add { } remove { } }
        public static event System.EventHandler PaletteChanged { add { } remove { } }
        public static event Microsoft.Win32.PowerModeChangedEventHandler PowerModeChanged { add { } remove { } }
        public static event Microsoft.Win32.SessionEndedEventHandler SessionEnded { add { } remove { } }
        public static event Microsoft.Win32.SessionEndingEventHandler SessionEnding { add { } remove { } }
        public static event Microsoft.Win32.SessionSwitchEventHandler SessionSwitch { add { } remove { } }
        public static event System.EventHandler TimeChanged { add { } remove { } }
        public static event Microsoft.Win32.TimerElapsedEventHandler TimerElapsed { add { } remove { } }
        public static event Microsoft.Win32.UserPreferenceChangedEventHandler UserPreferenceChanged { add { } remove { } }
        public static event Microsoft.Win32.UserPreferenceChangingEventHandler UserPreferenceChanging { add { } remove { } }
        public static System.IntPtr CreateTimer(int interval) { throw null; }
        public static void InvokeOnEventsThread(System.Delegate method) { }
        public static void KillTimer(System.IntPtr timerId) { }
    }
    public partial class TimerElapsedEventArgs : System.EventArgs
    {
        public TimerElapsedEventArgs(System.IntPtr timerId) { }
        public System.IntPtr TimerId { get { throw null; } }
    }
    public delegate void TimerElapsedEventHandler(object sender, Microsoft.Win32.TimerElapsedEventArgs e);
    public enum UserPreferenceCategory
    {
        Accessibility = 1,
        Color = 2,
        Desktop = 3,
        General = 4,
        Icon = 5,
        Keyboard = 6,
        Locale = 13,
        Menu = 7,
        Mouse = 8,
        Policy = 9,
        Power = 10,
        Screensaver = 11,
        VisualStyle = 14,
        Window = 12,
    }
    public partial class UserPreferenceChangedEventArgs : System.EventArgs
    {
        public UserPreferenceChangedEventArgs(Microsoft.Win32.UserPreferenceCategory category) { }
        public Microsoft.Win32.UserPreferenceCategory Category { get { throw null; } }
    }
    public delegate void UserPreferenceChangedEventHandler(object sender, Microsoft.Win32.UserPreferenceChangedEventArgs e);
    public partial class UserPreferenceChangingEventArgs : System.EventArgs
    {
        public UserPreferenceChangingEventArgs(Microsoft.Win32.UserPreferenceCategory category) { }
        public Microsoft.Win32.UserPreferenceCategory Category { get { throw null; } }
    }
    public delegate void UserPreferenceChangingEventHandler(object sender, Microsoft.Win32.UserPreferenceChangingEventArgs e);
}
namespace System.Media
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    public partial class SoundPlayer : System.ComponentModel.Component, System.Runtime.Serialization.ISerializable
    {
        public SoundPlayer() { }
        public SoundPlayer(System.IO.Stream stream) { }
        protected SoundPlayer(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext context) { }
        public SoundPlayer(string soundLocation) { }
        public bool IsLoadCompleted { get { throw null; } }
        public int LoadTimeout { get { throw null; } set { } }
        public string SoundLocation { get { throw null; } set { } }
        public System.IO.Stream Stream { get { throw null; } set { } }
        public object Tag { get { throw null; } set { } }
        public event System.ComponentModel.AsyncCompletedEventHandler LoadCompleted { add { } remove { } }
        public event System.EventHandler SoundLocationChanged { add { } remove { } }
        public event System.EventHandler StreamChanged { add { } remove { } }
        public void Load() { }
        public void LoadAsync() { }
        protected virtual void OnLoadCompleted(System.ComponentModel.AsyncCompletedEventArgs e) { }
        protected virtual void OnSoundLocationChanged(System.EventArgs e) { }
        protected virtual void OnStreamChanged(System.EventArgs e) { }
        public void Play() { }
        public void PlayLooping() { }
        public void PlaySync() { }
        public void Stop() { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class SystemSound
    {
        internal SystemSound() { }
        public void Play() { }
    }
    public sealed partial class SystemSounds
    {
        internal SystemSounds() { }
        public static System.Media.SystemSound Asterisk { get { throw null; } }
        public static System.Media.SystemSound Beep { get { throw null; } }
        public static System.Media.SystemSound Exclamation { get { throw null; } }
        public static System.Media.SystemSound Hand { get { throw null; } }
        public static System.Media.SystemSound Question { get { throw null; } }
    }
}
