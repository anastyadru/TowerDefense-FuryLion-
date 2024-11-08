// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;
using UnityEngine.UI;

public class GameMenuView : View
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _backButton;
    [SerializeField] private Button _settingsButton;
    
    public override void Initialize()
    {
        _playButton.onClick.AddListener(OnPlayButtonClicked);
        _backButton.onClick.AddListener(OnEndButtonClicked);
        _settingsButton.onClick.AddListener(OnSettingsButtonClicked);
    }

    private void OnPlayButtonClicked()
    {
        ViewManager.LoadSceneGame();
    }
    
    private void OnEndButtonClicked()
    {
        Debug.Log("GameOver");
    }
    
    private void OnSettingsButtonClicked()
    {
        ViewManager.Show<SettingsView>();
    }
}