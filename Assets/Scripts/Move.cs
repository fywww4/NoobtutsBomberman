using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 6;
    public static int live = 3;
    public GameObject[] liveGameObject = new GameObject[3];

    void FixedUpdate()
    {
        // Check Input Axes, then use velocity
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(h, v) * speed;

        // Set Animation Parameters
        GetComponent<Animator>().SetInteger("X", (int)h);
        GetComponent<Animator>().SetInteger("Y", (int)v);

        if (live == 2) liveGameObject[0].SetActive(false);
        if (live == 1) liveGameObject[1].SetActive(false);
        if (live <= 0)
        {
            liveGameObject[2].SetActive(false);
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Worm"))
        {
            live--;
        }
    }
}
