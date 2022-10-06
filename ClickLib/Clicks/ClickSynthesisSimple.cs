using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon SynthesisSimple.
/// </summary>
public sealed unsafe class ClickSynthesisSimple : ClickBase<ClickSynthesisSimpleDialog, AddonSynthesisSimpleDialog>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickSynthesisSimple"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickSynthesisSimple(IntPtr addon = default)
        : base("SynthesisSimple", addon)
    {
    }

    public static implicit operator ClickSynthesisSimple(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickSynthesisSimple Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the End Synthesis/Quit button.
    /// </summary>
    [ClickName("end_synthesis")]
    public void EndSynthesis()
        => this.FireCallback(-1);
}
