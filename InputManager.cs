using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private Inputs.Button fire = new Inputs.Button(Inputs.Button.MouseButton.Zero, KeyCode.Space, ""); // Defaults
    [SerializeField]
    private Inputs.Axis horizontal = new Inputs.Axis(KeyCode.D, KeyCode.A, "");
    [SerializeField]
    private Inputs.Axis vertical = new Inputs.Axis(KeyCode.W, KeyCode.S, "");

    
    public Inputs.Button Fire { get { return fire; } }
    public Inputs.Axis Horizontal { get { return horizontal; } }
    public Inputs.Axis Vertical { get { return vertical; } }
}


