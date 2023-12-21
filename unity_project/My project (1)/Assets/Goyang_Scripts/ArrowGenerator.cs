using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 0.4f;      // ÄðÅ¸ÀÓÀÇ °³³ä
    float delta = 0;

    void Update()
    {
        delta += Time.deltaTime;    // ½Ã°£ Ã¼Å©
        if (delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}