using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer mRenderer;

    public float animationSpeed = 1.0f;

    private void Awake(){
        mRenderer = GetComponent<MeshRenderer>();
    }

    private void Update(){
        mRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
