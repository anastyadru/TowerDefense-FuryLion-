// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;
using UnityEngine.UI;

public class ExitMenuView : View
{
    [SerializeField] private Button _backButton;
    [SerializeField] private Button _menuButton;
    
    public override void Initialize()
    {
        _backButton.onClick.AddListener(() => ViewManager.ShowLast());
        _menuButton.onClick.AddListener(OnMenuButtonClicked);
    }
    
    private void OnMenuButtonClicked()
    {
        ViewManager.LoadSceneMenu();
    }
}