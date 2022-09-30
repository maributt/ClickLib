using System;

using ClickLib.Attributes;
using ClickLib.Bases;

namespace ClickLib.Clicks;

/// <summary>
/// Addon PurifyItemSelector.
/// </summary>
public sealed unsafe class ClickPurifyItemSelector : ClickBase<ClickPurifyItemSelector>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickPurifyItemSelector"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickPurifyItemSelector(IntPtr addon = default)
        : base("PurifyItemSelector", addon)
    {
    }

    public static implicit operator ClickPurifyItemSelector(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickPurifyItemSelector Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the item at a given index.
    /// </summary>
    /// <param name="index">Index to select.</param>
    [ClickName("reduce")]
    public void Click(int index = 0)
        => this.FireCallback(12, index);

    public void Quit()
        => this.FireCallback(-1);
}
