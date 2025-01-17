using UnityEngine;

public class Pipe : MonoBehaviour
{
    AudioSource source;
    public AudioClip ScoreSound;

    public float speed;

    public float startX;
    public float endX;
    void Start()
    {
        startX = Camera.main.ViewportToWorldPoint(new Vector3(0, 0)).x - 1;
        endX = Camera.main.ViewportToWorldPoint(new Vector3(1, 0)).x + 1;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // teleport back
        if (transform.position.x < startX)
        {
            var height = Random.Range(-1f, 4f);
            transform.position = new Vector3(endX, height);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("pipePair"))
        {
            source.clip = ScoreSound;
            source.Play();
        }
    }
}
