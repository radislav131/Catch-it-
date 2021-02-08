using System.Collections;
using UnityEngine;

public class FlappyBird : MonoBehaviour
{
    public GameObject bird,many,bird2;
   
   
    
    void Start()
    {
        StartCoroutine(Spawn());
        StartCoroutine(Calls());
        Invoke("BirdC", 4f);
        
    }
    void BirdC()
    {
        StartCoroutine(Bird2());

    }
    IEnumerator Spawn()
    {
        while (!player.lose)
        {
            Instantiate(bird, new Vector2(3.5f, Random.Range(-5.5f, 4.4f)), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            

        }
    }
    IEnumerator Calls()
    {
        
    
        while (!player.lose)
        {
            Instantiate(many, new Vector2(Random.Range(-2.6f, 2.6f), Random.Range(-4.7f, 4.7f)), Quaternion.identity);
            yield return new WaitForSeconds(2f);
            

        }
    }
    IEnumerator Bird2()
    {
        while (!player.lose)
        {
            Instantiate(bird2, new Vector2(-3.5f, Random.Range(0f, 6.4f)), Quaternion.identity);
            yield return new WaitForSeconds(6f);


        }
    }


        }
    





