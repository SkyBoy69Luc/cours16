using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCamera : MonoBehaviour {
    private Material material;
	// Use this for initialization
	void Awake () {
        material = new Material(Shader.Find("Hidden/NewImageEffectShader"));

    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);

    }
}
