using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon LotteryWeeklyInput.
/// </summary>
public sealed unsafe class ClickLotteryWeeklyInput : ClickBase<ClickLotteryWeeklyInput>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickLotteryWeeklyInput"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickLotteryWeeklyInput(IntPtr addon = default)
        : base("LotteryWeeklyInput", addon)
    {
    }

    public static implicit operator ClickLotteryWeeklyInput(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickLotteryWeeklyInput Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the Purchase button.
    /// </summary>
    /// <param name="ticketNumber">Number of the ticket to purchase.</param>
    public void Purchase(int ticketNumber)
        => this.FireCallback(ticketNumber);
}
