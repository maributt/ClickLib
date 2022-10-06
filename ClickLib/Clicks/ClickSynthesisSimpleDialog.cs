using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon RecipeNote.
/// </summary>
public sealed unsafe class ClickSynthesisSimpleDialog : ClickBase<ClickSynthesisSimpleDialog, AddonSynthesisSimpleDialog>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickSynthesisSimpleDialog"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickSynthesisSimpleDialog(IntPtr addon = default)
        : base("SynthesisSimpleDialog", addon)
    {
    }

    public static implicit operator ClickSynthesisSimpleDialog(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickSynthesisSimpleDialog Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the Synthesize button and crafts a set amount.
    /// </summary>
    /// <param name="amount">Amount to quick synthesize.</param>
    /// <param name="useHq">Whether to use HQ materials.</param>
    [ClickName("quick_synthesis_synthesize")]
    public void Synthesize(int amount, bool useHq)
        => this.FireCallback(amount, useHq ? 1 : 0);

    /// <summary>
    /// Click the Cancel button.
    /// </summary>
    [ClickName("quick_synthesis_cancel")]
    public void Cancel()
        => this.FireCallback(-1);
}
