using UnityEngine;

public class Target : MonoBehaviour
{
    private AudioSource mAudioSrc;
    public float health = 50f;
    public ParticleSystem deathParticle;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            
            Die();
        }
    }

    void Start()
    {
        mAudioSrc = GetComponent<AudioSource>();
    }


    void Die()
    {
        Instantiate(deathParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}