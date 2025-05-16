using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject exitZone; // �L���ϰ� (�Ҧp�ǰe��)
    private GameObject[] enemies;

    void Start()
    {
        // �@�}�l��X���W�Ҧ��ĤH
        enemies = GameObject.FindGameObjectsWithTag("Worm");
        exitZone.SetActive(false); // �@�}�l�������X�{
    }

    void Update()
    {
        CheckEnemies();
    }

    void CheckEnemies()
    {
        // �C������s�ĤH�ƶq�]����s�ǡ^
        enemies = GameObject.FindGameObjectsWithTag("Worm");

        // �p�G���Q�����]�]�N�O�}�C�̨S���F��F�^
        if (enemies.Length == 0)
        {
            exitZone.SetActive(true); // �}���������X�{
        }
    }
}
