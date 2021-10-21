using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public TMP_Text playscore;
    public int point;
    void Awake()
    {
        playscore.text = " ";
        asteroid.asteroiddestroy += destroyed;
    }
    void OnDestroy()
    {
        asteroid.asteroiddestroy -= destroyed;
    }
    void destroyed()
    {
        Debug.Log("destruido");
    }

    void Actualization()
    {
        playscore.text = point.ToString();
    }
}
