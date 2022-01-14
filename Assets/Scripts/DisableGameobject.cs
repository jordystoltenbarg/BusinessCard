using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGameobject : MonoBehaviour
{
    public GameObject ObjectToDisable;
    // Start is called before the first frame update
    public void DisableGameObject()
    {
        ObjectToDisable.SetActive(false);
    }

    public void EnableGameObject()
    {
        ObjectToDisable.SetActive(true);
    }
}
