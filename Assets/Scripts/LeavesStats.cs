using UnityEngine;

public class LeavesStats
{
    [Header("Genes")]
    public float size;              // Taille de la feuille
    public float angle;             // Orientation en degrés
    public Color color;             // Couleur (peut influer la captation ?)

    [Header("Simulation")]
    public float energy;            // Énergie captée par la feuille

    // Initialise la feuille avec ses paramètres génétiques
    public void Init(float size, float angle, Color color)
    {
        this.size = size;
        this.angle = angle;
        this.color = color;

        transform.localScale = Vector3.one * size;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
        GetComponent<SpriteRenderer>().color = color;
    }

    // Ajoute de l'énergie à la feuille
    public void AddEnergy(float amount)
    {
        energy += amount;
    }
}