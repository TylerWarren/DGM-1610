using UnityEngine;
using UnityEngine.Events;

public class ParticleSystem : MonoBehaviour
{
   void OnParticleTrigger()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();

    
        List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();
        List<ParticleSystem.Particle> exit = new List<ParticleSystem.Particle>();

       
        int numEnter = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
        int numExit = ps.GetTriggerParticles(ParticleSystemTriggerEventType.Exit, exit);

        
        for (int i = 0; i < numEnter; i++)
        {
            ParticleSystem.Particle p = enter[i];
            p.startColor = new Color32(455, 2, 0, 095);
            enter[i] = p;
        }
  
        ps.SetTriggerParticles(ParticleSystemTriggerEventType.Enter, enter);
        ps.SetTriggerParticles(ParticleSystemTriggerEventType.Exit, exit);
    }
}
