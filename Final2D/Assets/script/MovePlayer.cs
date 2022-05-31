using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MovePlayer : MonoBehaviour
{
    public Text bonus; 
    public int speed;
    public int point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey("s"))
        {
            transform.position -= new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey("a"))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D player)
    {
        if (player.gameObject.tag == "Point")
        {
            point += 5;
            bonus.text = "Bonus :" + point.ToString();
            Destroy(player.gameObject);
        }
        if (player.gameObject.tag == "Augapat")
        {
            point -= 1;
            bonus.text = "Bonus :" + point.ToString();
            Destroy(player.gameObject);
        }
    }


}
