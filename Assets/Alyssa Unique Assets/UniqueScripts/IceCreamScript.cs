using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCreamScript : MonoBehaviour
{
    Animation animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
            animation.Play();
    }
}
