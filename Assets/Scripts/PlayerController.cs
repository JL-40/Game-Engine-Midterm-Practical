using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Transform playerTrans;
    float distance = 0.5f;
    [SerializeField] GameObject bullet;
    Vector3 facing = Vector3.up;

    int lives = 3;


    // Start is called before the first frame update
    void Start()
    {
        playerTrans = this.transform;

        if (bullet == null)
            bullet = GameObject.Find("Bullet");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            playerTrans.Translate(playerTrans.up * distance);
            facing = Vector3.up;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            playerTrans.Translate(-playerTrans.up * distance);
            facing = -Vector3.up;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            playerTrans.Translate(playerTrans.right * distance);
            facing = Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            playerTrans.Translate(-playerTrans.right * distance);
            facing = -Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = GameObject.Instantiate(bullet);

            newBullet.GetComponent<BulletController>().Shoot(facing);
        }
    }

    public void LoseLife()
    {
        lives--;

        if (lives == 0)
        {
            GameManager.Instance.LoseGame();
        }
    }
}
