using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public float speed;
    public int startingPoint;
    public Transform[] points;

    private int i;

    void Start()
    {
        transform.position = points[startingPoint].position; //sets platform to starting point
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }
        }
        
        //moving platform
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision enter");
        if (transform.CompareTag("Platform"))
        {
            collision.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("collision exit");
        if (transform.CompareTag("Platform"))
        {
            collision.transform.SetParent(null);
        }
    }
}
