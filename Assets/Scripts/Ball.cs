using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioSource ballHit;

    public void OnMouseDown()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
        ballHit.Play();
        Destroy(gameObject);

    }
}
