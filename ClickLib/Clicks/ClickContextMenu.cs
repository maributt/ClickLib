using System;

using ClickLib.Bases;
using Dalamud.Logging;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon ContextIconMenu.
/// </summary>
public sealed unsafe class ClickContextMenu : ClickBase<ClickContextMenu>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickContextMenu"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickContextMenu(IntPtr addon = default)
        : base("ContextMenu", addon)
    {
    }

    public static implicit operator ClickContextMenu(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickContextMenu Using(IntPtr addon) => new(addon);

    private bool MatchContextOptionAtIndex(int index, string expectedText)
    {
        var listComponent = (AtkComponentList*)((AtkUnitBase*)this.AddonAddress)->UldManager.NodeList[2]->GetComponent();
        var listLength = listComponent->ListLength;
        var listItems = listComponent->ItemRendererList;

        PluginLog.LogDebug($"found=\"{listItems[index].AtkComponentListItemRenderer->AtkComponentButton.ButtonTextNode->NodeText.ToString()}\"\nexpected=\"{expectedText}\"");

        return listItems[index].AtkComponentListItemRenderer->AtkComponentButton.ButtonTextNode->NodeText.ToString() == expectedText;
    }

    public void IslandSanctuaryCollectAndEnd()
    {
        /*var indexInList = 1;
        var expectedText = "Collect & End Caretaking Services";

        var listComponent = (AtkComponentList*)((AtkUnitBase*)this.AddonAddress)->UldManager.NodeList[2]->GetComponent();
        var listLength = listComponent->ListLength;
        var listItems = listComponent->ItemRendererList;
        if (listItems[1].AtkComponentListItemRenderer->AtkComponentButton.ButtonTextNode->NodeText.ToString() == expectedText)*/
        if (this.MatchContextOptionAtIndex(1, "Collect & End Caretaking Services"))
            this.FireCallback(0, 1, 0, 0, 0);
    }

    public void IslandSanctuaryCollectAndResume()
    {
        /*var indexInList = 2;
        var expectedText = "Collect Leavings & Resume Caretaking Services";

        var listComponent = (AtkComponentList*)((AtkUnitBase*)this.AddonAddress)->UldManager.NodeList[2]->GetComponent();
        var listLength = listComponent->ListLength;
        var listItems = listComponent->ItemRendererList;


        */
        // if (listItems[indexInList].AtkComponentListItemRenderer->AtkComponentButton.ButtonTextNode->NodeText.ToString() == expectedText)
        if (this.MatchContextOptionAtIndex(2, "Collect Leavings & Resume Caretaking Services"))
        {
            this.FireCallback(0, 2, 0, 0, 0);
        }
    }

    public void IslandSanctuaryDismissCaretaker()
    {
        if (this.MatchContextOptionAtIndex(1, "Dismiss Caretaker"))
            this.FireCallback(0, 1, 0, 0, 0);
    }

    public void IslandSanctuaryEntrustCaretaker()
    {
        if (this.MatchContextOptionAtIndex(1, "Entrust to Caretaker"))
            this.FireCallback(0, 1, 0, 0, 0);
    }

    // /// <summary>
    // /// Select the item at the given index.
    // /// </summary>
    // /// <param name="index">Index to select.</param>
    // public void SelectItem(ushort index)
    //     => this.ClickList(index, this.Target->AtkComponentList240);
    //
    // /// <summary>
    // /// Click the item in index 1.
    // /// </summary>
    // [ClickName("select_context_icon1")]
    // public void SelectItem1()
    //     => this.SelectItem(1);
    //
    // /// <summary>
    // /// Click the item in index 2.
    // /// </summary>
    // [ClickName("select_context_icon2")]
    // public void SelectItem2()
    //     => this.SelectItem(2);
    //
    // /// <summary>
    // /// Click the item in index 3.
    // /// </summary>
    // [ClickName("select_context_icon3")]
    // public void SelectItem3()
    //     => this.SelectItem(3);
    //
    // /// <summary>
    // /// Click the item in index 4.
    // /// </summary>
    // [ClickName("select_context_icon4")]
    // public void SelectItem4()
    //     => this.SelectItem(4);
    //
    // /// <summary>
    // /// Click the item in index 5.
    // /// </summary>
    // [ClickName("select_context_icon5")]
    // public void SelectItem5()
    //     => this.SelectItem(5);
    //
    // /// <summary>
    // /// Click the item in index 6.
    // /// </summary>
    // [ClickName("select_context_icon6")]
    // public void SelectItem6()
    //     => this.SelectItem(6);
    //
    // /// <summary>
    // /// Click the item in index 7.
    // /// </summary>
    // [ClickName("select_context_icon7")]
    // public void SelectItem7()
    //     => this.SelectItem(7);
    //
    // /// <summary>
    // /// Click the item in index 8.
    // /// </summary>
    // [ClickName("select_context_icon8")]
    // public void SelectItem8()
    //     => this.SelectItem(8);
}
