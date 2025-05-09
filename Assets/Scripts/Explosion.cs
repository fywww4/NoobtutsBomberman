using UnityEngine;
using UnityEngine.SceneManagement;

public class Explosion : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D co)
    {
        //if (!co.gameObject.isStatic) Destroy(co.gameObject);
        if (co.gameObject.tag != "SolidBrick") Destroy(co.gameObject);

        if (co.gameObject.CompareTag("Player"))
        {
            Move.live--;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (co.gameObject.CompareTag("Worm"))
        {
            Destroy(co.gameObject);
        }
    }

}
