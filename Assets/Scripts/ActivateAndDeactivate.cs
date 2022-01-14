using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ActivateAndDeactivate : MonoBehaviour
{
    private Animator animPicturePanel;
    private Animator animWerkWijzeTabs;

    [SerializeField]
    private GameObject PicturePanel;

    [SerializeField]
    private GameObject WerkWijzeTabs;


    [SerializeField]
    private Toggle WerkwijzeButton;

    void Start()
    {
        Toggle btn = WerkwijzeButton.GetComponent<Toggle>();
        btn.onValueChanged.AddListener(OnToggleClick);
        animPicturePanel = PicturePanel.gameObject.GetComponent<Animator>();
        animWerkWijzeTabs = WerkWijzeTabs.gameObject.GetComponent<Animator>();
    }

    public void OnToggleClick(bool isToggle)
    {
        ToggleGameObject(PicturePanel);
        ToggleGameObject(WerkWijzeTabs);
    }

    public void ToggleGameObject(GameObject go)
    {
        
        if (go.activeSelf)
        {
            //go.SetActive(false);
            Debug.Log("PicturePanel disabled");
        }
        else
        {
            go.SetActive(true);
            animPicturePanel.SetBool("PicturePanelActive", true);
            animWerkWijzeTabs.SetBool("WerkwijzeTabsActive", false);
            Debug.Log("PicturePanel enabled");
        }
    }

    public void PlayAnimation()
    {
        animPicturePanel.SetTrigger("ButtonClick");
        animPicturePanel.SetBool("PicturePanelActive", false);
        animWerkWijzeTabs.SetTrigger("ButtonClick");
        animWerkWijzeTabs.SetBool("WerkwijzeTabsActive", true);
        Debug.Log("PlayAnimation started");
    }

}
