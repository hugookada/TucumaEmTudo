using UnityEngine;
using System.Collections;

public class VertexAnimation: MonoBehaviour
{
    public float Tamanho = 0.1f;//tamanho 
    public float Velocidade = 1.0f;// velocidade da animacao
 

    private Vector3[] baseHeight;

    void Update()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;

        if (baseHeight == null)
            baseHeight = mesh.vertices;

        Vector3[] vertices = new Vector3[baseHeight.Length];
        for (int i = 0; i < vertices.Length; i++)
        {
            Vector3 vertex = baseHeight[i];
            vertex.y += Mathf.Sin(Time.time * Velocidade + baseHeight[i].x + baseHeight[i].y + baseHeight[i].z) * Tamanho;
  
            vertices[i] = vertex;
        }
        mesh.vertices = vertices;
        mesh.RecalculateNormals();
    }
}