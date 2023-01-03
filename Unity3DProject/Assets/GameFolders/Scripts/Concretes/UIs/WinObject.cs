using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinObject : MonoBehaviour
{
    [SerializeField] GameObject _winPanel;

    private void Awake()
    {
        if (_winPanel.activeSelf)
        {
            _winPanel.SetActive(false);
        }
    }

    private void OnEnable()
    {
        GameManager.Instance.OnMissionSucced += HandleMissionSucced;
    }

    private void OnDisable()
    {
        GameManager.Instance.OnMissionSucced -= HandleMissionSucced;
    }

    public void HandleMissionSucced()
    {
        if (!_winPanel.activeSelf)
        {
            _winPanel.SetActive(true);
        }
    }
}
