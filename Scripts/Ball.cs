using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bol : MonoBehaviour
{
    public float speed = 8;
    public Rigidbody2D rb;
    private Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos;
        Launch();
    }
    public void Reset()
    {
        transform.position = startPos;
        rb.velocity = Vector2.zero;
        Launch();
    }
    public void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }


}
