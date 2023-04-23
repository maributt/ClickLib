using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon JournalDetail.
/// </summary>
public sealed unsafe class ClickRetainerItemTransferList : ClickBase<ClickRetainerItemTransferList, AddonRetainerItemTransferList>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickRetainerItemTransferList"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickRetainerItemTransferList(IntPtr addon = default)
        : base("RetainerItemTransferList", addon)
    {
    }

    public static implicit operator ClickRetainerItemTransferList(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickRetainerItemTransferList Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the accept button.
    /// </summary>
    [ClickName("retainer_transfer_confirm")]
    public void Confirm()
        => this.ClickAddonButton(this.Addon->ConfirmButton, 0);
}
