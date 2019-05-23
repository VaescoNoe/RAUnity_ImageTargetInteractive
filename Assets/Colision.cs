
using UnityEngine;
using Vuforia;

public class Colision : MonoBehaviour, ITrackableEventHandler
{

    protected TrackableBehaviour mTrackableBehaviour;
    public MeshRenderer esfera;
    public MeshRenderer cubo;
    public Material rojo, verde;



    public void OnTrackableStateChanged(
    TrackableBehaviour.Status previousStatus,
    TrackableBehaviour.Status newStatus)
    {
      

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
           
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
           
        }
        else
        {
          
        }
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "verde")
        {
            esfera.material = verde;
            cubo.material = rojo;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "verde")
        {
            esfera.material = rojo;
            cubo.material = verde;
        }

    }
}
