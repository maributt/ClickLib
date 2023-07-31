using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon LotteryWeeklyRewardList.
/// </summary>
public sealed unsafe class ClickLotteryWeeklyRewardList : ClickBase<ClickLotteryWeeklyRewardList>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickLotteryWeeklyRewardList"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickLotteryWeeklyRewardList(IntPtr addon = default)
        : base("LotteryWeeklyRewardList", addon)
    {
    }

    public static implicit operator ClickLotteryWeeklyRewardList(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickLotteryWeeklyRewardList Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the deliver button.
    /// </summary>
    public void Close()
        => this.FireCallback(-1);
}
