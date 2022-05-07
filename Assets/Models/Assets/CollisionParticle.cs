using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CollisionParticle : MonoBehaviour
{
    [SerializeField] ParticleSystem collectParticle = null;
    [SerializeField] ParticleSystem collectParticle2 = null;
    public ParticleSystem dust;
    public AudioSource tickSource;
    public PlayableDirector timeline;
    public PlayableDirector timeline2;
    public PlayableDirector timeline3;
    public Collider btncollider;
    public GameObject btnscript;
    public string PhysicsButton;
    void Start()
    {
        tickSource = GetComponent<AudioSource>();
        timeline = GetComponent<PlayableDirector>();
        

        GameObject varGameObject = GameObject.Find("Push");
        //  buttonCollider = GetComponent<Collider>();

    }
    private void OnTriggerEnter(Collider other)
    {
        collectParticle.Play();
        collectParticle2.Play();
        tickSource.Play();
        timeline.Play();
        timeline2.Play();
        timeline3.Play();
        //  buttonCollider.enabled = buttonCollider.enabled;
        //btncollider.enabled = true;

        
       

        



    }
}
