using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon Request.
/// </summary>
public sealed unsafe class ClickCompanyCraftSupply : ClickBase<ClickCompanyCraftSupply, AtkUnitBase>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickCompanyCraftSupply"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickCompanyCraftSupply(IntPtr addon = default)
        : base("CompanyCraftSupply", addon)
    {
    }

    public static implicit operator ClickCompanyCraftSupply(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickCompanyCraftSupply Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click on a part to repair it.
    /// </summary>
    /// <param name="partIndex">Index of the part to be repaired.</param>
    [ClickName("repair")]
    public void RepairPart(uint partIndex)
        => this.FireCallback(3, 0, partIndex, 0, 0, 0);
}
