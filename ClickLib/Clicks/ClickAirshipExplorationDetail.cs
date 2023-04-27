using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon Request.
/// </summary>
public sealed unsafe class ClickAirshipExplorationDetail : ClickBase<ClickAirshipExplorationDetail, AtkUnitBase>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickAirshipExplorationDetail"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickAirshipExplorationDetail(IntPtr addon = default)
        : base("AirshipExplorationDetail", addon)
    {
    }

    public static implicit operator ClickAirshipExplorationDetail(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickAirshipExplorationDetail Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the deploy button.
    /// </summary>
    /// <param name="button">Deploy button.</param>
    [ClickName("deploy")]
    public void Deploy(AtkComponentButton* button)
        => this.ClickAddonButton(button, 0);

    /// <summary>
    /// Click the cancel button.
    /// </summary>
    /// <param name="button">Cancel button.</param>
    [ClickName("voyage_details_cancel")]
    public void Cancel(AtkComponentButton* button)
        => this.ClickAddonButton(button, 1);
}
