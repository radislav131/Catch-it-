using UnityEngine;

public class player : MonoBehaviour
{
   public static bool lose = false;
    public GameObject restart;
   void Awake()
    {
        lose = false;
    }
    
    
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Bird")
        {
            lose = true;
            restart.SetActive(true);
        }
       
    }
    
}
