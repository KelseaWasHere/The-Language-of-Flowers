using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayModeSettings : MonoBehaviour
{
    public TMP_Dropdown displayModeDropdown;

    void Start()
    {
        SetupDisplayModes();
    }

    void SetupDisplayModes()
    {
        displayModeDropdown.ClearOptions();

        List<string> modeOptions = new List<string>
        {
            "Fullscreen",         // Fullscreen window (borderless, entire screen)
            "Windowed",           // Resizable window with borders
            "Borderless Window"   // Maximized borderless window
        };

        displayModeDropdown.AddOptions(modeOptions);

        switch (Screen.fullScreenMode)
        {
            case FullScreenMode.FullScreenWindow:
            case FullScreenMode.ExclusiveFullScreen:
                displayModeDropdown.value = 0;
                break;
            case FullScreenMode.Windowed:
                displayModeDropdown.value = 1;
                break;
            case FullScreenMode.MaximizedWindow:
                displayModeDropdown.value = 2;
                break;
            default:
                displayModeDropdown.value = 0;
                break;
        }

        displayModeDropdown.RefreshShownValue();
        displayModeDropdown.onValueChanged.AddListener(SetDisplayMode);
    }

    void SetDisplayMode(int index)
    {
        switch (index)
        {
            case 0: // Fullscreen
                Screen.fullScreenMode = FullScreenMode.FullScreenWindow;
                Screen.fullScreen = true;
                break;
            case 1: // Windowed
                Screen.fullScreenMode = FullScreenMode.Windowed;
                Screen.fullScreen = false;
                break;
            case 2: // Borderless
                Screen.fullScreenMode = FullScreenMode.MaximizedWindow;
                Screen.fullScreen = false;
                break;
        }
    }
}
