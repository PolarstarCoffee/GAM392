using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseWheel : MonoBehaviour
{
    MouseScroll scroll;
    // Start is called before the first frame update

    private void Awake()
    {
        scroll = new MouseScroll();
    }


    private void OnEnable()
    {
        scroll.Enable();
    }

    private void OnDisable()
    {
        scroll.Disable();
    }
}
