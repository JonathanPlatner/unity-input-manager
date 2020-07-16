using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{
    [SerializeField]
    private InputManager im;

    void Update()
    {
        transform.Translate(im.Horizontal.Value() * Time.deltaTime, 0, im.Vertical.Value() * Time.deltaTime);
    }
}
