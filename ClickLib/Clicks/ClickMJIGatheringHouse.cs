using System;

using ClickLib.Bases;

namespace ClickLib.Clicks;

/// <summary>
/// Addon MJIFarmManagement.
/// </summary>
public sealed unsafe class ClickMJIGatheringHouse : ClickBase<ClickMJIGatheringHouse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickMJIGatheringHouse"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickMJIGatheringHouse(IntPtr addon = default)
        : base("MJIFarmManagement", addon)
    {
    }

    public static implicit operator ClickMJIGatheringHouse(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickMJIGatheringHouse Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the collect button for a given Granary.
    /// </summary>
    /// <param name="atIndex">Granary index to collect from.</param>
    public void CollectGranary(int atIndex)
        => this.FireCallback(13, atIndex);

    /// <summary>
    /// Click the change expedition button for a given Granary.
    /// </summary>
    /// <param name="atIndex">Granary index to change expedition for.</param>
    public void ChangeExpedition(int atIndex)
        => this.FireCallback(12, atIndex);
}