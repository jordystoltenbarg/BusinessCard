using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimationOnClick : MonoBehaviour
{
    private Animator anim;


    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        anim.SetTrigger("ButtonClick");
       // PicturePanelanim.SetTrigger("ButtonClick");
        Debug.Log("PlayAnimation started");
    }
}
