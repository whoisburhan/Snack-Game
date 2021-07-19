using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnackController : MonoBehaviour
{
    private PlayerAction playerActionControl;

    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private Transform snackSegmentPrefab;
    [SerializeField] private GameObject foodNormal;
    [SerializeField] private GameObject foodBig;

    private Vector2 moveDirection =  Vector2.right;
    private Vector2 pointTopLeft, pointBottomRight;
    private List<Transform> snackSegments = new List<Transform>();

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
        pointTopLeft = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        pointBottomRight = Camera.main.ScreenToWorldPoint(new Vector3(0f, 0f));

        Debug.Log(pointTopLeft + "|" + pointBottomRight);

        snackSegments.Add(this.transform);
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
        Loop();

        for(int i = snackSegments.Count-1; i > 0; i--)
        {
            snackSegments[i].position = snackSegments[i - 1].position;
        }

        transform.position = new Vector3(Mathf.Round(transform.position.x) + moveDirection.x, Mathf.Round(transform.position.y) + moveDirection.y, 0f);
  
    }

    private void Loop()
    {
        float _x = transform.position.x > pointTopLeft.x ? pointBottomRight.x + 1 : transform.position.x;
        _x = transform.position.x < pointBottomRight.x ? pointTopLeft.x - 1 : _x;

        float _y = transform.position.y > pointTopLeft.y ? Mathf.Round(pointBottomRight.y) + 1 : transform.position.y;
        _y = transform.position.y < pointBottomRight.y ? Mathf.Round(pointTopLeft.y) - 1 : _y;

        Debug.Log(_x + "|||" + pointTopLeft.x);

        transform.position = new Vector3(Mathf.Round(_x), Mathf.Round(_y), 0f);
    }

    private void Grow()
    {
        GameObject _go = Instantiate(snackSegmentPrefab.gameObject);
        _go.transform.position = snackSegments[snackSegments.Count - 1].position;
        snackSegments.Add(_go.transform);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Food"))
        {
            Grow();
            // Add a new Segment
            // Change Food Pos
            // Score += 1
        }

        else if (col.CompareTag("BigFood"))
        {
            // Add a new Segment
            // Deactivate 
            // Score += 5
        }
    }
}
