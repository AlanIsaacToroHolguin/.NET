# .NET
A repo for an introducciton and basic Terms about .NET &amp; C# 

public class Sale
{
    // Propiedad pública con get y set
    public decimal Total { get; private set; } // si no quieres permitir set desde fuera, usa private set.

    // Campo privado de ejemplo para encapsulación
    private decimal _some;

    // Constructor
    public Sale(decimal total)
    {
        this.Total = total; // "this" referencia a la instancia actual
        _some = 8m;         // ejemplo de uso de un campo privado
       }

    // Método público
    public string GetInfo()
    {
        return $"El total es {Total}"; // usa interpolación de cadenas
    }

