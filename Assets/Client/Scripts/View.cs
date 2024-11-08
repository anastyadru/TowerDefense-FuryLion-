// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using UnityEngine;
using UnityEngine.UI;

public abstract class View : MonoBehaviour
{
    public abstract void Initialize();

    public virtual void Hide() => gameObject.SetActive(false);
    public virtual void Show() => gameObject.SetActive(true);
}