using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SnackController : MonoBehaviour
{
    private PlayerAction playerActionControl;

    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private Transform snackSegmentPrefab;
    [SerializeField] private GameObject foodNormal;
    [SerializeField] private GameObject foodBig;
    [SerializeField] private Text scoreText;

    private Vector2 moveDirection =  Vector2.right;
    private Vector2 pointTopLeft, pointBottomRight;
    private List<Transform> snackSegments = new List<Transform>();

    private int score = 0;
    private int maxFoodSpawnAttempt = 9999;
    private int foodSpawnAttempt = 0;

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
        Time.timeScale = 1f;

        pointTopLeft = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));
        pointBottomRight = Camera.main.ScreenToWorldPoint(new Vector3(0f, 0f));

        Debug.Log(pointTopLeft + "|" + pointBottomRight);

        InitializeSnack();

        ResetFoodPosition();

        scoreText.text = score.ToString();
    }

    private void InitializeSnack()
    {
        if(snackSegments.Count > 0)
        {
            foreach(var _segment in snackSegments)
            {
                Destroy(_segment.gameObject);
            }
            snackSegments.Clear();
        }

        snackSegments.Add(this.transform);
        for(int i = 0; i< 3 ; i++)
        {
            Grow();
        }
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

        transform.position = new Vector3(Mathf.Round(_x), Mathf.Round(_y), 0f);
    }

    private void Grow()
    {
        GameObject _go = Instantiate(snackSegmentPrefab.gameObject);
        _go.transform.position = snackSegments[snackSegments.Count - 1].position;
        snackSegments.Add(_go.transform);
    }

    private void ResetFoodPosition()
    {
        int _x = Random.Range(0, (int) pointTopLeft.x);
        int _y = Random.Range(0, (int) pointTopLeft.y);

        Vector3 _newFoodPos = new Vector3(_x,_y, 0f);
        //Debug.Log("New Food Pos : " + _newFoodPos);

        RaycastHit2D hit = Physics2D.Raycast(_newFoodPos, Vector2.zero);
        if(hit.collider != null &&  hit.collider.CompareTag("Player"))
        {
            foodSpawnAttempt++;
            if(foodSpawnAttempt < maxFoodSpawnAttempt)
            {
                ResetFoodPosition();
            }
            else
            {
                Debug.Log("You Won!!!");
            }
        }
        else
        {
            foodNormal.transform.position = _newFoodPos;

            foodSpawnAttempt = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Food"))
        {
            Grow();
            score += 1;
            scoreText.text = score.ToString();
            ResetFoodPosition();
        }

#region BigFood
       /* if (col.CompareTag("BigFood"))
        {
            Grow();
            // Add a new Segment
            // Deactivate 
            score += 5;
            scoreText.text = score.ToString();
        }*/
#endregion

        if(col.CompareTag("Player"))
        {
            Debug.Log("GAME OVER");
            // Retry Menu
        }
    }

    #region Button Func

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    #endregion
    
}
