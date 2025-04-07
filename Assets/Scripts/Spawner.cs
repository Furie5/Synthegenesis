using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;     // Prefab à instancier
    public int count = 10;        // Nombre d'instances à créer

    void Start()
    {
        for (int i = 0; i < count; i++)
        {
            // Position aléatoire dans une zone
            Vector2 pos = new Vector2(Random.Range(-5f, 5f), Random.Range(-3f, 3f));
            GameObject leaf = Instantiate(prefab, pos, Quaternion.identity);

            // Gènes aléatoires
            float size = Random.Range(0.5f, 1.5f);
            float angle = Random.Range(0f, 360f);
            Color color = new Color(Random.value, Random.value, Random.value);

            // Initialisation génétique
            leaf.GetComponent<FeuilleStats>().Init(size, angle, color);
        }
    }
}
