using System;

using ClickLib.Bases;

namespace ClickLib.Clicks;

/// <summary>
/// Addon MJIFarmManagement.
/// </summary>
public sealed unsafe class ClickMJISearchArea : ClickBase<ClickMJISearchArea>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickMJISearchArea"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickMJISearchArea(IntPtr addon = default)
        : base("MJISearchArea", addon)
    {
    }

    public static implicit operator ClickMJISearchArea(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickMJISearchArea Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Sets the amount of days for the currently selected expedition.
    /// </summary>
    /// <param name="amount">Amount of days.</param>
    public void SetDays(int amount)
        => this.FireCallback(14, amount);

    /// <summary>
    /// Click the confirm button.
    /// </summary>
    public void Confirm()
        => this.FireCallback(15, 0, 0);
}