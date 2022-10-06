using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon Request.
/// </summary>
public sealed unsafe class ClickAirshipExplorationDetail : ClickBase<ClickAirshipExplorationDetail, AddonAirshipExplorationDetail>
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
    [ClickName("deploy")]
    public void Deploy()
        => this.FireCallback(0);

    /// <summary>
    /// Click the cancel button.
    /// </summary>
    [ClickName("voyage_details_cancel")]
    public void Cancel()
        => this.FireCallback(-1);

    /// <summary>
    /// Click the close button.
    /// </summary>
    [ClickName("voyage_details_close")]
    public void Close()
        => this.FireCallback(-2);

    /// <summary>
    /// Click the finalize report button.
    /// </summary>
    public void SendCallback(int id)
        => this.FireCallback(id);
}
