// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;
using UnityEngine.UI;

public class MusicView : View
{
    [SerializeField] private Button _backButton;
    
    public override void Initialize()
    {
        _backButton.onClick.AddListener(() => ViewManager.ShowLast());
    }
}