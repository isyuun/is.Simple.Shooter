using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CGameManager : _MonoBehaviour
{
    public static Text ScoreText;
    // Use this for initialization
    void Start()
    {
        ScoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
