using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CGameManager : _MonoBehaviour
{
    private static Text scoreText;
    public static Text ScoreText { get { return scoreText; } private set {; } }
    private static float laserDamage = 50.0f;
    public static float LaserDamage { get { return laserDamage; } private set {; } }
    private static float shotDelayTime = 0.1f;
    public static float ShotDelayTime { get { return shotDelayTime; } private set {; } }

    // Use this for initialization
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
