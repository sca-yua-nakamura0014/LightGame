using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackUpBook : MonoBehaviour
{
    //攻撃力UP

    GameObject player;
    PlayerControl script;

    //効果音
    public GameObject bookSound;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        script = player.GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(bookSound, this.transform.position, this.transform.rotation);//効果音
            float rnd = Random.Range(0, 1f);

            if (rnd <= 0.3f)
            {
                script.Power += 5.0f;
            }
            if (rnd <= 0.7f)
            {
                script.Power += 4.0f;
            }
            else
            {
                script.Power += 3.0f;
            }
            Destroy(gameObject);
        }

    }
}
