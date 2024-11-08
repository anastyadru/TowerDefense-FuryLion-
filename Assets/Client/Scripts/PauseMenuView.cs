// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;
using UnityEngine.UI;

public class PauseMenuView : View
{
    [SerializeField] private Button _continueButton;
    [SerializeField] private Button _soundEffectsButton;
    [SerializeField] private Button _musicButton;
    [SerializeField] private Button _mainMenuButton;

    public override void Initialize()
    {
        _continueButton.onClick.AddListener(OnContinueButtonClicked);
        _soundEffectsButton.onClick.AddListener(OnSoundEffectsButtonClicked);
        _musicButton.onClick.AddListener(OnMusicButtonClicked);
        _mainMenuButton.onClick.AddListener(OnMainMenuButtonClicked);
    }

    private void OnContinueButtonClicked()
    {
        ViewManager.ShowLast();
        Time.timeScale = 1;
        Hide();
    }

    private void OnSoundEffectsButtonClicked()
    {
        ViewManager.Show<SoundEffectsView>();
    }

    private void OnMusicButtonClicked()
    {
        ViewManager.Show<MusicView>();
    }

    private void OnMainMenuButtonClicked()
    {
        ViewManager.Show<ExitMenuView>();
    }
}