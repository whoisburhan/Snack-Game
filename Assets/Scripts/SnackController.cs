using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnackController : MonoBehaviour
{
    private PlayerAction playerActionControl;

    [SerializeField] private Rigidbody2D rb2d;

    private Vector2 moveDirection =  Vector2.right;

    private void Awake()
    {
        playerActionControl = new PlayerAction();
    }

    private void OnEnable()
    {
        playerActionControl.Enable();
        Time.fixedDeltaTime = 0.08f;
    }

    private void OnDisable()
    {
        playerActionControl.Disable();
        Time.fixedDeltaTime = 0.02f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var dir = playerActionControl.Snack.Movement.ReadValue<Vector2>();
        if(dir != Vector2.zero)
        {
            if(dir != -moveDirection)
                moveDirection = dir;
        }
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Round(transform.position.x) + moveDirection.x, Mathf.Round(transform.position.y) + moveDirection.y, 0f);
    }
}
