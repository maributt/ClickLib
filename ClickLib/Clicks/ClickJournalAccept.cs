using System;

using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon JournalAccept.
/// </summary>
public unsafe class ClickJournalAccept : ClickBase<ClickJournalAccept, AtkUnitBase>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ClickJournalAccept"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickJournalAccept(IntPtr addon = default)
        : base("JournalAccept", addon)
    {
    }

    public static implicit operator ClickJournalAccept(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickJournalAccept Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the Accept button.
    /// </summary>
    /// <param name="acceptButton">Accept button pointer.</param>
    public void Accept(AtkComponentButton* acceptButton) => this.ClickAddonButton(acceptButton, 1);
}