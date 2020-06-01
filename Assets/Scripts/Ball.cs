using UnityEngine;

public class Ball : MonoBehaviour
{

    public void OnMouseDown()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
        Destroy(gameObject);

    }
}
