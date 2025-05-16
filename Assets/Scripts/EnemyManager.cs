using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject exitZone; // 過關區域 (例如傳送門)
    private GameObject[] enemies;

    void Start()
    {
        // 一開始找出場上所有敵人
        enemies = GameObject.FindGameObjectsWithTag("Worm");
        exitZone.SetActive(false); // 一開始不讓門出現
    }

    void Update()
    {
        CheckEnemies();
    }

    void CheckEnemies()
    {
        // 每次都更新敵人數量（防止有新怪）
        enemies = GameObject.FindGameObjectsWithTag("Worm");

        // 如果都被打光（也就是陣列裡沒有東西了）
        if (enemies.Length == 0)
        {
            exitZone.SetActive(true); // 開門或讓門出現
        }
    }
}
