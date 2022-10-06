using System;

using ClickLib.Attributes;
using ClickLib.Bases;
using Dalamud.Logging;
using FFXIVClientStructs.Attributes;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace ClickLib.Clicks;

/// <summary>
/// Addon JournalResult.
/// </summary>
public sealed unsafe class ClickLobbyDKTCheck : ClickBase<ClickJournalResult, AddonLobbyDKTCheck>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickLobbyDKTCheck"/> class.
    /// </summary>
    /// <param name="addon">Addon pointer.</param>
    public ClickLobbyDKTCheck(IntPtr addon = default)
        : base("LobbyDKTCheck", addon)
    {
    }

    public static implicit operator ClickLobbyDKTCheck(IntPtr addon) => new(addon);

    /// <summary>
    /// Instantiate this click using the given addon.
    /// </summary>
    /// <param name="addon">Addon to reference.</param>
    /// <returns>A click instance.</returns>
    public static ClickLobbyDKTCheck Using(IntPtr addon) => new(addon);

    /// <summary>
    /// Click the select world button.
    /// </summary>
    [ClickName("select_world")]
    public void SelectWorld()
    => this.FireCallback(0);

    public void SelectWorldAlt()
    {
        PluginLog.LogDebug($"{((AtkUnitBase*)this.AddonAddress)->UldManager.NodeList[3]->GetComponent()->UldManager.NodeList[2]->GetAsAtkTextNode()->NodeText.ToString()}");
        this.ClickAddonButton((AtkComponentButton*)((AtkUnitBase*)this.AddonAddress)->UldManager.NodeList[3]->GetComponent(), 2);
    }

    /// <summary>
    /// Click the cancel button.
    /// </summary>
    [ClickName("select_world_cancel")]
    public void Cancel()
        => this.FireCallback(1);

    /// <summary>
    /// Click the decline button.
    /// </summary>
    [ClickName("select_world_close")]
    public void Close()
        => this.FireCallback(-1);
}