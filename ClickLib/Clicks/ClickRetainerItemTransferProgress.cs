using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon RetainerTaskAsk.
/// </summary>
public sealed unsafe class ClickRetainerItemTransferProgress : ClickBase<ClickRetainerItemTransferProgress, AddonRetainerItemTransferProgress>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickRetainerItemTransferProgress"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickRetainerItemTransferProgress(IntPtr addon = default)
        : base("RetainerItemTransferProgress", addon)
    {
    }

    public static implicit operator ClickRetainerItemTransferProgress(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickRetainerItemTransferProgress Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the close window button.
    /// </summary>
    [ClickName("retainer_transfer_close_window")]
    public void CloseWindow()
        => this.ClickAddonButton(this.Addon->CloseWindowButton, 1);
}