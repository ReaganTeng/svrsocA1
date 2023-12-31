using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float endingPoint = -20;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(GameController.instance.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.instance.isGameOver)
        {
            rb2d.velocity = Vector2.zero;
        }

        if(gameObject.transform.position.x <= endingPoint)
        {
            Destroy(gameObject);
        }
    }
}
