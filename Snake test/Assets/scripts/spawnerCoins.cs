using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerCoins : MonoBehaviour
{
    [SerializeField] private GameObject CoinPrefab;
    [SerializeField] private Transform[] CoinPositions;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateEnemy());
    }

    IEnumerator GenerateEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);

            GameObject newCoinsPrefab = Instantiate(CoinPrefab, CoinPositions[Random.Range(0, 3)].position, Quaternion.identity);
            Destroy(newCoinsPrefab, 5);
        }
    }
}
