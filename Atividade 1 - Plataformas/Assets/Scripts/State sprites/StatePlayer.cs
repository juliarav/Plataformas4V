using UnityEngine;
using UnityEngine.InputSystem;

public class StatePlayer : MonoBehaviour
{
    private Vector2 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.sKey.isPressed)
        {
            moveInput.x = - 1f;
        }
        
        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.sKey.isPressed)
        {
            moveInput.y = - 1f;
        }
        
        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.sKey.isPressed)
        {
            moveInput.y = - 1f;
        }
    }
}
