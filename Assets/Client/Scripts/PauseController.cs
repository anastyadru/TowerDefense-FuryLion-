// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    [SerializeField] private Button pauseButton;
    private bool isPaused = false;

    private void Awake()
    {
        pauseButton.onClick.AddListener(OnPauseButtonClicked);
    }

    private void OnPauseButtonClicked()
    {
        Time.timeScale = 0;
        ViewManager.Show<PauseMenuView>();
        isPaused = true;
    }
}