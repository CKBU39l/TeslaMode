namespace TeslaMode
{
    using TeslaMode;
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using InventorySystem.Items.Usables;
    using System;
    using System.ComponentModel;
    using System.Diagnostics.Eventing.Reader;
    using first;

    /// <summary>
    /// The example plugin.
    /// </summary>
    public class teslapl : Plugin<cfg>
    {
        private static readonly teslapl Singleton = new teslapl();
        private ok eventHandler;
        private teslapl()
        {
        }
        public static teslapl Instance => Singleton;


        /// <summary>
        /// Gets the only existing instance of this plugin.
        /// </summary>

        /// <inheritdoc/>
        public override PluginPriority Priority { get; } = PluginPriority.Last;

        /// <inheritdoc/>
        public override void OnEnabled()
        {
            RegisterEvents();


            base.OnEnabled();
        }

        /// <inheritdoc/>
        public override void OnDisabled()
        {
            UnregisterEvents();
            base.OnDisabled();
        }
        /// <summary>
        /// Registers the plugin events.
        /// </summary>
        private void RegisterEvents()
        {
            eventHandler = new ok();
            Exiled.Events.Handlers.Player.TriggeringTesla += eventHandler.TriggeringTesla;
        }

        /// <summary>
        /// Unregisters the plugin events.
        /// </summary>
        private void UnregisterEvents()
        {
            Exiled.Events.Handlers.Player.TriggeringTesla -= eventHandler.TriggeringTesla;

            eventHandler = null;
        }
    }
}