using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ParticleCollison : MonoBehaviour
{
    [SerializeField] ParticleSystem collectParticle = null;
    [SerializeField] ParticleSystem collectParticle2 = null;
    public ParticleSystem dust;
    public AudioSource tickSource;
    public PlayableDirector timeline;
    public PlayableDirector timeline2;
    
    // Start is called before the first frame update
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
        timeline = GetComponent<PlayableDirector>();

    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        collectParticle.Play();
        collectParticle2.Play();
        tickSource.Play();
        timeline.Play();
        timeline2.Play();
       

    }
}
