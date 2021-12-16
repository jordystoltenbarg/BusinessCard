using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActivateAndDeactivate : MonoBehaviour
{
    [SerializeField]
    private GameObject toggleGO;

    [SerializeField]
    private Toggle WerkwijzeButton;

    void Start()
    {

        Toggle btn = WerkwijzeButton.GetComponent<Toggle>();
        btn.onValueChanged.AddListener(OnToggleClick);
    }
    public void OnToggleClick(bool isToggle)
    {
        ToggleGameObject(toggleGO);
    }

    public void ToggleGameObject(GameObject go)
    {
        if (go.activeSelf)
        {
            go.SetActive(false);
        }
        else
        {
            go.SetActive(true);
        }
    }
}
