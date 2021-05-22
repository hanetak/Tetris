using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global
{
    //初期化
    public static void Init()
    {
        _score = 0;
    }
    //スコア
    static int _score;
    public static int Score
    {
        get { return _score; }
    }

    public static void ScoreAdd()
    {
        _score += 1000;
    }
}
