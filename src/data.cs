

enum IngredientType
{
    T1,
    T2,
    T3, 
    T4,
    TD,
    SA,
    MZ,
}

public class Recipe
{
    //name of the recipe
    public string Name { get; set; }
    // Map of ingredient type to quantity
    public Dictionary<IngredientType, int> Ingredients { get; set; }

}


//Task priority
public enum TaskPriority
{
    Low,
    Medium,
    High,
    Critical,
}
public class RecipeTask
{
    public Recipe Recipe { get; set; }
    public TaskPriority Priority { get; set; }

    
    //iterator following the step of the recipe and returning the ingredient as many as needed
    public IEnumerator<IngredientType> GetIngredientEnumerator()
    {
        foreach (var ingredient in Recipe.Ingredients)
        {
            for (int i = 0; i < ingredient.Value; i++)
            {
                yield return ingredient.Key;
            }
        }
    }
}