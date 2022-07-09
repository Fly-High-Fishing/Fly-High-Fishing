using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring
{
    public static int Score { get; protected set; }

    public static void AddScore(int scoreToAdd)
    {
        Score += scoreToAdd;
    }

    public static void Reset()
    {
        Score = 0;
    }
}
