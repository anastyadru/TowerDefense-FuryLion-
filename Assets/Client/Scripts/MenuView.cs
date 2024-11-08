// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;
using UnityEngine.UI;


public class MenuView : View
{
    [SerializeField] private Button _settingsButton;
    
    public override void Initialize()
    {
        _settingsButton.onClick.AddListener(() => ViewManager.Show<SettingsMenuView>());
    }
}