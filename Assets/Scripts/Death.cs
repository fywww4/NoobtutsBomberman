using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public float speed = 2;
    Vector2 randDir()
    {
        // Set one component to -1/0/1 and one to 0
        int r = Random.Range(-1, 2);
        return (Random.value < 0.5) ? new Vector2(r, 0) : new Vector2(0, r);
    }

    bool isValidDir(Vector2 dir)
    {
        // Linecast to find out if anything is between worm and worm+dir
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider.gameObject == gameObject);
    }

    void changeDir()
    {
        Vector2 dir = randDir();
        if (isValidDir(dir))
        {
            GetComponent<Rigidbody2D>().velocity = dir * speed;
            transform.position = new Vector3(Mathf.Round(transform.position.x),
                                             Mathf.Round(transform.position.y), 0);
            GetComponent<Animator>().SetInteger("X", (int)dir.x);
            GetComponent<Animator>().SetInteger("Y", (int)dir.y);
        }
    }

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("changeDir", 0, 0.5f);
    }
}
