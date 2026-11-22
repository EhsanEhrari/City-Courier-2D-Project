using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerCar : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 6f;
    [SerializeField] private float turnSpeed = 140f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var keys = Keyboard.current;
        if(keys==null) return;
    
        float drive = 0f;
        float turn = 0f;

        if(keys.wKey.isPressed || keys.upArrowKey.isPressed)
        {
            drive = drive + 1f;
        }
        if(keys.sKey.isPressed || keys.downArrowKey.isPressed)
        {
            drive = drive - 1f;
        }
        if(keys.aKey.isPressed || keys.leftArrowKey.isPressed)
        {
            turn = turn + 1;
        }
        if(keys.dKey.isPressed || keys.rightArrowKey.isPressed)
        {
            turn = turn - 1;
        }
        transform.Rotate(0,0, turn*turnSpeed*Time.deltaTime);
        transform.Translate(Vector3.up * (drive * moveSpeed * Time.deltaTime));
    }
}
