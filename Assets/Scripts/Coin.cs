using UnityEditor;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip coinClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag =="Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.coins += 1;
            player.playSFX(coinClip,0.4f);
            Destroy(gameObject);
        }
    }
}
