using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon MateriaRetrieveDialog.
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
    public void Test(int index)
        => this.FireCallback(0, index, 0);
}
