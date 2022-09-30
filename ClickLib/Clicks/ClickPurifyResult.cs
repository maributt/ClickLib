using System;

using ClickLib.Bases;

namespace ClickLib.Clicks;

/// <summary>
/// Addon PurifyResult.
/// </summary>
public sealed unsafe class ClickPurifyResult : ClickBase<ClickPurifyResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickPurifyResult"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickPurifyResult(IntPtr addon = default)
        : base("PurifyItemSelector", addon)
    {
    }

    public static implicit operator ClickPurifyResult(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickPurifyResult Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the close button.
    /// </summary>
    public void Close() => this.FireCallback();
}
