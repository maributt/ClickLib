using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon Request.
/// </summary>
public sealed unsafe class ClickAirshipExplorationResult : ClickBase<ClickAirshipExplorationResult, AtkUnitBase>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickAirshipExplorationResult"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickAirshipExplorationResult(IntPtr addon = default)
        : base("AirshipExplorationResult", addon)
    {
    }

    public static implicit operator ClickAirshipExplorationResult(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickAirshipExplorationResult Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the redeploy button.
    /// </summary>
    /// <param name="button">Redeploy button.</param>
    [ClickName("redeploy")]
    public void Redeploy(AtkComponentButton* button)
        => this.ClickAddonButton(button, 0);

    /// <summary>
    /// Click the finalize report button.
    /// </summary>
    /// <param name="button">Finalize button.</param>
    [ClickName("voyage_results_finalize_report")]
    public void FinalizeReport(AtkComponentButton* button)
        => this.ClickAddonButton(button, 1);
}
