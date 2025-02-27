using System;
using UnityEngine;
using UnityEngine.Rendering;

public class LevelsCompleted : MonoBehaviour
{
    private static int numOfLevels = 4;
    public static bool[] levelsCompleted;
    public static int currentLevel = 0;
    // 

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        levelsCompleted = new bool[numOfLevels];
        for (int i = 0; i < numOfLevels; i++)
        {
            levelsCompleted[i] = false;
        }
    }

    public static void completeLevel(int level)
    {
        levelsCompleted[level] = true;
    }

}

