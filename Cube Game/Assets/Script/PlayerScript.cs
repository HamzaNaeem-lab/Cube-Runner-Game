#if UNITY_EDITOR
using JetBrains.Annotations;
using OpenCover.Framework.Model;
using UnityEngine;
using UnityEditor.Callbacks;
using UnityEditor;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float force = 1000;
    public float position = 10;
    public float maxX;
    public float minX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this method is use to stop droping(left/right) the player.
        Vector3 playerpos = transform.position;
        playerpos.x = Mathf.Clamp(playerpos.x, minX, maxX);
        transform.position = playerpos;

        //if(playerpos.x <minX)
        //{
        //    playerpos.x = minX;
        //}
        //if (playerpos.x >maxX)
        //{
        //    playerpos.x = maxX;
        //}
        //transform.position = playerpos;





        // this method is use for moving the player.
        if (Input.GetKey(KeyCode.RightArrow))
        //if(Input.GetKey(KeyCode.D))--------------> we can also use this statement
        {
            transform.position = transform.position + new Vector3(position * Time.deltaTime, 0, 0);
            // we can also move our player by using rigidbody but this make some lageness
            //rigidbody.AddForce(1000f*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        //if(Input.GetKey(KeyCode.D))--------------> we can also use this statement
        {
            transform.position = transform.position - new Vector3(position * Time.deltaTime, 0, 0);
            // we can also move our player by using rigidbody but this make some lageness
            //rigidbody.AddForce(-1000f * Time.deltaTime, 0, 0);
        }
        
        
    }
    public void FixedUpdate()
    {
        // this method is use for moving strate.
        rigidbody.AddForce(0, 0, force * Time.deltaTime);
    }
}
#endif