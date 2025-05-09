using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    // Start is called before the first frame update
    public float time = 3;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, time);
    }
}
