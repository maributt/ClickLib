using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon Request.
/// </summary>
public sealed unsafe class ClickAirshipExplorationResult : ClickBase<ClickAirshipExplorationResult, AddonAirshipExplorationResult>
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
    [ClickName("redeploy")]
    public void Redeploy()
        => this.FireCallback(1);

    /// <summary>
    /// Click the finalize report button.
    /// </summary>
    [ClickName("finalize_report")]
    public void FinalizeReport()
        => this.FireCallback(0);

    /// <summary>
    /// Click the finalize report button.
    /// </summary>
    [ClickName("voyage_results_close")]
    public void Close()
        => this.FireCallback(-1);

    /// <summary>
    /// Click the finalize report button.
    /// </summary>
    public void SendCallback(int id)
        => this.FireCallback(id);
}
