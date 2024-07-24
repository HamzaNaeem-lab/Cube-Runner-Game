using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    public Score score;
    public GameControler gameControler;

    /// <summary>
    /// these two(2) method are are same but different collision
    /// </summary>

    //private void OnCollisionEnter(Collision other)
    //{
    //    if(other.gameObject.tag == "collectable")
    //    {
    //        Destroy(other.gameObject);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collectable")
        {
            score.addscore(1);
            Destroy(other.gameObject);
        }
    }


    /// <summary>
    /// this methode is use to stop the movement of the plyer if they hit the wrong cube
    /// </summary>

    public PlayerScript playerscript;

    
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "obstacles")
        {
            gameControler.GameOver();
            playerscript.enabled = false;
        }
    }


}
