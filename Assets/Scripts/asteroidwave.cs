using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidwave : MonoBehaviour
{
    public GameObject AsteroidObject;
    public int theAmount = 3;
    void Start()
    {
        for(int i = 0; i < theAmount; i++)
        {
            float x = Random.Range(-7.0f, 7.0f);
            float y = Random.Range(-4.0f, 4.0f);
            Vector3 position = new Vector3 (0.0f, 0.0f, 0.0f);
            Instantiate(AsteroidObject, position, Quaternion.identity);
        }
    }

}
