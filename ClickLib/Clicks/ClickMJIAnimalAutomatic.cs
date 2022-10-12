using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon MJIAnimalAutomatic.
/// </summary>
public sealed unsafe class ClickMJIAnimalAutomatic : ClickBase<ClickMJIAnimalAutomatic>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickMJIAnimalAutomatic"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickMJIAnimalAutomatic(IntPtr addon = default)
        : base("MJIAnimalAutomatic", addon)
    {
    }

    public static implicit operator ClickMJIAnimalAutomatic(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickMJIAnimalAutomatic Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the begin button.
    /// </summary>
    /// <param name="food">The ID of the food to start the caretaking services with.</param>
    public void CaretakingServiceStartWith(int food)
    {
            this.FireCallback(2, food, 0);
    }
}
