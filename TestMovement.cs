using UnityEngine;

public class TestMovement : MonoBehaviour
{
    [SerializeField]
    private InputManager im;

    private Camera mainCam;

    private void Start()
    {
        mainCam = Camera.main;
    }
    void Update()
    {
        transform.Translate(im.Horizontal.Value() * Time.deltaTime, 0, im.Vertical.Value() * Time.deltaTime);
        Debug.DrawRay(im.Mouse.Project(mainCam).origin, im.Mouse.Project(mainCam).direction);
    }
}
