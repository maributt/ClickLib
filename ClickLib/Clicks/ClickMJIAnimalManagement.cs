using System;

using ClickLib.Bases;

namespace ClickLib.Clicks;

/// <summary>
/// Addon MJIAnimalManagement.
/// </summary>
public sealed unsafe class ClickMJIAnimalManagement : ClickBase<ClickMJIAnimalManagement>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickMJIAnimalManagement"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickMJIAnimalManagement(IntPtr addon = default)
        : base("MJIAnimalManagement", addon)
    {
    }

    public static implicit operator ClickMJIAnimalManagement(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickMJIAnimalManagement Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the begin button.
    /// </summary>
    /// <param name="atIndex">Item index on which to invoke the context menu callback.</param>
    public void InvokeContextMenu(int atIndex)
        => this.FireCallback(0, atIndex, 0);

    /// <summary>
    /// Click the Collect All button.
    /// </summary>
    public void CollectAll() => this.FireCallback(5);

    /// <summary>
    /// Click the Collect All button.
    /// </summary>
    public void Close() => this.FireCallback(-1).FireCallback(-2);
}
