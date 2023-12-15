using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;

    public int score = 0;

    private void Awake()
    { 
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " / 10";
    }

    public void AddPoint()
    {
        score += 1;
		scoreText.text = score.ToString() + " / 10";

        if (score == 10) {
			SceneManager.LoadScene(3);
		}

	}



}
