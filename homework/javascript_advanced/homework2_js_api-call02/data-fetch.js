// Task: Make a call with JSON Recipes and pull data

const fetchRecipesData = async () => {
  const url = 'https://dummyjson.com/recipes';

  try {
    const response = await fetch(url);
    const data = await response.json();
    console.log(data);

    // Get all desserts
    const desserts = data.recipes.filter(r => r.mealType.includes('Dessert'));
    console.log('Desserts:', desserts);

    // Names of recipes with more than 30 reviews
    const recipesWithMoreThan30Reviews = data.recipes.filter(r => r.reviewCount > 30);
    const recipesMoreThan30ReviewsNames = recipesWithMoreThan30Reviews.map(r => r.name);
    console.log('Recipes with over 30 reviews:', recipesMoreThan30ReviewsNames);

    // All recipes with Cinnamon as an ingredient
    const cinnamonIngredientRecipes = data.recipes.filter(r => r.ingredients.includes('Cinnamon'));
    console.log('Recipes including Cinnamon:', cinnamonIngredientRecipes);

    // Recipes served both as Lunch and Dinner
    const recipesAsLunchDinner = data.recipes.filter(r => r.mealType.includes('Lunch') && r.mealType.includes('Dinner'));
    console.log('Recipes served both as Lunch and Dinner:', recipesAsLunchDinner);

    // Ingredients for "Mango Salsa Chicken" dish
    const mangoSalsaChicken = data.recipes.filter(r => r.name === 'Mango Salsa Chicken');
    const mangoSalsaChickenIngredients = mangoSalsaChicken.map(r => r.ingredients);
    console.log('Ingredients for Mango Salsa Chicken', mangoSalsaChickenIngredients);

    // Average number of calories for all American cuisine recipes
    const americanCuisine = data.recipes.filter(r => r.cuisine === 'American');
    console.log('Average is', americanCuisine[0].caloriesPerServing, 'calories, since there is only 1 American cuisine');

    // Average cooking time of all Pasta
    const pastaRecipes = data.recipes.filter(r => r.name.includes('Pasta'));
    const averagePastaCookingTime = pastaRecipes.reduce((acc, curr) => acc + curr.cookTimeMinutes, 0) / pastaRecipes.length;
    console.log('Average cooking time of Pasta:', averagePastaCookingTime, 'min');

    // Recipe with the lowest number of reviews
    const lowestReviewRecipe = data.recipes.sort((a, b) => a.reviewCount - b.reviewCount)[0];
    console.log('Recipe with the lowest number of reviews:', lowestReviewRecipe);
    
  } catch (error) {
    console.error('Error fetching:', error);
  }
};

fetchRecipesData();