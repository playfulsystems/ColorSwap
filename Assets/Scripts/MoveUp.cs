using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveUp : MonoBehaviour
{
    public GameObject[] challenges;
    public GameObject changer;

    float speed = 4f;

    Rigidbody2D rb;

    float challengeEvery = 6f;
    float nextChallengeAt = 3f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	void Update()
    {
        // if lower, don't move
        if (transform.position.y < 0)
        {
            rb.bodyType = RigidbodyType2D.Static;
        }

        // how to move
        if (Input.GetKey(KeyCode.Space))
        {
			// start if stopped
			if (rb.bodyType == RigidbodyType2D.Static)
			{
                rb.bodyType = RigidbodyType2D.Dynamic;
            }

            // restart
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Score.score = 0;
            }

            // note: usually I would use AddForce on a dynamic rigidbody
            // but velocity provides a more predictable/consistent movement
            // in this particular use case
            rb.velocity = new Vector2(0, speed);
        }

        // create new things
        if (transform.position.y > nextChallengeAt)
        {
            nextChallengeAt += challengeEvery;

            Score.score++;

            // create changer at next pos
            Instantiate(changer, new Vector2(0f, nextChallengeAt + 3f), Quaternion.identity);

            // create a random challenge
            int randomChallenge = Random.Range(0, challenges.Length);
            Instantiate(challenges[randomChallenge], new Vector2(0f, nextChallengeAt), Quaternion.identity);
        }
    }
}