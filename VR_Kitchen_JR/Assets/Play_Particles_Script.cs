using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Particles_Script : MonoBehaviour
{
    [SerializeField] private ParticleSystem Ps;
    public void Ungrabbed()
    {
        Ps.Stop();
    }
    public void Grabbed()
    {
        Ps.Play();
    }
}