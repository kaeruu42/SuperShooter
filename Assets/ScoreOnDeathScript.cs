using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDeathScript : MonoBehaviour
{
    public int scoreToWin;

    private void Awake()
    {
        var life = GetComponent<Life>();
        life.onDeath.AddListener(GivePoints);
    }

    void GivePoints()
    {
        ScoreManager.instance.score += scoreToWin;
    }
}
