using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private TextMesh _hpText;
    private TextMesh _scoreText;
    private int _hp = 100;
    private int _score = 0;

    void Awake()
    {
        _hpText = GameObject.Find("HealthText").GetComponent<TextMesh>();
        _scoreText=GameObject.Find("ScoreText").GetComponent<TextMesh>();

        _hpText.text = _hp.ToString();
        _scoreText.text = _score.ToString();
    }

    private void CheckHP()
    {
        _hpText.text = _hp.ToString();
        if (_hp <= 0)
        {
            _hpText.text = "0";
            //here this.componentWhichEnablesDestroy.Etc
        }
    }

    private void UpdateScore()
    {
        _scoreText.text = _score.ToString();
    }

    public void ChangeHP(int value)
    {
        _hp += value;
        CheckHP();
    }

    public void ChangeScore(int value)
    {
        _score += value;
        UpdateScore();
    }
}
