using UnityEngine;
using UnityEngine.Video;

public class videoPlayController : MonoBehaviour
{
    public VideoPlayer vp;
    public Texture defaultTexture;
    public RenderTexture renderTexture;

    private void OnEnabled() 
    {
        if (vp != null) vp.Play();
    }

    private void OnDisabled()
    {
        if (vp != null) {

            vp.Stop();
            Graphics.Blit(defaultTexture, renderTexture);
        
        }
    }
}
