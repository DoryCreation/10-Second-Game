using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class pointsystem : MonoBehaviour
{
    public TMP_Text scoreText;
    public static int score;
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }
    void Update()
    {
        scoreText.text = "Score: " + score;
    }
    void AddPoint()
    {
        score = score + 1;
    }
    void RemovePoint()
    {
        score = score - 1;
    }
    void OnEnable()
    {
        EventManager.ScoreRemoveEvent += RemovePoint;
        EventManager.ScoreAddEvent += AddPoint;
    }
    void OnDisable()
    {
        EventManager.ScoreRemoveEvent += RemovePoint;
        EventManager.ScoreAddEvent -= AddPoint;
    }
}
