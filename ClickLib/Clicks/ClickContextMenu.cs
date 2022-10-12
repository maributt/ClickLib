using System;

using ClickLib.Bases;
using Dalamud.Logging;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon ContextMenu.
/// </summary>
public unsafe class ClickContextMenu : ClickBase<ClickContextMenu>
{
    /// <summary>
    /// The ListLength attribute of the 2nd node in the AtkComponentList of the ContextMenu addon.
    /// </summary>
    private int listLength;

    /// <summary>
    /// Initializes a new instance of the <see cref="ClickContextMenu"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickContextMenu(IntPtr addon = default)
        : base("ContextMenu", addon)
    {
        this.listLength = ((AtkComponentList*)((AtkUnitBase*)addon)->UldManager.NodeList[2]->GetComponent())->ListLength;
    }

    public static implicit operator ClickContextMenu(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickContextMenu Using(IntPtr addon) => new(addon);

    #region Island Sanctuary

    /// <summary>
    /// Wrapper for the Island Sanctuary's MJIAnimalManagement addon's "Collect &amp; End Caretaking Services" contenxt menu option.
    /// </summary>
    public void MJIAnimalManagementCollectAndEnd()
    {
        if (this.MatchContextOptionAtIndex(1, "Collect Leavings & End Caretaking Services"))
            this.FireCallback(0, 1, 0, 0, 0);
    }

    /// <summary>
    /// Wrapper for the Island Sanctuary's MJIAnimalManagement addon's "Collect Leavings &amp; Resume Caretaking Services" contenxt menu option.
    /// </summary>
    public void MJIAnimalManagementCollectAndResume()
    {
        if (this.MatchContextOptionAtIndex(2, "Collect Leavings & Resume Caretaking Services"))
        {
            this.FireCallback(0, 2, 0, 0, 0);
        }
    }

    /// <summary>
    /// Wrapper for the Island Sanctuary's MJIAnimalManagement addon's "Collect &amp; End Caretaking Services" contenxt menu option.
    /// </summary>
    public void MJIFarmManagementCollectAndEnd()
    {
        if (this.listLength == 2 && this.MatchContextOptionAtIndex(0, "Collect Yield & End Gardening Services"))
            this.FireCallback(0, 0, 0, 0, 0);
    }

    /// <summary>
    /// Wrapper for the Island Sanctuary's MJIAnimalManagement addon's "Collect Leavings &amp; Resume Caretaking Services" contenxt menu option.
    /// </summary>
    public void MJIFarmManagementCollectAndResume()
    {
        PluginLog.LogDebug($"MJIFarmManagementCollectAndResume called (length:{this.listLength})");
        if (this.listLength == 2 && this.MatchContextOptionAtIndex(1, "Collect Yield & Resume Gardening Services"))
        {
            this.FireCallback(0, 1, 0, 0, 0);
            PluginLog.LogDebug("FireCallback");
        }
    }

    /// <summary>
    /// Wrapper for the Island Sanctuary's MJIAnimalManagement addon's "Dismiss Caretaker" contenxt menu option.
    /// </summary>
    public void IslandSanctuaryDismissCaretaker()
    {
        if (this.MatchContextOptionAtIndex(1, "Dismiss Caretaker"))
            this.FireCallback(0, 1, 0, 0, 0);
    }

    /// <summary>
    /// Wrapper for the Island Sanctuary's MJIAnimalManagement addon's "Entrust to Caretaker" contenxt menu option.
    /// </summary>
    public void IslandSanctuaryEntrustCaretaker()
    {
        if (this.MatchContextOptionAtIndex(1, "Entrust to Caretaker"))
            this.FireCallback(0, 1, 0, 0, 0);
    }

    #endregion

    /// <summary>
    /// Click the context option at a given index if the text matches.
    /// </summary>
    /// <param name="index">The index to click.</param>
    /// <param name="expectedText">The expected context menu text at the provided index.</param>
    /// <returns>Whether the context menu element at the given index and matching the given string was found.</returns>
    protected bool MatchContextOptionAtIndex(int index, string expectedText)
    {
        var listComponent = (AtkComponentList*)((AtkUnitBase*)this.AddonAddress)->UldManager.NodeList[2]->GetComponent();
        var listLength = listComponent->ListLength;
        var listItems = listComponent->ItemRendererList;

        PluginLog.LogDebug($"listLength={listLength}\nfound=\"{listItems[index].AtkComponentListItemRenderer->AtkComponentButton.ButtonTextNode->NodeText.ToString()}\"\nexpected=\"{expectedText}\"");

        if (listLength <= index)
            return false;
        return listItems[index].AtkComponentListItemRenderer->AtkComponentButton.ButtonTextNode->NodeText.ToString() == expectedText;
    }
}
