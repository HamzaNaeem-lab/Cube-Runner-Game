using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text finalscore;
    
    
    int myscore =0;
    
    void Update()
    {
        scoreText.text = myscore.ToString(); 
        finalscore.text = "Score: " +myscore.ToString();
    }
    public void addscore(int score)
    {
        myscore = myscore + score;
    }
}
