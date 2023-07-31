using System;

using ClickLib.Bases;

namespace ClickLib.Clicks;

/// <summary>
/// Addon MJIFarmManagement.
/// </summary>
public sealed unsafe class ClickMJIFarmManagement : ClickBase<ClickMJIFarmManagement>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickMJIFarmManagement"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickMJIFarmManagement(IntPtr addon = default)
        : base("MJIFarmManagement", addon)
    {
    }

    public static implicit operator ClickMJIFarmManagement(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickMJIFarmManagement Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the begin button.
    /// </summary>
    /// <param name="atIndex">Item index on which to invoke the context menu callback.</param>
    public void InvokeContextMenu(int atIndex)
        => this.FireCallback(0, atIndex);

    /// <summary>
    /// Click the Collect All button.
    /// </summary>
    public void CollectAll()
        => this.FireCallback(3);

    /// <summary>
    /// Click the Close button.
    /// </summary>
    public void Close()
        => this.FireCallback(-1).FireCallback(-2);
}