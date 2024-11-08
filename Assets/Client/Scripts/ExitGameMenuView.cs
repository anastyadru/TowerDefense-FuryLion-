// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;
using UnityEngine.UI;

public class ExitGameMenuView : View
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _menuButton;
    
    public override void Initialize()
    {
        _playButton.onClick.AddListener(OnPlayButtonClicked);
        _menuButton.onClick.AddListener(OnMenuButtonClicked);
    }

    private void OnPlayButtonClicked()
    {
        ViewManager.LoadSceneGame();
    }
    
    private void OnMenuButtonClicked()
    {
        ViewManager.LoadSceneMenu();
    }
}