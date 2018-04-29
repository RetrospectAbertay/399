using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour {

    ParticleSystem particleSystem;

    private void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    public void ActivateParticle()
    {
        particleSystem.Play();
        StartCoroutine(DisableParticle());
    }

    IEnumerator DisableParticle()
    {
      
        yield return new WaitForSeconds(0.1f);
        particleSystem.Stop();
    }
}
