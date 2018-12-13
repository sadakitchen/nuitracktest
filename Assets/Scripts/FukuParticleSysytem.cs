using UnityEngine;

public class FukuParticleSysytem : MonoBehaviour {
    
    [SerializeField] ParticleSystem particle;

    public void SetEmit( int _emit )
    {
        particle.Emit(_emit);
    }
}
